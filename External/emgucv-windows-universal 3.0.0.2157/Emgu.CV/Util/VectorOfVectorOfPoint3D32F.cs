﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2015 by EMGU Corporation. All rights reserved.
//
//  Vector of VectorOfPoint3D32F
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of VectorOfPoint3D32F.
   /// </summary>
   public partial class VectorOfVectorOfPoint3D32F : Emgu.Util.UnmanagedObject, IInputOutputArray
   {
      private bool _needDispose;
   
      static VectorOfVectorOfPoint3D32F()
      {
         CvInvoke.CheckLibraryLoaded();
      }

      /// <summary>
      /// Create an empty standard vector of VectorOfPoint3D32F
      /// </summary>
      public VectorOfVectorOfPoint3D32F()
         : this(VectorOfVectorOfPoint3D32FCreate(), true)
      {
      }
	  
	  internal VectorOfVectorOfPoint3D32F(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of VectorOfPoint3D32F of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfVectorOfPoint3D32F(int size)
         : this( VectorOfVectorOfPoint3D32FCreateSize(size), true)
      {
      }
	  
	  /// <summary>
      /// Create an standard vector of VectorOfPoint3D32F with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
	  public VectorOfVectorOfPoint3D32F(params VectorOfPoint3D32F[] values)
	     : this()
	  {
         foreach(VectorOfPoint3D32F v in values)
            Push(v);
	  }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfVectorOfPoint3D32FGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfVectorOfPoint3D32FClear(_ptr);
      }
	  
	  /// <summary>
      /// Push a value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(VectorOfPoint3D32F value)
      {
         VectorOfVectorOfPoint3D32FPush(_ptr, value.Ptr);
      }

      /// <summary>
      /// Push multiple values into the standard vector
      /// </summary>
      /// <param name="values">The values to be pushed to the vector</param>
      public void Push(VectorOfPoint3D32F[] values)
      {
         foreach (VectorOfPoint3D32F value in values)
            Push(value);
      }
	  
	  /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public VectorOfPoint3D32F this[int index]
      {
         get
         {
		    IntPtr itemPtr = IntPtr.Zero;
            VectorOfVectorOfPoint3D32FGetItemPtr(_ptr, index, ref itemPtr);
            return new VectorOfPoint3D32F(itemPtr, false);
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfVectorOfPoint3D32FRelease(ref _ptr);
      }

	  /// <summary>
      /// Get the pointer to cv::_InputArray
      /// </summary>
      public InputArray GetInputArray()
      {
        return new InputArray( cvInputArrayFromVectorOfVectorOfPoint3D32F(_ptr) );
      }
	  
      /// <summary>
      /// Get the pointer to cv::_OutputArray
      /// </summary>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cvOutputArrayFromVectorOfVectorOfPoint3D32F(_ptr) );
      }

	  /// <summary>
      /// Get the pointer to cv::_InputOutputArray
      /// </summary>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cvInputOutputArrayFromVectorOfVectorOfPoint3D32F(_ptr) );
      }

#if true
      /// <summary>
      /// Create the standard vector of VectorOfPoint3D32F 
      /// </summary>
      public VectorOfVectorOfPoint3D32F(MCvPoint3D32f[][] values)
         : this()
      {
         using (VectorOfPoint3D32F v = new VectorOfPoint3D32F())
         {
            for (int i = 0; i < values.Length; i++)
            {
               v.Push(values[i]);
               Push(v);
               v.Clear();
            }
         }
      }
	  
	  /// <summary>
      /// Convert the standard vector to arrays of int
      /// </summary>
      /// <returns>Arrays of int</returns>
      public MCvPoint3D32f[][] ToArrayOfArray()
      {
         int size = Size;
         MCvPoint3D32f[][] res = new MCvPoint3D32f[size][];
         for (int i = 0; i < size; i++)
         {
            using (VectorOfPoint3D32F v = this[i])
            {
               res[i] = v.ToArray();
            }
         }
         return res;
      }
#endif

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfPoint3D32FCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfVectorOfPoint3D32FCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPoint3D32FRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfVectorOfPoint3D32FGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPoint3D32FPush(IntPtr v, IntPtr value);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPoint3D32FClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfVectorOfPoint3D32FGetItemPtr(IntPtr vec, int index, ref IntPtr element);
	  
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputArrayFromVectorOfVectorOfPoint3D32F(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvOutputArrayFromVectorOfVectorOfPoint3D32F(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cvInputOutputArrayFromVectorOfVectorOfPoint3D32F(IntPtr vec);
   }
}
