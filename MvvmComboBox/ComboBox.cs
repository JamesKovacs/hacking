using System.Windows.Controls;

namespace JamesKovacs.MvvmComboBox {
    public class ComboBox : System.Windows.Controls.ComboBox {
        protected override void OnSelectionChanged(SelectionChangedEventArgs e) {
            base.OnSelectionChanged(e);
            var binding = GetBindingExpression(SelectedItemProperty);
            if(binding != null) {
                binding.UpdateTarget();
            }
        }
    }
}