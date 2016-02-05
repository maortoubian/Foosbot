//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV
{
   public static partial class CvInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveUMatIsContinuous(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveUMatIsSubmatrix(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern CvEnum.DepthType cveUMatDepth(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveUMatIsEmpty(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveUMatNumberOfChannels(IntPtr obj);
     
   }

   public partial class UMat
   {

     /// <summary>
     /// True if the data is continues
     /// </summary>
     public bool IsContinuous
     {
        get { return CvInvoke.cveUMatIsContinuous(_ptr); } 
     }
     
     /// <summary>
     /// True if the matrix is a submatrix of another matrix
     /// </summary>
     public bool IsSubmatrix
     {
        get { return CvInvoke.cveUMatIsSubmatrix(_ptr); } 
     }
     
     /// <summary>
     /// Depth type
     /// </summary>
     public CvEnum.DepthType Depth
     {
        get { return CvInvoke.cveUMatDepth(_ptr); } 
     }
     
     /// <summary>
     /// True if the matrix is empty
     /// </summary>
     public bool IsEmpty
     {
        get { return CvInvoke.cveUMatIsEmpty(_ptr); } 
     }
     
     /// <summary>
     /// Number of channels
     /// </summary>
     public int NumberOfChannels
     {
        get { return CvInvoke.cveUMatNumberOfChannels(_ptr); } 
     }
     
   }
}