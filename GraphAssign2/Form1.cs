namespace GraphAssign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method to draw the pie chart
        private void DrawPieChart(List<float> values)
        {
            // Define chart area and colors for each slice
            Rectangle chartArea = new Rectangle(50, 50, 200, 200);
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple, Color.Orange };

            // Calculate the total sum of values
            float total = values.Sum();
            float startAngle = 0f;

            // Initialize Graphics for drawing
            using (Graphics g = pieChartPanel.CreateGraphics()) // Ensure pieChartPanel exists on Form1
            {
                g.Clear(Color.White); // Clear previous drawings

                for (int i = 0; i < values.Count; i++)
                {
                    // Calculate the angle for each slice
                    float sweepAngle = (values[i] / total) * 360f;
                    g.FillPie(new SolidBrush(colors[i % colors.Length]), chartArea, startAngle, sweepAngle);

                    // Update starting angle for next slice
                    startAngle += sweepAngle;
                }
            }
        }

        // Method to display legend for the pie chart
        private void DisplayLegend(List<float> values)
        {
            legendListView.Items.Clear(); // Ensure legendListView exists on Form1
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Purple, Color.Orange };

            for (int i = 0; i < values.Count; i++)
            {
                // Create a ListViewItem and set its properties
                string legendText = $"Slice {i + 1}: {values[i]}";
                ListViewItem item = new ListViewItem(legendText)
                {
                    BackColor = colors[i % colors.Length] // Set background color
                };
                legendListView.Items.Add(item);
            }
        }


        // Button click event to draw pie chart based on user input
        private void btnDrawChart_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input values from a TextBox (assumed to be txtInput on Form1)
                List<float> values = txtInput.Text.Split(',')
                                    .Select(value => float.Parse(value.Trim()))
                                    .ToList();

                // Ensure there's data to plot
                if (values.Count == 0)
                {
                    MessageBox.Show("Please enter some numbers separated by commas.");
                    return;
                }

                // Draw chart and legend
                DrawPieChart(values);
                DisplayLegend(values);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter numbers separated by commas.");
            }
        }
    }
}
