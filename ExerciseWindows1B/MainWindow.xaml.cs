using Exercise1B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ExerciseWindows1B
{
    // Anelie Decomotan
    // 2017 - 30211
    // March 10, 2019

    public partial class MainWindow : Window
    {
        // Label binding
        public static readonly DependencyProperty labelContentProperty =
            DependencyProperty.Register("labelContent",
            typeof(String), typeof(MainWindow), new FrameworkPropertyMetadata(string.Empty));

        public String labelContent
        {
            get { return GetValue(labelContentProperty).ToString(); }
            set { SetValue(labelContentProperty, value); }
        }

        public static readonly DependencyProperty patientProperty =
            DependencyProperty.Register("patient",
            typeof(String), typeof(MainWindow), new FrameworkPropertyMetadata(string.Empty));

        public String patient
        {
            get { return GetValue(patientProperty).ToString(); }
            set { SetValue(patientProperty, value); }
        }

        public static readonly DependencyProperty concernProperty =
            DependencyProperty.Register("concern",
            typeof(String), typeof(MainWindow), new FrameworkPropertyMetadata(string.Empty));

        public String concern
        {
            get { return GetValue(concernProperty).ToString(); }
            set { SetValue(concernProperty, value); }
        }

        static LinkedList linkedList = new LinkedList();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            labelContent = "CONSULTATION";
        }

        private void InsertPatient_Click(object sender, RoutedEventArgs e)
        {
            insertPatient();
        }

        void insertPatient()
        {
            // Create patient object and assign data to a node
            Patient data = new Patient(patient, concern);
            Node node = new Node(data);

            if (linkedList.Header == null)
            {
                // Set new node as header and tail
                linkedList.Header = node;
                linkedList.Tail = node;
            }
            else
            {
                // Set new node as current tail node's next node
                linkedList.Tail.Next = node;
                // Set current node as tail node
                linkedList.Tail = node;
            }

            labelContent = "Added new patient in queue.";
        }

        private void EnterRoom_Click(object sender, RoutedEventArgs e)
        {
            enterRoom();
        }

        void enterRoom()
        {
            Node header = linkedList.Header;
            if (header != null)
            {
                // Get data of header
                Patient patient = header.Data;
                labelContent = "Current patient " + patient.Name;
            }
            else
            {
                labelContent = "No patient in queue.";
            }
        }

        private void BeginConsultation_Click(object sender, RoutedEventArgs e)
        {
            beginConsultation();
        }

        void beginConsultation()
        {
            Node header = linkedList.Header;
            if (header != null)
            {
                // Get data of header
                Patient patient = header.Data;
                labelContent = "Current patient is " + patient.Name + ".\n Nature of concern " + patient.Concern + ".";
                
                // Set next node of header as the new header
                Node nextNode = header.Next;
                linkedList.Header = null;
                linkedList.Header = nextNode;
            }
            else
            {
                labelContent = "No patient in queue.";
            }
        }

        private void ClosingTime_Click(object sender, RoutedEventArgs e)
        {
            closingTime();
        }

        void closingTime()
        {
            // Remove header and tail
            linkedList.Header = null;
            linkedList.Tail = null;
            labelContent = "Clear patient queue.";
        }

        private void ExitApplication_Click(object sender, RoutedEventArgs e)
        {
            exitApplication();
        }

        static void exitApplication()
        {
            Application.Current.Shutdown();
        }
    }
}
