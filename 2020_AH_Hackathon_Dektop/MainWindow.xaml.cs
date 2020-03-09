using System;
using System.Collections.Generic;
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

namespace _2020_AH_Hackathon_Dektop {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
        List<List<String>> userData = new List<List<String>>();
        List<List<String>> day = new List<List<String>>();
    public MainWindow() {
      InitializeComponent();
    }

    private void BtnGetStarted_OnClick(object sender, RoutedEventArgs e) {
      StartingGrid.Visibility = Visibility.Hidden;
      MoodGrid.Visibility = Visibility.Visible;
    }

    private void BtnMoodSubmit_OnClick(object sender, RoutedEventArgs e) {
      List<String> selectedBad = new List<string>();
      List<String> selectedGood = new List<string>();
      List<String> mood = new List<string>();
      int countBad = 0;
      int countGood = 0;
      foreach(CheckBox cb in SP_Mood_1.Children){
        if (cb.IsChecked == true) {
          selectedGood.Add(cb.Content.ToString());
          countGood++;
        }
      }
      foreach(CheckBox cb in SP_Mood_2.Children){
        if (cb.IsChecked == true) {
          selectedGood.Add(cb.Content.ToString());
          countGood++;
        }
      }
      foreach(CheckBox cb in SP_Mood_3.Children){
        if (cb.IsChecked == true) {
          selectedBad.Add(cb.Content.ToString());
          countBad++;
        }
      }
      foreach(CheckBox cb in SP_Mood_4.Children){
        if (cb.IsChecked == true) {
          selectedBad.Add(cb.Content.ToString());
          countBad++;
        }
      }
      selectedBad.Add(countBad + "");
      selectedGood.Add(countGood+"");
      day.Add(selectedBad);
      day.Add(selectedGood);

      for (int i = 0; i < 7; i++) {
        RadioButton rb = (RadioButton)SP_Mood_RB.Children[i];
        if (rb.IsChecked==true) {
          mood.Add(rb.Content.ToString());
          mood.Add(i+"");
        }
      }

      MoodGrid.Visibility = Visibility.Hidden;
      StressGrid.Visibility = Visibility.Visible;
      Console.Write(day.ToString());
    }

    private void BtnStressSubmit_OnClick(object sender, RoutedEventArgs e) {
      List<String> selectedStressors = new List<string>();

      foreach (CheckBox cb in SP_Stress_2.Children) {
        if (cb.IsChecked == true) {
          selectedStressors.Add(cb.Content.ToString());
        }
      }
      foreach (CheckBox cb in SP_Stress_3.Children) {
        if (cb.IsChecked == true) {
          selectedStressors.Add(cb.Content.ToString());
        }
      }

      foreach (RadioButton rb in SP_Stress_RB.Children) {
        if (rb.IsChecked==true) {
          selectedStressors.Add(rb.Content.ToString());
        }
      }
      Console.Write(day.ToString());
    }
  }
}
