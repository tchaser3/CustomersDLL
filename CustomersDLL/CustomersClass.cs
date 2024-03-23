/* Title:           Customers Class
 * Date:            7-26-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace CustomersDLL
{
    public class CustomersClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        CustomerAddressesDataSet aCustomerAddressesDataSet;
        CustomerAddressesDataSetTableAdapters.customeraddressesTableAdapter aCustomerAddressesTableAdapter;

        FindAddressByAddressesDataSet aFindAddressByAddressesDataSet;
        FindAddressByAddressesDataSetTableAdapters.FindAddressesByAddressTableAdapter aFindAddressByAddressesTableAdapter;

        FindAddressByZoneIDDataSet aFindAddressByZoneIDDataSet;
        FindAddressByZoneIDDataSetTableAdapters.FindAddressesByZoneIDTableAdapter aFindAddressByZoneIDTableAdapter;

        FindAddressByWorkZoneDataSet aFindAddressByWorkZoneDataSet;
        FindAddressByWorkZoneDataSetTableAdapters.FindAddressByWorkZoneTableAdapter aFindAddressByWorkZoneTableAdapter;

        InsertCustomerAddressEntryTableAdapters.QueriesTableAdapter aInsertCustomerAddressEntryTableAdapter;

        UpdateCustomerAddressEntryTableAdapters.QueriesTableAdapter aUpdateCustomerAddressEntryTableAdapter;

        WorkZoneDataSet aWorkZoneDataSet;
        WorkZoneDataSetTableAdapters.workzoneTableAdapter aWorkZoneTableAdapter;

        FindWorkZoneByZoneIDDataSet aFindWorkZoneByZoneIDDataSet;
        FindWorkZoneByZoneIDDataSetTableAdapters.FindWorkZoneByZoneIDTableAdapter aFindWorkZoneByZoneIDTableAdapter;

        FindWorkZoneByZoneNameDataSet aFindWorkZoneByZoneNameDataSet;
        FindWorkZoneByZoneNameDataSetTableAdapters.FindWorkZoneByZoneNameTableAdapter aFindWorkZoneByZoneNameTableAdapter;

        FindWorkZonesDataSet aFindWorkZonesDataSet;
        FindWorkZonesDataSetTableAdapters.FindWorkZonesTableAdapter aFindWorkZonesTableAdapter;

        CustomersDataSet aCustomersDataSet;
        CustomersDataSetTableAdapters.customersTableAdapter aCustomersTableAdapter;

        InsertWorkZoneEntryTableAdapters.QueriesTableAdapter aInsertWorkZoneTableAdapter;

        InsertCustomerEntryTableAdapters.QueriesTableAdapter aInsertCustomerTableAdapter;

        UpdateCustomerEntryTableAdapters.QueriesTableAdapter aUpdateCustomerTableAdapter;

        FindCustomerByAccountNumberDataSet aFindCustomerByAccountNumberDataSet;
        FindCustomerByAccountNumberDataSetTableAdapters.FindCustomerByAccountNumberTableAdapter aFindCustomerbyAccountNumberTableAdapter;

        FindCustomerByCustomerIDDataSet aFindCustomerByCustomerIDDataSet;
        FindCustomerByCustomerIDDataSetTableAdapters.FindCustomerByCustomerIDTableAdapter aFindCustomerByCustomerIDTableAdapter;

        FindCustomerByPhoneNumberDataSet aFindCustomerByPhoneNumberDataSet;
        FindCustomerByPhoneNumberDataSetTableAdapters.FindCustomerByPhoneNumberTableAdapter aFindCustomerByPhoneNumberTableAdapter;

        FindCustomersByAddressIDDataSet aFindCustomersByAddressIDDataSet;
        FindCustomersByAddressIDDataSetTableAdapters.FindCustomersByAddressIDTableAdapter aFindCustomersByAddressIDTableAdapter;

        FindCustomersSortedByAccountNumberDataSet aFindCustomersSortedByAccountNumberDataSet;
        FindCustomersSortedByAccountNumberDataSetTableAdapters.FindCustomersSortedByAccountNumberTableAdapter aFindCustomersSortedByAccountNumberTableAdapter;

        WorkZoneCityDataSet aWorkZoneCityDataSet;
        WorkZoneCityDataSetTableAdapters.workzonecityTableAdapter aWorkZoneCityTableAdapter;

        InsertWorkZoneCityEntryTableAdapters.QueriesTableAdapter aInsertWorkZoneCityTableAdapter;

        FindWorkZoneCitiesByZoneIDDataSet aFindWorkZoneCitiesByZoneIDDataSet;
        FindWorkZoneCitiesByZoneIDDataSetTableAdapters.FindWorkZoneCitiesByZoneIDTableAdapter aFindWorkZoneCitiesByZoneIDTableAdapter;

        FindWorkZoneCityByCityDataSet aFindWorkZoneCityByCityDataSet;
        FindWorkZoneCityByCityDataSetTableAdapters.FindWorkZoneCityByCityTableAdapter aFindWorkZoneCityByCityTableAdapter;

        FindWorkZoneCityByZipCodeDataSet aFindWorkZoneCityByZipCodeDataSet;
        FindWorkZoneCityByZipCodeDataSetTableAdapters.FindWorkZoneCityByZipCodeTableAdapter aFindWorkZoneCityByZipCodeTableAdapter;

        UpdateWorkZoneCityZoneIDEntryTableAdapters.QueriesTableAdapter aUpdateWorkZoneCityZoneIDTableAdapter;

        FindCustomerAddressDateMatchDataSet aFindCustomerAddressDateMatchDataSet;
        FindCustomerAddressDateMatchDataSetTableAdapters.FindCustomerAddressesDateMatchTableAdapter aFindCustomerAddressDateMatchTableAdapter;

        FindAddressByAddressIDDataSet aFindAddressByAddressIDDataSet;
        FindAddressByAddressIDDataSetTableAdapters.FindAddressByAddressIDTableAdapter aFindAddressByAddressIDTableAdapter;

        FindActiveCustomerByAccountNumberDataSet aFindActiveCustomerByAccountNumberDataSet;
        FindActiveCustomerByAccountNumberDataSetTableAdapters.FindActiveCustomerByAccountNumberTableAdapter aFindActiveCustomerByAccountNumberTableAdapter;

        public FindActiveCustomerByAccountNumberDataSet FindActiveCustomerByAccountNumber(string strAccountNumber)
        {
            try
            {
                aFindActiveCustomerByAccountNumberDataSet = new FindActiveCustomerByAccountNumberDataSet();
                aFindActiveCustomerByAccountNumberTableAdapter = new FindActiveCustomerByAccountNumberDataSetTableAdapters.FindActiveCustomerByAccountNumberTableAdapter();
                aFindActiveCustomerByAccountNumberTableAdapter.Fill(aFindActiveCustomerByAccountNumberDataSet.FindActiveCustomerByAccountNumber, strAccountNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Active Customer By Account Number " + Ex.Message);
            }

            return aFindActiveCustomerByAccountNumberDataSet;
        }
        public FindAddressByAddressIDDataSet FindAddressByAddressID(int intAddressID)
        {
            try
            {
                aFindAddressByAddressIDDataSet = new FindAddressByAddressIDDataSet();
                aFindAddressByAddressIDTableAdapter = new FindAddressByAddressIDDataSetTableAdapters.FindAddressByAddressIDTableAdapter();
                aFindAddressByAddressIDTableAdapter.Fill(aFindAddressByAddressIDDataSet.FindAddressByAddressID, intAddressID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Address By Address ID " + Ex.Message);
            }

            return aFindAddressByAddressIDDataSet;
        }
        public FindCustomerAddressDateMatchDataSet FindCustomerAddressDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindCustomerAddressDateMatchDataSet = new FindCustomerAddressDateMatchDataSet();
                aFindCustomerAddressDateMatchTableAdapter = new FindCustomerAddressDateMatchDataSetTableAdapters.FindCustomerAddressesDateMatchTableAdapter();
                aFindCustomerAddressDateMatchTableAdapter.Fill(aFindCustomerAddressDateMatchDataSet.FindCustomerAddressesDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Customer Address Date Match " + Ex.Message);
            }

            return aFindCustomerAddressDateMatchDataSet;
        }
        public bool UpdateWorkZoneCityZoneID(int intTransactionID, int intZoneID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWorkZoneCityZoneIDTableAdapter = new UpdateWorkZoneCityZoneIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateWorkZoneCityZoneIDTableAdapter.UpdateWorkZoneCityZoneID(intTransactionID, intZoneID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Update Work Zone City Zone ID " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindWorkZoneCityByZipCodeDataSet FindWorkZoneCityByZipCode(string strZipCode)
        {
            try
            {
                aFindWorkZoneCityByZipCodeDataSet = new FindWorkZoneCityByZipCodeDataSet();
                aFindWorkZoneCityByZipCodeTableAdapter = new FindWorkZoneCityByZipCodeDataSetTableAdapters.FindWorkZoneCityByZipCodeTableAdapter();
                aFindWorkZoneCityByZipCodeTableAdapter.Fill(aFindWorkZoneCityByZipCodeDataSet.FindWorkZoneCityByZipCode, strZipCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Work Zone City By Zip Code " + Ex.Message);
            }

            return aFindWorkZoneCityByZipCodeDataSet;
        }
        public FindWorkZoneCityByCityDataSet FindWorkZoneCityByCity(string strCity)
        {
            try
            {
                aFindWorkZoneCityByCityDataSet = new FindWorkZoneCityByCityDataSet();
                aFindWorkZoneCityByCityTableAdapter = new FindWorkZoneCityByCityDataSetTableAdapters.FindWorkZoneCityByCityTableAdapter();
                aFindWorkZoneCityByCityTableAdapter.Fill(aFindWorkZoneCityByCityDataSet.FindWorkZoneCityByCity, strCity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Work Zone City By City " + Ex.Message);
            }

            return aFindWorkZoneCityByCityDataSet;
        }
        public FindWorkZoneCitiesByZoneIDDataSet FindWorkZoneCitiesByZoneID(int intZoneID)
        {
            try
            {
                aFindWorkZoneCitiesByZoneIDDataSet = new FindWorkZoneCitiesByZoneIDDataSet();
                aFindWorkZoneCitiesByZoneIDTableAdapter = new FindWorkZoneCitiesByZoneIDDataSetTableAdapters.FindWorkZoneCitiesByZoneIDTableAdapter();
                aFindWorkZoneCitiesByZoneIDTableAdapter.Fill(aFindWorkZoneCitiesByZoneIDDataSet.FindWorkZoneCitiesByZoneID, intZoneID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Work Zone Cities By Zone ID " + Ex.Message);
            }

            return aFindWorkZoneCitiesByZoneIDDataSet;
        }
        public bool InsertWorkZoneCity(int intZoneID, string strCity, string strZipCode, string strCounty)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkZoneCityTableAdapter = new InsertWorkZoneCityEntryTableAdapters.QueriesTableAdapter();
                aInsertWorkZoneCityTableAdapter.InsertWorkZoneCity(intZoneID, strCity, strZipCode, strCounty);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Insert Work Zone City " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WorkZoneCityDataSet GetWorkZoneCityInfo()
        {
            try
            {
                aWorkZoneCityDataSet = new WorkZoneCityDataSet();
                aWorkZoneCityTableAdapter = new WorkZoneCityDataSetTableAdapters.workzonecityTableAdapter();
                aWorkZoneCityTableAdapter.Fill(aWorkZoneCityDataSet.workzonecity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Get Work Zone City " + Ex.Message);
            }

            return aWorkZoneCityDataSet;
        }
        public void UpdateWorkZoneCityDB(WorkZoneCityDataSet aWorkZoneCityDataSet)
        {
            try
            {
                aWorkZoneCityTableAdapter = new WorkZoneCityDataSetTableAdapters.workzonecityTableAdapter();
                aWorkZoneCityTableAdapter.Fill(aWorkZoneCityDataSet.workzonecity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Update Work Zone City " + Ex.Message);
            }
        }
        public FindCustomersSortedByAccountNumberDataSet FindCustomersSortedByAccountNumber()
        {
            try
            {
                aFindCustomersSortedByAccountNumberDataSet = new FindCustomersSortedByAccountNumberDataSet();
                aFindCustomersSortedByAccountNumberTableAdapter = new FindCustomersSortedByAccountNumberDataSetTableAdapters.FindCustomersSortedByAccountNumberTableAdapter();
                aFindCustomersSortedByAccountNumberTableAdapter.Fill(aFindCustomersSortedByAccountNumberDataSet.FindCustomersSortedByAccountNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Customers Sorted By Account Number " + Ex.Message);
            }

            return aFindCustomersSortedByAccountNumberDataSet;
        }
        public FindCustomersByAddressIDDataSet FindCustomersByAddressID(int intAddressID)
        {
            try
            {
                aFindCustomersByAddressIDDataSet = new FindCustomersByAddressIDDataSet();
                aFindCustomersByAddressIDTableAdapter = new FindCustomersByAddressIDDataSetTableAdapters.FindCustomersByAddressIDTableAdapter();
                aFindCustomersByAddressIDTableAdapter.Fill(aFindCustomersByAddressIDDataSet.FindCustomersByAddressID, intAddressID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Customers By Address ID " + Ex.Message);
            }

            return aFindCustomersByAddressIDDataSet;
        }
        public FindCustomerByPhoneNumberDataSet FindCustomerByPhoneNumber(string strPhoneNumber)
        {
            try
            {
                aFindCustomerByPhoneNumberDataSet = new FindCustomerByPhoneNumberDataSet();
                aFindCustomerByPhoneNumberTableAdapter = new FindCustomerByPhoneNumberDataSetTableAdapters.FindCustomerByPhoneNumberTableAdapter();
                aFindCustomerByPhoneNumberTableAdapter.Fill(aFindCustomerByPhoneNumberDataSet.FindCustomerByPhoneNumber, strPhoneNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Customer By Phone Number " + Ex.Message);
            }

            return aFindCustomerByPhoneNumberDataSet;
        }
        public FindCustomerByCustomerIDDataSet FindCustomerByCustomerID(int intCustomerID)
        {
            try
            {
                aFindCustomerByCustomerIDDataSet = new FindCustomerByCustomerIDDataSet();
                aFindCustomerByCustomerIDTableAdapter = new FindCustomerByCustomerIDDataSetTableAdapters.FindCustomerByCustomerIDTableAdapter();
                aFindCustomerByCustomerIDTableAdapter.Fill(aFindCustomerByCustomerIDDataSet.FindCustomerByCustomerID, intCustomerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customer Class // Find Customer By Customer ID " + Ex.Message);
            }

            return aFindCustomerByCustomerIDDataSet;
        }
        public FindCustomerByAccountNumberDataSet FindCustomerByAccountNumber(string strAccountNumber)
        {
            try
            {
                aFindCustomerByAccountNumberDataSet = new FindCustomerByAccountNumberDataSet();
                aFindCustomerbyAccountNumberTableAdapter = new FindCustomerByAccountNumberDataSetTableAdapters.FindCustomerByAccountNumberTableAdapter();
                aFindCustomerbyAccountNumberTableAdapter.Fill(aFindCustomerByAccountNumberDataSet.FindCustomerByAccountNumber, strAccountNumber);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Customer By Account Number " + ex.Message);
            }

            return aFindCustomerByAccountNumberDataSet;
        }
        public bool InsertCustomer(int intAddressID, string strPhoneNumber, string strAccountNumber, string strFirstName, string strLastName)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCustomerTableAdapter = new InsertCustomerEntryTableAdapters.QueriesTableAdapter();
                aInsertCustomerTableAdapter.InsertCustomer(intAddressID, strPhoneNumber, strAccountNumber, strFirstName, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Update Customer " + Ex.Message);

                blnFatalError = false;
            }

            return blnFatalError;
        }
        public bool UpdateCustomer(int intCustomerID, int intAddressID, string strFirstName, string strLastName, string strPhoneNumber, string strAccountNumber, bool blnActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCustomerTableAdapter = new UpdateCustomerEntryTableAdapters.QueriesTableAdapter();
                aUpdateCustomerTableAdapter.UpdateCustomer(intCustomerID, intAddressID, strFirstName, strLastName, strPhoneNumber, strAccountNumber, blnActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Update Customer " + Ex.Message);

                blnFatalError = false;
            }

            return blnFatalError;
        }
        public bool InsertWorkZone(string strZone)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkZoneTableAdapter = new InsertWorkZoneEntryTableAdapters.QueriesTableAdapter();
                aInsertWorkZoneTableAdapter.InsertWorkZone(strZone);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customer Class // Insert Work Zone " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CustomersDataSet GetCustomersInfo()
        {
            try
            {
                aCustomersDataSet = new CustomersDataSet();
                aCustomersTableAdapter = new CustomersDataSetTableAdapters.customersTableAdapter();
                aCustomersTableAdapter.Fill(aCustomersDataSet.customers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Get Customers Info " + Ex.Message);
            }

            return aCustomersDataSet;
        }
        public void UpdateCustomersDB(CustomersDataSet aCustomersDataSet)
        {
            try
            {
                aCustomersTableAdapter = new CustomersDataSetTableAdapters.customersTableAdapter();
                aCustomersTableAdapter.Update(aCustomersDataSet.customers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Get Customers Info " + Ex.Message);
            }
        }
        public FindWorkZonesDataSet FindWorkZones()
        {
            try
            {
                aFindWorkZonesDataSet = new FindWorkZonesDataSet();
                aFindWorkZonesTableAdapter = new FindWorkZonesDataSetTableAdapters.FindWorkZonesTableAdapter();
                aFindWorkZonesTableAdapter.Fill(aFindWorkZonesDataSet.FindWorkZones);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Work Zones " + Ex.Message);
            }

            return aFindWorkZonesDataSet;
        }
        public FindWorkZoneByZoneNameDataSet FindWorkZoneByZoneName(string strZone)
        {
            try
            {
                aFindWorkZoneByZoneNameDataSet = new FindWorkZoneByZoneNameDataSet();
                aFindWorkZoneByZoneNameTableAdapter = new FindWorkZoneByZoneNameDataSetTableAdapters.FindWorkZoneByZoneNameTableAdapter();
                aFindWorkZoneByZoneNameTableAdapter.Fill(aFindWorkZoneByZoneNameDataSet.FindWorkZoneByZoneName, strZone);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Find Work Zone By Zone Name " + Ex.Message);
            }

            return aFindWorkZoneByZoneNameDataSet;
        }
        public FindWorkZoneByZoneIDDataSet FindWorkZoneByZoneID(int intZoneID)
        {
            try
            {
                aFindWorkZoneByZoneIDDataSet = new FindWorkZoneByZoneIDDataSet();
                aFindWorkZoneByZoneIDTableAdapter = new FindWorkZoneByZoneIDDataSetTableAdapters.FindWorkZoneByZoneIDTableAdapter();
                aFindWorkZoneByZoneIDTableAdapter.Fill(aFindWorkZoneByZoneIDDataSet.FindWorkZoneByZoneID, intZoneID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customer Class // Find Work Zone By Zone ID " + Ex.Message);
            }

            return aFindWorkZoneByZoneIDDataSet;
        }
        public WorkZoneDataSet GetWorkZoneInfo()
        {
            try
            {
                aWorkZoneDataSet = new WorkZoneDataSet();
                aWorkZoneTableAdapter = new WorkZoneDataSetTableAdapters.workzoneTableAdapter();
                aWorkZoneTableAdapter.Fill(aWorkZoneDataSet.workzone);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Get Work Zone Info " + Ex.Message);
            }

            return aWorkZoneDataSet;
        }
        public void UpdateWorkZoneDB(WorkZoneDataSet aWorkZoneDataSet)
        {
            try
            {
                aWorkZoneTableAdapter = new WorkZoneDataSetTableAdapters.workzoneTableAdapter();
                aWorkZoneTableAdapter.Update(aWorkZoneDataSet.workzone);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Updatae Work Zone DB " + Ex.Message);
            }
        }
        public bool UpdateCustomerAddress(int intAddressID, string strAddress, string strCity, string strState, int intZoneID, string strZipCode)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCustomerAddressEntryTableAdapter = new UpdateCustomerAddressEntryTableAdapters.QueriesTableAdapter();
                aUpdateCustomerAddressEntryTableAdapter.UpdateCustomerAddress(intAddressID, strAddress, strCity, strState, intZoneID, strZipCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Update Customer Address " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertCustomerAddress(string strAddress, string strCity, string strState, int intZoneID, string strZipCode, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCustomerAddressEntryTableAdapter = new InsertCustomerAddressEntryTableAdapters.QueriesTableAdapter();
                aInsertCustomerAddressEntryTableAdapter.InsertCustomerAddress(strAddress, strCity, strState, intZoneID, strZipCode, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Insert Customer Address " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindAddressByWorkZoneDataSet FindAddressbyWorkZone(string strWorkZone)
        {
            try
            {
                aFindAddressByWorkZoneDataSet = new FindAddressByWorkZoneDataSet();
                aFindAddressByWorkZoneTableAdapter = new FindAddressByWorkZoneDataSetTableAdapters.FindAddressByWorkZoneTableAdapter();
                aFindAddressByWorkZoneTableAdapter.Fill(aFindAddressByWorkZoneDataSet.FindAddressByWorkZone, strWorkZone);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customer Class // Find Address By Work Zone " + Ex.Message);
            }

            return aFindAddressByWorkZoneDataSet;
        }
        public FindAddressByZoneIDDataSet FindAddressByZoneID(int intZoneID)
        {
            try
            {
                aFindAddressByZoneIDDataSet = new FindAddressByZoneIDDataSet();
                aFindAddressByZoneIDTableAdapter = new FindAddressByZoneIDDataSetTableAdapters.FindAddressesByZoneIDTableAdapter();
                aFindAddressByZoneIDTableAdapter.Fill(aFindAddressByZoneIDDataSet.FindAddressesByZoneID, intZoneID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customer Class // Find Address By Zone ID " + Ex.Message);
            }

            return aFindAddressByZoneIDDataSet;
        }
        public FindAddressByAddressesDataSet FindAddressesByAddress(string strStreetAddress)
        {
            try
            {
                aFindAddressByAddressesDataSet = new FindAddressByAddressesDataSet();
                aFindAddressByAddressesTableAdapter = new FindAddressByAddressesDataSetTableAdapters.FindAddressesByAddressTableAdapter();
                aFindAddressByAddressesTableAdapter.Fill(aFindAddressByAddressesDataSet.FindAddressesByAddress, strStreetAddress);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customer Class // Find Address By Address " + Ex.Message);
            }

            return aFindAddressByAddressesDataSet;
        }
        public CustomerAddressesDataSet GetCustomerAddressesInfo()
        {
            try
            {
                aCustomerAddressesDataSet = new CustomerAddressesDataSet();
                aCustomerAddressesTableAdapter = new CustomerAddressesDataSetTableAdapters.customeraddressesTableAdapter();
                aCustomerAddressesTableAdapter.Fill(aCustomerAddressesDataSet.customeraddresses);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Get Customers Address Info " + Ex.Message);
            }

            return aCustomerAddressesDataSet;
        }
        public void UpdateCustomerAddressesDB(CustomerAddressesDataSet aCustomerAddressesDataSet)
        {
            try
            {
                aCustomerAddressesTableAdapter = new CustomerAddressesDataSetTableAdapters.customeraddressesTableAdapter();
                aCustomerAddressesTableAdapter.Update(aCustomerAddressesDataSet.customeraddresses);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Customers Class // Update Customers Address DB " + Ex.Message);
            }
        }
    }
}
