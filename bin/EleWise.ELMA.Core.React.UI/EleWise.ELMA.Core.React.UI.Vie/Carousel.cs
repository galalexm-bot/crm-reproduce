using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Carousel
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CAutoplay_003Ek__BackingField;

		private bool _003CPauseOnHover_003Ek__BackingField;

		private int _003CCountOfSlides_003Ek__BackingField;

		private int _003CSlidesToScroll_003Ek__BackingField;

		private bool _003CInfinityLoop_003Ek__BackingField;

		private bool _003CMouseShift_003Ek__BackingField;

		private bool _003CVariableWidth_003Ek__BackingField;

		private int _003CSpeed_003Ek__BackingField;

		private bool _003CDots_003Ek__BackingField;

		private bool _003CArrows_003Ek__BackingField;

		private bool _003CCenterMode_003Ek__BackingField;

		private bool _003CFocusOnSelect_003Ek__BackingField;

		private bool _003CSwipeToSlide_003Ek__BackingField;

		[Name("autoplay")]
		public bool Autoplay
		{
			get
			{
				return _003CAutoplay_003Ek__BackingField;
			}
			set
			{
				_003CAutoplay_003Ek__BackingField = value;
			}
		}

		[Name("pauseOnHover")]
		public bool PauseOnHover
		{
			get
			{
				return _003CPauseOnHover_003Ek__BackingField;
			}
			set
			{
				_003CPauseOnHover_003Ek__BackingField = value;
			}
		}

		[Name("countOfSlides")]
		public int CountOfSlides
		{
			get
			{
				return _003CCountOfSlides_003Ek__BackingField;
			}
			set
			{
				_003CCountOfSlides_003Ek__BackingField = value;
			}
		}

		[Name("slidesToScroll")]
		public int SlidesToScroll
		{
			get
			{
				return _003CSlidesToScroll_003Ek__BackingField;
			}
			set
			{
				_003CSlidesToScroll_003Ek__BackingField = value;
			}
		}

		[Name("infinityLoop")]
		public bool InfinityLoop
		{
			get
			{
				return _003CInfinityLoop_003Ek__BackingField;
			}
			set
			{
				_003CInfinityLoop_003Ek__BackingField = value;
			}
		}

		[Name("mouseShift")]
		public bool MouseShift
		{
			get
			{
				return _003CMouseShift_003Ek__BackingField;
			}
			set
			{
				_003CMouseShift_003Ek__BackingField = value;
			}
		}

		[Name("variableWidth")]
		public bool VariableWidth
		{
			get
			{
				return _003CVariableWidth_003Ek__BackingField;
			}
			set
			{
				_003CVariableWidth_003Ek__BackingField = value;
			}
		}

		[Name("speed")]
		public int Speed
		{
			get
			{
				return _003CSpeed_003Ek__BackingField;
			}
			set
			{
				_003CSpeed_003Ek__BackingField = value;
			}
		}

		[Name("dots")]
		public bool Dots
		{
			get
			{
				return _003CDots_003Ek__BackingField;
			}
			set
			{
				_003CDots_003Ek__BackingField = value;
			}
		}

		[Name("arrows")]
		public bool Arrows
		{
			get
			{
				return _003CArrows_003Ek__BackingField;
			}
			set
			{
				_003CArrows_003Ek__BackingField = value;
			}
		}

		[Name("centerMode")]
		public bool CenterMode
		{
			get
			{
				return _003CCenterMode_003Ek__BackingField;
			}
			set
			{
				_003CCenterMode_003Ek__BackingField = value;
			}
		}

		[Name("focusOnSelect")]
		public bool FocusOnSelect
		{
			get
			{
				return _003CFocusOnSelect_003Ek__BackingField;
			}
			set
			{
				_003CFocusOnSelect_003Ek__BackingField = value;
			}
		}

		[Name("swipeToSlide")]
		public bool SwipeToSlide
		{
			get
			{
				return _003CSwipeToSlide_003Ek__BackingField;
			}
			set
			{
				_003CSwipeToSlide_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Carousel, {props}, {children})")]
	public extern Carousel(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Carousel source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Carousel source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
