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
    /*
    * spot resize Behavior 클래스 : ResizeThumbBehavior
    */
    public class ResizeThumbBehavior : Behavior<Thumb>
    {
       
        /*
         * Behavior가 WPF 요소에 붙을 때 실행되는 생명주기 메서드
         */
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.DragDelta += OnDragDelta;
        }

        /*
         * Behavior가 WPF 요소에 떨어질 때 실행되는 생명주기 메서드
         */
        protected override void OnDetaching()
        {
            base.OnDetaching();
            // 안해주면 메모리 leak 발생 !
            AssociatedObject.DragDelta -= OnDragDelta;
        }

        /*
         * 드래그 동작 처리
         */
        private void OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (AssociatedObject.DataContext is FrameworkElement element)
            {
                // resize 를 위해 드래그 한 만큼 더해준다.
                double newWidth = element.Width + e.HorizontalChange;
                double newHeight = element.Height + e.VerticalChange;

                element.Width = newWidth > 10 ? newWidth : 10;
                element.Height = newHeight > 10 ? newHeight : 10;
            }
        }
    }
}
