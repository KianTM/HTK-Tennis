using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TennisHTK.BIZ;
using TennisHTK.Entities;

namespace TennisHTK.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Member> Members { get; set; }
        public List<Classification> Classifications { get; set; } = new List<Classification>();
        private List<Classification> NewMemberClassifications { get; set; } = new List<Classification>();

        public MainWindow()
        {
            InitializeComponent();
            Classifications = Biz.GetAllClassifications();
            Classifications.Add(new Classification { Name = "-- Opret ny --" });
            classificationComboBox.ItemsSource = Classifications;
            editClassificationComboBox.ItemsSource = Classifications;
            newClassificationTextBox.IsEnabled = false;
        }

        private void addMemberButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Member m = new Member
            //    {
            //        Name = nameTextBox.Text,
            //        Address = addressTextBox.Text,
            //        MobileNumber = mobileNumberTextBox.Text,
            //        Email = emailTextBox.Text,
            //        Birthdate = (DateTime)birthdateDatePicker.SelectedDate,
            //        ListClassifications = NewMemberClassifications,
            //        Points = 50
            //    };
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBox.Show("Der skete en fejl under oprettelse. Sørg for at dataen er indtastet korrekt.", "Fejl", MessageBoxButton.OK);
            //    throw;
            //}
            throw new NotImplementedException();
        }

        private void addClassificationButton_Click(object sender, RoutedEventArgs e)
        {
            if (newClassificationTextBox.IsEnabled == true)
            {
                Classification c = new Classification { ID = 1, Name = newClassificationTextBox.Text };
                NewMemberClassifications.Add(c);
                Biz.InsertClassification(newClassificationTextBox.Text);
            }
            else
            {
                NewMemberClassifications.Add(classificationComboBox.SelectedItem as Classification);
            }
        }

        private void classificationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Classification c = (sender as ComboBox).SelectedItem as Classification;
            if (c.Name == "-- Opret ny --")
            {
                if (string.IsNullOrWhiteSpace(newClassificationTextBox.Text))
                    addClassificationButton.IsEnabled = true;
                else
                    addClassificationButton.IsEnabled = false;

                newClassificationTextBox.IsEnabled = true;
            }
            else
                newClassificationTextBox.IsEnabled = false;
        }

        private void editClassificationTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Classification c = (sender as ComboBox).SelectedItem as Classification;
            if (c.Name == "-- Opret ny --")
            {
                if (string.IsNullOrWhiteSpace(editNewClassificationTextBox.Text))
                    editAddClassificationButton.IsEnabled = true;
                else
                    editAddClassificationButton.IsEnabled = false;

                editNewClassificationTextBox.IsEnabled = true;
            }
            else
                editNewClassificationTextBox.IsEnabled = false;
        }

        private void editAddClassificationButton_Click(object sender, RoutedEventArgs e)
        {
            if (editNewClassificationTextBox.IsEnabled == true)
            {
                Classification c = new Classification { ID = 1, Name = editNewClassificationTextBox.Text };
                NewMemberClassifications.Add(c);
                Biz.InsertClassification(editNewClassificationTextBox.Text);
            }
            else
            {
                NewMemberClassifications.Add(classificationComboBox.SelectedItem as Classification);
            }
        }

        private void editMemberButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Member m = new Member
            //    {
            //        Name = editNameTextBox.Text,
            //        Address = editAddressTextBox.Text,
            //        MobileNumber = editMobileNumberTextBox.Text,
            //        Email = editEmailTextBox.Text,
            //        Birthdate = (DateTime)editBirthdateDatePicker.SelectedDate,
            //        Classifications = NewMemberClassifications,
            //        Points = 50
            //    };
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBox.Show("Der skete en fejl under redigering. Sørg for at dataen er indtastet korrekt.", "Fejl", MessageBoxButton.OK);
            //    throw;
            //}
            throw new NotImplementedException();
        }
    }
}
