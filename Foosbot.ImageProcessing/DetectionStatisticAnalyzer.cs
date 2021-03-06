﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foosbot.ImageProcessing
{
    /// <summary>
    /// Detection Statistical Analyzer for image processing unit
    /// </summary>
    public class DetectionStatisticAnalyzer
    {
        #region Private Members

        /// <summary>
        /// Current Working Second timestamp
        /// </summary>
        private DateTime _currenWorkingSecond;

        /// <summary>
        /// Total Frames received in last second
        /// </summary>
        private int _totalFramesPerSecond;

        /// <summary>
        /// Total Successfull detection for last second
        /// </summary>
        private int _successDetectionFrame;

        /// <summary>
        /// Time spent on ball location detection in past second
        /// </summary>
        private TimeSpan _spentOnDetectionInSecond;

        /// <summary>
        /// Detection Stopwatch
        /// </summary>
        private Stopwatch detectionWatch;

        /// <summary>
        /// Update Statistics Delegate
        /// </summary>
        private Helpers.UpdateStatisticsDelegate UpdateStatistics;

        #endregion Private Members

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="onUpdateStatistics">Update statistics delegate function</param>
        public DetectionStatisticAnalyzer(Helpers.UpdateStatisticsDelegate onUpdateStatistics)
        {
            UpdateStatistics = onUpdateStatistics;
            _currenWorkingSecond = DateTime.Now;
        }

        /// <summary>
        /// Steps to perform each detection started
        /// 1. Count frame
        /// 2. Start detection stopwatch
        /// If not same second as in prevoius frame then update statistics and start from the beginning
        /// </summary>
        public void Next()
        {
            DateTime now = DateTime.Now;
            if (_currenWorkingSecond.Second != now.Second)
            {
                double rate = (_totalFramesPerSecond < 1) ? 100 : 100 * _successDetectionFrame / _totalFramesPerSecond;
                double aveDetectTime = (_totalFramesPerSecond < 1) ? 0 : _spentOnDetectionInSecond.Milliseconds / _totalFramesPerSecond;
                UpdateStatistics(Helpers.eStatisticsKey.BasicImageProcessingInfo,
                    String.Format("Detection: Rate {0}% ({1}/{2}) Average T {3}(ms)",
                        rate, _successDetectionFrame, _totalFramesPerSecond, aveDetectTime));
                _totalFramesPerSecond = 0;
                _successDetectionFrame = 0;
                _spentOnDetectionInSecond = TimeSpan.FromMilliseconds(0);
                _currenWorkingSecond = now;
            }
            _totalFramesPerSecond++;
            detectionWatch = Stopwatch.StartNew();
        }

        /// <summary>
        /// Steps to perform after each detection finished
        /// 1. Count detection if succesfull
        /// 2. Stop the detection stopwatch
        /// </summary>
        /// <param name="isBallLocationFound">Detection result</param>
        public void Finalize(bool isBallLocationFound)
        {
            detectionWatch.Stop();
            _spentOnDetectionInSecond += detectionWatch.Elapsed;
            if (isBallLocationFound)
                _successDetectionFrame++;
        }
    }
}
