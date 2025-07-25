using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;
using System.Windows.Controls.Primitives;
namespace ShowRoomDisplay.Behaviors
{
    public class ResizeThumbBehavior : Behavior<Thumb>
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
            if (AssociatedObject.DataContext is FrameworkElement element)
            {
                double newWidth = element.Width + e.HorizontalChange;
                double newHeight = element.Height + e.VerticalChange;

                element.Width = newWidth > 10 ? newWidth : 10;
                element.Height = newHeight > 10 ? newHeight : 10;
            }
        }
    }
}
