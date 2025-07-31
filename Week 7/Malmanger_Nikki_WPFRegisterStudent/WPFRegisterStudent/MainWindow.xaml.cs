using System.Windows;

namespace WPFRegisterStudent
{
    public partial class MainWindow : Window
    {
        Course choice;
        int credits;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // assigns choice to the course the user selects
            choice = (Course)(this.comboBox.SelectedItem);

            // if choice has not already been a confirmed course,
            // adds it to the list of confirmed courses
            if (choice.IsRegisteredAlready() == false && credits < 9)
            {
                this.listBox.Items.Add(choice);

                label3.Content = "Registration Confirmed for course " + choice.ToString();

                // adds credits to the total credit hours
                credits += 3;
                this.textBox.Text = "" + credits;

                // makes choice to confirm as already registered course
                choice.SetToRegistered();
            }
            else if (choice.IsRegisteredAlready() == true)
            {
                // choice has already been registered
                label3.Content = "You have registered for this " + choice.ToString() + " course";
            }
            else if (credits == 9)
            {
                label3.Content = "You cannot register for more than 9 credit hours";
            }
        }
    }
}
