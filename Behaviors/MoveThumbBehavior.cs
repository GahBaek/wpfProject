using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.Xaml.Behaviors;

namespace ShowRoomDisplay.Behaviors
{
    /*
    * spot 움직이는 Behavior 클래스 : MoveThumbBehavior
    */
    public class MoveThumbBehavior : Behavior<Thumb>
    {
        /*
         * Behavior가 WPF 요소에 붙을 때 실행되는 생명주기 메서드
         */
        protected override void OnAttached()
        {
            base.OnAttached();
            // DragDelta 이벤트 등록.
            AssociatedObject.DragDelta += OnDragDelta;
        }

        /*
         * Behavior가 WPF 요소에 떨어질 때 실행되는 생명주기 메서드
         */
        protected override void OnDetaching()
        {
            base.OnDetaching();
            // DragDelta 이벤트 삭제. (이벤트 삭제하지 않으면 메모리 누수나 예기치 않은 동작이 발생할 수 있다.)
            AssociatedObject.DragDelta -= OnDragDelta;
        }

        /*
         * 드래그 동작 처리
         */
        private void OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (AssociatedObject.DataContext is FrameworkElement element && element.Parent is Canvas canvas)
            {
                {
                    // 드래그 한 만큼 이동시켜준다.
                    double left = Canvas.GetLeft(element);
                    double top = Canvas.GetTop(element);

                    Canvas.SetLeft(element, left + e.HorizontalChange);
                    Canvas.SetTop(element, top + e.VerticalChange);

                }
            }
        }
    }
}