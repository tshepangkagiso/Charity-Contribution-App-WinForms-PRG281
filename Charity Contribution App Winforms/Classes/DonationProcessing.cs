using Charity_Contribution_App_Winforms.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charity_Contribution_App_Winforms.Classes
{
    public class DonationProcessing : IDataPersistable
    {
        private string _charityName { get; set; }
        private string _userName { get; set; }
        private decimal _donatedFunds { get; set; }
        private DateTime _dateOfDonation { get; set; }

        public DonationProcessing(string charityName, string userName, decimal donatedFunds, DateTime dateOfDonation)
        {
            CharityName = charityName;
            Username = userName;
            DonatedFunds = donatedFunds;
            DateOfDonation = dateOfDonation;
        }

        public DonationProcessing() : this(string.Empty, string.Empty, 0, DateTime.Now)
        {
        }

        public string CharityName
        {
            get { return _charityName; }
            set { _charityName = value; }
        }

        public string Username
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public decimal DonatedFunds
        {
            get { return _donatedFunds; }
            set { _donatedFunds = value; }
        }

        public DateTime DateOfDonation
        {
            get { return _dateOfDonation; }
            set { _dateOfDonation = value; }
        }

        public static List<DonationProcessing> ListOfDonations = new List<DonationProcessing>()
        {
            new DonationProcessing("UNICEF", "Ndinae", 0, DateTime.Now)
        };

        public static void Donation(string charityName, decimal amount, User _user)
        {
            User user = _user;
            SpecificCharity charity = CharityManager.ListOfCharities.Find(x => x.Name.Trim().ToLower() == charityName.Trim().ToLower());
            if (charity == null)
            {
                MessageBox.Show("Results failed");
            }
            else
            {
                if(user.Wallet > amount)
                {
                    user.Wallet -= amount;
                    charity.TotalDonations += amount;
                    DonationProcessing processing = new DonationProcessing(charityName, user.Username, amount, DateTime.Now);
                    ListOfDonations.Add(processing);
                    SaveDonationData();
                    LoadDonationData();
                    User.SaveUserData();
                    User.LoadUserData();
                    CharityManager.SaveCharityData();
                    CharityManager.LoadCharityData();

                    MessageBox.Show("Successful Donation");
                }
                else
                {
                    MessageBox.Show("Not enough money");
                }

            }
        }

        private const string ProjectName = "Charity Contribution App Winforms";
        private const string LocalStorageFolder = "LocalStorage";
        private const string FileName = "donationsHistory.json";

        public void SaveData()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string projectPath = Path.Combine(desktopPath, "Charity Contribution App", ProjectName);
                string fullPath = Path.Combine(projectPath, LocalStorageFolder, FileName);
                //MessageBox.Show(fullPath);

                string directoryPath = Path.GetDirectoryName(fullPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonString = JsonSerializer.Serialize(ListOfDonations, options);
                File.WriteAllText(fullPath, jsonString);
                Console.WriteLine("Successfully saved data to donationsHistory.json");
                //MessageBox.Show("Successfully saved database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string projectPath = Path.Combine(desktopPath, "Charity Contribution App", ProjectName);
                string fullPath = Path.Combine(projectPath, LocalStorageFolder, FileName);
                //MessageBox.Show(fullPath);

                if (File.Exists(fullPath))
                {
                    string jsonString = File.ReadAllText(fullPath);
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    ListOfDonations = JsonSerializer.Deserialize<List<DonationProcessing>>(jsonString, options);
                    Console.WriteLine("Successfully loaded data from donationsHistory.json");
                    //MessageBox.Show("Successfully loaded data from donationsHistory.json");
                }
                else
                {
                    SaveDonationData(); // Initialize with default data and save if the file doesn't exist
                    Console.WriteLine("Initialized saved data locally and then loaded data from donationsHistory.json");
                    //MessageBox.Show("Initialized saved data locally and then loaded data from donationsHistory.json");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }
        }

        public delegate void Data();

        public static void SaveDonationData()
        {
            Thread thread = new Thread(() =>
            {
                DonationProcessing donationProcessing = new DonationProcessing();
                Data SaveData = donationProcessing.SaveData;
                lock (ListOfDonations)
                {
                    SaveData.Invoke();
                }
            });

            thread.Start();
            thread.Join();
        }

        public static void LoadDonationData()
        {
            Thread thread = new Thread(() =>
            {
                DonationProcessing donationProcessing = new DonationProcessing();
                Data LoadData = donationProcessing.LoadData;
                lock (ListOfDonations)
                {
                    LoadData.Invoke();
                }
            });
            thread.Start();
            thread.Join();
        }
    }
}
