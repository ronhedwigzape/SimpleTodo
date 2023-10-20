namespace SimpleTodo;

public partial class TodoListPage : ContentPage
{
	public TodoListPage()
	{
        InitializeComponent();
	}

    async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            // Get the selected item from the event arguments
            var selectedItem = e.SelectedItem as Models.TodoItem;

            // Navigate to the TodoItemPage and pass the selected item as the binding context
            await Shell.Current.GoToAsync($"TodoItemPage?ItemId={selectedItem.ID}");
        }
    }

}