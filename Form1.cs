using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TitansHashdictionaryReader
{
    public partial class Form1 : Form
    {
        private string route;
        private string routeHash;
        List<string> lines;
        List<string> filesLibrary;
        private int success;
        private int failed;
        private int notFound;
        private int alreadyExists;
        public Form1()
        {
            InitializeComponent();
        }

        private void RouteSearchButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                route = dialog.SelectedPath;
            }
            RouteTextBox.Text = route;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            RouteSearchButton.Enabled = false;
            RouteTextBox.Enabled = false;
            StartButton.Enabled = false;

            route = RouteTextBox.Text;
            if (!route.EndsWith(".txt"))
            {
                routeHash = route + "\\hashdictionary.txt";
            }
            else
            {
                routeHash = route;
                route = Path.GetDirectoryName(routeHash);
            }

            progressBar.Value = 0;
            ConsoleTextBox.Text = string.Empty;
            success = 0;
            SuccessLabel.Text = "SUCCESS: " + success;
            failed = 0;
            FailedLabel.Text = "FAILED: " + failed;
            notFound = 0;
            NotFoundLabel.Text = "NOT FOUND: " + notFound;
            alreadyExists = 0;
            AlreadyExistsLabel.Text = "ALREADY EXISTS: " + alreadyExists;
            TotalLabel.Text = "TOTAL: 0";

            try
            {
                if (radioDefault.Checked || radioDelete.Checked)
                {
                    Tool();
                }
                else if (radioDuplicates.Checked)
                {
                    Tool2();
                }
            }
            catch (Exception ex)
            {
                ConsoleTextBox.AppendText("Something went wrong. Make sure you are selecting the directory with the extracted content and/or a valid hashdictionary.txt before starting.");
                ConsoleTextBox.AppendText(Environment.NewLine);
                ConsoleTextBox.AppendText("Error: " + ex.Message);
                ConsoleTextBox.AppendText(Environment.NewLine);
            }

            RouteSearchButton.Enabled = true;
            RouteTextBox.Enabled = true;
            StartButton.Enabled = true;
        }

        private void Tool()
        {
            lines = File.ReadLines(routeHash).ToList();
            progressBar.Maximum = lines.Count();
            string routeFinal = route + "\\RESULTS";
            Directory.CreateDirectory(routeFinal);
            filesLibrary = Directory.GetFiles(route, "*.*", SearchOption.AllDirectories).ToList();
            ConsoleTextBox.AppendText("Searching in original locations:");
            ConsoleTextBox.AppendText(Environment.NewLine);
            foreach (string line in lines.ToList())
            {
                string[] parts = line.Split(' ');
                string expectedRoute = route + "\\" + Path.GetDirectoryName(parts[0].Length > 259 ? parts[0].Substring(0, 258) : parts[0]);
                string file = null;
                file = filesLibrary.Where(w => Path.GetDirectoryName(w) == expectedRoute && Path.GetFileNameWithoutExtension(w) == parts[1]).FirstOrDefault();

                if (file != null)
                {
                    ProcessFile(routeFinal, line, parts, file);
                    progressBar.Value += 1;
                }
            }
            ConsoleTextBox.AppendText(Environment.NewLine);
            ConsoleTextBox.AppendText("Searching in remaining locations:");
            ConsoleTextBox.AppendText(Environment.NewLine);
            foreach (string line in lines.ToList())
            {
                string[] parts = line.Split(' ');
                string file = filesLibrary.Where(w => Path.GetFileNameWithoutExtension(w) == parts[1]).FirstOrDefault();

                if (file != null)
                {
                    ProcessFile(routeFinal, line, parts, file);
                }
                else
                {
                    ConsoleTextBox.AppendText(line + " - NOT FOUND");
                    ConsoleTextBox.AppendText(Environment.NewLine);
                    notFound++;
                }
                progressBar.Value += 1;
            }
            SuccessLabel.Text = "SUCCESS: " + success;
            FailedLabel.Text = "FAILED: " + failed;
            NotFoundLabel.Text = "NOT FOUND: " + notFound;
            AlreadyExistsLabel.Text = "ALREADY EXISTS: " + alreadyExists;
            TotalLabel.Text = "TOTAL: " + progressBar.Maximum;

            ConsoleTextBox.AppendText(Environment.NewLine);
            ConsoleTextBox.AppendText("--Process finished--");
        }

        public void ProcessFile(string routeFinal, string line, string[] parts, string file)
        {
            try
            {
                string targetPath = routeFinal + "\\" + parts[0];
                if (!Directory.Exists(Path.GetDirectoryName(targetPath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                if (!File.Exists(targetPath))
                {
                    File.Copy(file, targetPath, false);

                    filesLibrary.Remove(file);
                    lines.Remove(line);

                    if (radioDelete.Checked)
                        File.Delete(file);

                    if (radioDefault.Checked)
                    {
                        ConsoleTextBox.AppendText(line + " - SUCCESS");
                    }
                    else if (radioDelete.Checked)
                    {
                        ConsoleTextBox.AppendText(line + " - SUCCESS (ORIGINAL DELETED)");
                    }
                    ConsoleTextBox.AppendText(Environment.NewLine);
                    success++;
                }
                else
                {
                    ConsoleTextBox.AppendText(line + " - ALREADY EXISTS");
                    ConsoleTextBox.AppendText(Environment.NewLine);
                    alreadyExists++;
                }
            }
            catch (DirectoryNotFoundException)
            {
                ConsoleTextBox.AppendText(line + " - FAILED (DESTINATION NAME TOO LONG)");
                ConsoleTextBox.AppendText(Environment.NewLine);
                failed++;
            }
            catch (Exception ex)
            {
                Type exception = ex.GetType();
                ConsoleTextBox.AppendText(line + " - FAILED (UNKNOWN ERROR: " + ex + ")");
                ConsoleTextBox.AppendText(Environment.NewLine);
                failed++;
            }
        }

        public void Tool2()
        {
            List<string> result = CheckRepeatedSecondValue(routeHash);

            ConsoleTextBox.AppendText("Duplicate hashcodes:");
            ConsoleTextBox.AppendText(Environment.NewLine);
            foreach (var line in result)
            {
                ConsoleTextBox.AppendText(line);
                ConsoleTextBox.AppendText(Environment.NewLine);
            }
            TotalLabel.Text = "TOTAL: " + result.Count();
            ConsoleTextBox.AppendText(Environment.NewLine);
            ConsoleTextBox.AppendText("--Process finished--");
        }

        public List<string> CheckRepeatedSecondValue(string filePath)
        {
            List<string> linesWithRepeat = new List<string>();
            Dictionary<string, int> secondValueOccurrences = new Dictionary<string, int>();

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    string[] parts = line.Split(' ');

                    // Verificar si hay al menos dos palabras en la línea
                    if (parts.Length > 1)
                    {
                        string secondValue = parts[1];

                        // Contamos cuántas veces se ha repetido el segundo valor
                        if (secondValueOccurrences.ContainsKey(secondValue))
                        {
                            secondValueOccurrences[secondValue]++;
                            // Si se repite más de una vez, lo agregamos a la lista
                            if (secondValueOccurrences[secondValue] == 2)
                            {
                                linesWithRepeat.Add(line); // Solo agregamos la primera vez que se repite
                            }
                        }
                        else
                        {
                            secondValueOccurrences[secondValue] = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }

            return linesWithRepeat;
        }

        private void RouteTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void RouteTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                RouteTextBox.Lines = fileNames;
            }
        }
    }
}
