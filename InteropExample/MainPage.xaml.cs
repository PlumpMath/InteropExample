using Windows.UI.Xaml.Controls;
using CPPComponent;
using System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace InteropExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CPPClass cppClass;
        DateTimeOffset dateAndTime;

        public MainPage()
        {
            this.InitializeComponent();
            cppClass = new CPPClass();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            randomTextBlock.Text = cppClass.GetRandomNumber().ToString();
            timeTextBlock.Text = ConvertTime(cppClass.GetTime());
        }

        private string ConvertTime(int unixTime)
        {
            dateAndTime = DateTimeOffset.FromUnixTimeSeconds(unixTime);
            return dateAndTime.ToString();
        }
    }
}
