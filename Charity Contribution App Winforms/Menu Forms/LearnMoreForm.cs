using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charity_Contribution_App_Winforms
{
    public partial class LearnMoreForm : Form
    {
        private MainPage mainPage;
        public LearnMoreForm(MainPage mainPage)
        {
            InitializeComponent();
            LoadInformation();
            this.mainPage = mainPage;
        }

        private void LoadInformation()
        {
            string projectOverview = "Project Overview:\n\n" +
                "The Charity Contribution System is a prototype console application designed to facilitate interaction between " +
                "users and various charities and non-profit organizations (NPOs). This system provides users with the ability to " +
                "view and search for charities, make donations, learn more about specific organizations, provide feedback, and " +
                "review their donation history. The application is built using advanced C# programming concepts and is intended " +
                "to serve as a foundation for further development into a more comprehensive software solution.\n\n" +
                "Technical Requirements:\n\n" +
                "1. Enum for Menu Options\n" +
                "   - The application will utilize an enum, MenuOption, to define the main user interface options. This will ensure a " +
                "     structured and intuitive navigation experience.\n" +
                "     MenuOption Values:\n" +
                "     - ViewAllCharities\n" +
                "     - SearchCharities\n" +
                "     - Donate\n" +
                "     - LearnMore\n" +
                "     - GiveFeedback\n" +
                "     - ViewDonationHistory\n" +
                "     - Exit\n\n" +
                "2. Interfaces\n" +
                "   - To promote a modular and extensible design, the system will employ interfaces to define key behaviors and " +
                "     properties.\n" +
                "     ICharity Interface:\n" +
                "     - Defines the core properties and methods for charity entities.\n" +
                "     - Properties:\n" +
                "       - string Name { get; }\n" +
                "       - string Description { get; }\n" +
                "     - Methods:\n" +
                "       - void Donate(decimal amount);\n" +
                "       - void GetDetails();\n" +
                "       - void GiveFeedback(string feedback);\n" +
                "       - List<decimal> DonationHistory { get; }\n\n" +
                "     IDataPersistable Interface:\n" +
                "     - Ensures that data can be saved and loaded consistently.\n" +
                "     - Methods:\n" +
                "       - void SaveData();\n" +
                "       - void LoadData();\n\n" +
                "3. Classes\n" +
                "   - The application will include a variety of classes to encapsulate the logic for managing charities and user " +
                "     interactions.\n" +
                "     Charity Class:\n" +
                "     - An abstract base class implementing the ICharity interface.\n" +
                "     - Properties:\n" +
                "       - string Name { get; protected set; }\n" +
                "       - string Description { get; protected set; }\n" +
                "       - decimal TotalDonations { get; protected set; }\n" +
                "       - List<string> Feedback { get; private set; }\n" +
                "       - List<decimal> DonationHistory { get; private set; }\n" +
                "     - Methods:\n" +
                "       - Implement Donate(decimal amount), GetDetails(), and GiveFeedback(string feedback).\n" +
                "       - Additional methods to display donation history and feedback.\n\n" +
                "     SpecificCharity Class:\n" +
                "     - Inherits from the Charity class and represents individual charity entities with specific attributes and methods.\n\n" +
                "     CharityManager Class:\n" +
                "     - Manages the list of charities, including search functionality, adding new charities, and handling donations.\n" +
                "     - Implements IDataPersistable for data persistence.\n\n" +
                "     User Class:\n" +
                "     - Represents a user of the system with attributes such as Name, Email, and methods for interacting with charities.\n\n" +
                "4. Event Handling\n" +
                "   - The application will implement an event-driven architecture to handle significant user actions such as donations.\n" +
                "     Donation Event:\n" +
                "     - Triggered in the Charity class whenever a donation is made.\n" +
                "     - Includes information such as the donation amount, charity name, and donor’s name.\n" +
                "     Event Handler:\n" +
                "     - Located in the CharityManager class, responsible for logging donations and triggering notifications.\n\n" +
                "5. Threads\n" +
                "   - To enhance performance and user experience, the application will employ multi-threading.\n" +
                "     Donation Processing:\n" +
                "     - Donations will be processed on separate threads, with simulated delays to represent transaction time.\n" +
                "     Asynchronous Data Handling:\n" +
                "     - Loading and saving charity data will occur asynchronously, ensuring the application remains responsive.\n\n" +
                "6. Menu and Navigation\n" +
                "   - User interaction will be driven by a menu system based on the MenuOption enum.\n" +
                "     Main Menu:\n" +
                "     - Users can navigate through options such as viewing all charities, searching charities, making donations, and viewing donation history.\n" +
                "     Sub-Menus:\n" +
                "     - Additional options will be available for specific actions like searching for charities and providing feedback.\n\n" +
                "7. File Handling\n" +
                "   - Persistent data storage will be implemented using file handling mechanisms.\n" +
                "     Data Storage:\n" +
                "     - Charity data, including donation history and user feedback, will be stored in JSON or XML format.\n" +
                "     - Data will be loaded at startup and saved upon application exit.\n\n" +
                "8. LINQ Queries\n" +
                "   - LINQ will be employed to manage and query data efficiently.\n" +
                "     Charity Search:\n" +
                "     - Users can search for charities based on criteria such as name, category, or location.\n" +
                "     Donation and Feedback Sorting:\n" +
                "     - LINQ queries will be used to sort and filter donation history and feedback.\n\n" +
                "9. Logging and Notifications\n" +
                "   - A robust logging system will be implemented to track key actions within the application.\n" +
                "     Donation Logging:\n" +
                "     - All donations will be logged, and users will receive real-time notifications.\n" +
                "     Feedback Notifications:\n" +
                "     - Users will be notified when their feedback has been submitted and when a response is received from a charity.\n\n" +
                "10. Additional Features\n" +
                "   - To enhance the user experience, the application will include several additional features.\n" +
                "     User Registration/Login:\n" +
                "     - Users can register and log in, with their donation history and feedback linked to their account.\n" +
                "     Feedback Management:\n" +
                "     - Charities can respond to feedback, which will be logged and viewable by the user.\n" +
                "     Donation Goals:\n" +
                "     - Charities can set and track donation goals, with progress displayed to users.\n" +
                "     Custom Reports:\n" +
                "     - Users can generate reports on their donation activities, which can be saved or printed.\n\n" +
                "Application Flow:\n\n" +
                "1. Startup:\n" +
                "   - The application loads charity data from a persistent storage file.\n" +
                "   - The main menu is displayed, allowing the user to choose an action.\n" +
                "2. User Interaction:\n" +
                "   - The user navigates through the menu, selecting options to view, search, donate, learn, and provide feedback.\n" +
                "   - All actions are processed in real-time, with relevant data saved as necessary.\n" +
                "3. Donation Process:\n" +
                "   - When a user chooses to donate, the system processes the donation on a separate thread, updating the charity's total donations and logging the event.\n" +
                "4. Data Management:\n" +
                "   - All charity data, including donation history and feedback, is saved to a file upon application exit.\n" +
                "   - Users' actions and system events are logged throughout the application’s lifecycle.\n" +
                "5. Exit:\n" +
                "   - The user selects the exit option from the main menu.\n" +
                "   - The application saves all data and logs, and then safely shuts down.\n\n" +
                "Creators:\n" +
                "- Tshepang\n" +
                "- Darrin\n" +
                "- Charmaine\n" +
                "- Ndinae";

            txtLearnMore.Text = projectOverview;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            mainPage.ShowMainForm();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Logic to close the Learn More form
        }
    }
}
