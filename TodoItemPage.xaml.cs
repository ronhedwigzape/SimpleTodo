namespace SimpleTodo;

public partial class TodoItemPage : ContentPage
{
    Models.TodoItemDatabase database;
    public Models.TodoItem Item { get; set; }

    public TodoItemPage(Models.TodoItemDatabase todoItemDatabase)
    {
        InitializeComponent();
        database = todoItemDatabase;

        Item = new Models.TodoItem();

        this.BindingContext = Item;
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        Item = (Models.TodoItem)this.BindingContext;
        await database.SaveItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    async void OnDeleteClicked(object sender, EventArgs e)
    {
        Item = (Models.TodoItem)this.BindingContext;
        await database.DeleteItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }


    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }


}