using Xamarin.Forms;

namespace StudentManagement.Controls
{
    /// <summary>
    /// Enum GradientOrientation
    /// </summary>
    public enum GradientOrientation
    {
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical,

        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal
    }

    /// <inheritdoc />
    /// <summary>
    /// ContentView that allows you to have a Gradient for
    /// the background. Let there be Gradients!
    /// </summary>
    public class GradientContentView : ContentView
    {
        /// <summary>
        /// Start color of the gradient
        /// Defaults to White
        /// </summary>
        public GradientOrientation Orientation
        {
            get => (GradientOrientation)GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }

        /// <summary>
        /// The orientation property
        /// </summary>
        public static readonly BindableProperty OrientationProperty =
            BindableProperty.Create(nameof(Orientation), typeof(GradientOrientation), typeof(GradientContentView),
                GradientOrientation.Vertical);

        /// <summary>
        /// Start color of the gradient
        /// Defaults to White
        /// </summary>
        public Color StartColor
        {
            get => (Color)GetValue(StartColorProperty);
            set => SetValue(StartColorProperty, value);
        }

        /// <summary>
        /// Using a BindableProperty as the backing store for StartColor.  This enables animation, styling, binding, etc...
        /// </summary>
        public static readonly BindableProperty StartColorProperty =
            BindableProperty.Create(nameof(StartColor), typeof(Color), typeof(GradientContentView), Color.White);

        /// <summary>
        /// End color of the gradient
        /// Defaults to Black
        /// </summary>
        public Color EndColor
        {
            get => (Color)GetValue(EndColorProperty);
            set => SetValue(EndColorProperty, value);
        }

        /// <summary>
        /// Using a BindableProperty as the backing store for EndColor.  This enables animation, styling, binding, etc...
        /// </summary>
        public static readonly BindableProperty EndColorProperty =
            BindableProperty.Create(nameof(EndColor), typeof(Color), typeof(GradientContentView), Color.Black);
    }
}
