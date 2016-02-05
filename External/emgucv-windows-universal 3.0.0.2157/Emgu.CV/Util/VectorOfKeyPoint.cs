﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2015 by EMGU Corporation. All rights reserved.
//
//  Vector of KeyPoint
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;
#if !NETFX_CORE
using System.Runtime.Serialization;
#endif

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of KeyPoint.
   /// </summary>
#if !NETFX_CORE
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfKeyPoint.DebuggerProxy))]
#endif
   public partial class VectorOfKeyPoint : Emgu.Util.UnmanagedObject, IInputOutputArray
#if !NETFX_CORE
   , ISerializable
#endif
   {
      private bool _needDispose;
   
      static VectorOfKeyPoint()
      {
         CvInvoke.CheckLibraryLoaded();
      }

#if !NETFX_CORE
      /// <summary>
      /// Constructor used to deserialize runtime serialized object
      /// </summary>
      /// <param name="info">The serialization info</param>
      /// <param name="context">The streaming context</param>
      public VectorOfKeyPoint(SerializationInfo info, StreamingContext context)
         : this()
      {
         Push((MKeyPoint[])info.GetValue("KeyPointArray", typeof(MKeyPoint[])));
      }
	  
	  /// <summary>
      /// A function used for runtime serialization of the object
      /// </summary>
      /// <param name="info">Serialization info</param>
      /// <param name="context">Streaming context</param>
      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue("KeyPointArray", ToArray());
      }
#endif

      /// <summary>
      /// Create an empty standard vector of KeyPoint
      /// </summary>
      public VectorOfKeyPoint()
         : this(VectorOfKeyPointCreate(), true)
      {
      }
	  
	  internal VectorOfKeyPoint(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of KeyPoint of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfKeyPoint(int size)
         : this( VectorOfKeyPointCreateSize(size), true)
      {
      }
	  
	  /// <summary>
      /// Create an standard vector of KeyPoint with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
	  public VectorOfKeyPoint(MKeyPoint[] values)
         :this()
      {
         Push(values);
      }
	  
      /// <summary>
      /// Push an array of value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(MKeyPoint[] value)
      {
         if (value.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
            VectorOfKeyPointPushMulti(_ptr, handle.AddrOfPinnedObject(), value.Length);
            handle.Free();
         }
      }
	  
	  /// <summary>
      /// Convert the standard vector to an array of KeyPoint
      /// </summary>
      /// <returns>An array of KeyPoint</returns>
      public MKeyPoint[] ToArray()
      {
         MKeyPoint[] res = new MKeyPoint[Size];
         if (res.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(res, GCHandleType.Pinned);
            VectorOfKeyPointCopyData(_ptr, handle.AddrOfPinnedObject());
            handle.Free();
         }
         return res;
      }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfKeyPointGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfKeyPointClear(_ptr);
      }

      /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public IntPtr StartAddress
      {
         get
         {
            return VectorOfKeyPointGetStartAddress(_ptr);
         }
      }
	  
	  /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public MKeyPoint this[int index]
      {
         get
         {
            MKeyPoint result = new MKeyPoint();
            VectorOfKeyPointGetItem(_ptr, index, ref result);
            return result;
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfKeyPointRelease(ref _ptr);
      }

	  /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      public InputArray GetInputArray()
      {
         return new InputArray( cvInputArrayFromVectorOfKeyPoint(_ptr) );
      }
	  
	  /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cvOutputArrayFromVectorOfKeyPoint(_ptr) );
      }

	  /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cvInputOutputArrayFromVectorOfKeyPoint(_ptr) );
      }
	  
      internal class DebuggerProxy
      {
         private VectorOfKeyPoint _v;

         public DebuggerProxy(VectorOfKeyPoint v)
         {
            _v = v;
         }

         public MKeyPoint[] Values
         {
            get { return _v.ToArray(); }
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfKeyPointCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfKeyPointCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfKeyPointRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfKeyPointGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfKeyPointCopyData(IntPtr v, IntPtr data);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfKeyPointGetStartAddress(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfKeyPointPushMulti(IntPtr v, IntPtr values, int count);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfKeyPointClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfKeyPointGetItem(IntPtr vec, int index, ref MKeyPoint element);
	  
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputArrayFromVectorOfKeyPoint(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvOutputArrayFromVectorOfKeyPoint(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputOutputArrayFromVectorOfKeyPoint(IntPtr vec);
   }
}
