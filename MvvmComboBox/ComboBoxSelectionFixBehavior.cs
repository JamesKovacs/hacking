using System.Windows.Controls;
using System.Windows.Interactivity;

namespace JamesKovacs.MvvmComboBox
{
    public class ComboBoxSelectionFixBehavior : Behavior<System.Windows.Controls.ComboBox>
    {
        protected override void OnAttached()
        {
            AssociatedObject.SelectionChanged += ComboBox_SelectionChanged;
        }

        protected override void  OnDetaching()
        {
            AssociatedObject.SelectionChanged -= ComboBox_SelectionChanged;
        }

        void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var binding = AssociatedObject.GetBindingExpression(ComboBox.SelectedItemProperty);
            if (binding != null)
            {
                binding.UpdateTarget();
            }
        }
    }
}
