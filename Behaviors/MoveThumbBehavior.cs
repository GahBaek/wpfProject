using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.Xaml.Behaviors;

namespace ShowRoomDisplay.Behaviors
{
    public class MoveThumbBehavior : Behavior<Thumb>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.DragDelta += OnDragDelta;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.DragDelta -= OnDragDelta;
        }

        private void OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            if(AssociatedObject.DataContext  is FrameworkElement element && element.Parent is Canvas canvas){
                {
                    double left = Canvas.GetLeft(element);
                    double top = Canvas.GetTop(element);

                    Canvas.SetLeft(element, left + e.HorizontalChange);
                    Canvas.SetTop(element, top + e.VerticalChange);

        }
    }
}
