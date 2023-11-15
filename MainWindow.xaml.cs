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
<<<<<<< HEAD
using System.Windows.Forms;
=======
>>>>>>> origin/main

namespace memo
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void OpenFolderButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            //C:を選んだ状態にする
            folderBrowserDialog.SelectedPath = @"c:";

            folderBrowserDialog.Description = "ファイルを選択してください。";

            //FolderBrowserDialogを表示
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectionResult.Text = folderBrowserDialog.SelectedPath;
            }

        }

        private void SelectFolderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }


=======
    }
>>>>>>> origin/main
}
