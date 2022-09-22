namespace MauiToDoList.Pages;

public partial class RequestPage : ContentPage
{
	public RequestPage()
	{
		InitializeComponent();
        Editor editor = new Editor();
        editor.TextChanged += OnEditorTextChanged;
        editor.Completed += OnEditorCompleted;
    }
    void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = editor.Text;
    }
    void OnEditorCompleted(object sender, EventArgs e)
    {
        string text = ((Editor)sender).Text;
    }
    private async void Btn_clicked_Email(object sender, EventArgs e)
    {
        var message = new EmailMessage("", editor.Text, EntryEmail.Text);
        await Email.Default.ComposeAsync(message);
    }
    private async void Btn_clicked_Phonenumber(object sender, EventArgs e)
    {
        var message = new SmsMessage(editor.Text, EntryPhoneNumber.Text);
        await Sms.Default.ComposeAsync(message);
    }
}