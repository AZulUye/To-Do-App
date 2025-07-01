using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace To_DoApp;

public partial class MainPage : ContentPage
{ 
  const string TASKS_KEY = "saved_tasks";
  public ObservableCollection<TodoItem>? Tasks { get; set; } = new();
  
  public ICommand DeleteTaskCommand { get; }

  public MainPage()
  {
    InitializeComponent();
    Tasks = LoadTasks();
    DeleteTaskCommand = new Command<TodoItem>(OnDeleteTask);
    BindingContext = this;
  }

  private void OnAddTaskClicked(object sender, EventArgs e)
  {
    var taskText = taskEntry.Text?.Trim();

    if (!string.IsNullOrEmpty(taskText))
    {
      Tasks?.Add(new TodoItem {Title = taskText, IsCompleted = false});
      taskEntry.Text = string.Empty;
      SaveTasks();
    }
  }

  private void OnTaskCheckedChanged(object sender, CheckedChangedEventArgs e)
  {
    SaveTasks();
  }

  void OnDeleteTask(TodoItem item)
  {
    if (Tasks.Contains(item))
      Tasks.Remove(item);

    SaveTasks();
  }

  void SaveTasks()
  {
    var json = JsonSerializer.Serialize(Tasks);
    Preferences.Set(TASKS_KEY, json);
  }

  ObservableCollection<TodoItem>? LoadTasks()
  {
    var json = Preferences.Get(TASKS_KEY, string.Empty);
    return string.IsNullOrWhiteSpace(json)
      ? new ObservableCollection<TodoItem>()
      : JsonSerializer.Deserialize<ObservableCollection<TodoItem>>(json);
  }
}