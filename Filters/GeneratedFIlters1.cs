
//The Code in this file is generated, any changes are deleted the next time the code gets generated.
//You are able to store your changes if you edit the T4 Template.

using global::AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using global::AForge.Imaging;
using ImageProcessingLibrary.AForge;
using ImageProcessingLibrary;

namespace ImageProcessingLibrary.AccordNet.Filters
{

// Searching Assembly for Reflection: Accord.Imaging
//Scanning Path for dll Accord.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AccordNet\Filters\Accord.Imaging.dll
//Scanning Path for dll Accord.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AccordNet\Accord.Imaging.dll
//Scanning Path for dll Accord.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AccordNet\bin\Accord.Imaging.dll
//Scanning Path for dll Accord.Imaging : C:\DEV\Vision\ImageProcessingLibrary.AccordNet\bin\Debug\Accord.Imaging.dll
//Accord.Imaging found: C:\DEV\Vision\ImageProcessingLibrary.AccordNet\bin\Debug\Accord.Imaging.dll
//Added to Dll lookup Dir: C:\DEV\Vision\ImageProcessingLibrary.AccordNet\bin\Debug


	public class KuwaharaActivity : AForgeActivity
	{
		public global::System.Int32 Size { get;set;}

		public KuwaharaActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.Kuwahara();
		  this.Size = tmp.Size;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.Kuwahara();
			result.Size = this.Size;
		   return result;
        }


	}
		

	public class WhitePatchActivity : AForgeActivity
	{
		
		public WhitePatchActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.WhitePatch();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.WhitePatch();
					   return result;
        }


	}
		

	public class HighBoostActivity : AForgeActivity
	{
		public global::System.Int32 Size { get;set;}
public global::System.Int32 Boost { get;set;}
public global::System.Int32[,] Kernel { get;set;}
public global::System.Int32 Divisor { get;set;}
public global::System.Int32 Threshold { get;set;}
public global::System.Boolean DynamicDivisorForEdges { get;set;}
public global::System.Boolean ProcessAlpha { get;set;}

		public HighBoostActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.HighBoost();
		  this.Size = tmp.Size;
this.Boost = tmp.Boost;
this.Kernel = tmp.Kernel;
this.Divisor = tmp.Divisor;
this.Threshold = tmp.Threshold;
this.DynamicDivisorForEdges = tmp.DynamicDivisorForEdges;
this.ProcessAlpha = tmp.ProcessAlpha;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.HighBoost();
			result.Size = this.Size;
result.Boost = this.Boost;
result.Kernel = this.Kernel;
result.Divisor = this.Divisor;
result.Threshold = this.Threshold;
result.DynamicDivisorForEdges = this.DynamicDivisorForEdges;
result.ProcessAlpha = this.ProcessAlpha;
		   return result;
        }


	}
		

	public class GrayWorldActivity : AForgeActivity
	{
		
		public GrayWorldActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.GrayWorld();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.GrayWorld();
					   return result;
        }


	}
		

	public class DifferenceOfGaussiansActivity : AForgeActivity
	{
		public global::AForge.Imaging.Filters.GaussianBlur First { get;set;}
public global::AForge.Imaging.Filters.GaussianBlur Second { get;set;}
public global::AForge.Imaging.Filters.Subtract Subtract { get;set;}

		public DifferenceOfGaussiansActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.DifferenceOfGaussians();
		  this.First = tmp.First;
this.Second = tmp.Second;
this.Subtract = tmp.Subtract;

		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.DifferenceOfGaussians();
			result.First = this.First;
result.Second = this.Second;
result.Subtract = this.Subtract;
		   return result;
        }


	}
		

	public class LogarithmActivity : AForgeActivity
	{
		
		public LogarithmActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.Logarithm();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.Logarithm();
					   return result;
        }


	}
		

	public class ExponentialActivity : AForgeActivity
	{
		
		public ExponentialActivity()
		{
		    //reading out the frmaeworks default values.
		    var tmp = new global::Accord.Imaging.Filters.Exponential();
		  
		}

		protected override IInPlaceFilter GetFilter(ActivityContext context)
        {
			var result = new global::Accord.Imaging.Filters.Exponential();
					   return result;
        }


	}
		}
//Loaded from C:\DEV\Vision\ImageProcessingLibrary.AccordNet\bin\Debug
