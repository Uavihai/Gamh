using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GAMH.Models;
using GAMH.Pages;
using Newtonsoft.Json;

namespace GAMH.Helpers
{
    public class JsonBL
    {
        private readonly string _contactWithUsJsonPath = "contactList.Json";
        private readonly string _clotheWithUsJsonPath = "clothesList.Json";

        public void AddContactMessage(ContactViewModel contactModel)
        {
            if (contactModel == null)
            {
                return;
            }

            //Add the new message to the list
            List<ContactViewModel> contactMessageList = GetAllContactMesssagesList();
            contactModel.ContactTime = DateTime.Now;
            contactMessageList.Add(contactModel);


            //Save the new file
            string textFile = JsonConvert.SerializeObject(contactMessageList);
            File.WriteAllText(_contactWithUsJsonPath,textFile);
        }

        public List<ContactViewModel> GetAllContactMesssagesList()
        {
            List<ContactViewModel> result = new List<ContactViewModel>();

            if (!File.Exists(_contactWithUsJsonPath))
            {
                var file = File.Create(_contactWithUsJsonPath);
                file.Dispose();
            }
            else
            {
                string textFile = File.ReadAllText(_contactWithUsJsonPath);

                //Check if the file is not empty
                if (!string.IsNullOrEmpty(textFile))
                {
                  result = JsonConvert.DeserializeObject<List<ContactViewModel>>(textFile);
                }
            }

            return result;
        }


        public void AddClotheOrder(ClotheOrderModel clotheOrderModel)
        {
            if (clotheOrderModel == null)
            {
                return;
            }

            //Add the new message to the list
            List<ClotheOrderModel> clothsOrderList = GetAllClotheOrdersList();
            clotheOrderModel.OrderDate = DateTime.Now;
            clothsOrderList.Add(clotheOrderModel);


            //Save the new file
            string textFile = JsonConvert.SerializeObject(clothsOrderList);
            File.WriteAllText(_clotheWithUsJsonPath, textFile);
        }

        public List<ClotheOrderModel> GetAllClotheOrdersList()
        {
            List<ClotheOrderModel> result = new List<ClotheOrderModel>();

            if (!File.Exists(_clotheWithUsJsonPath))
            {
                var file = File.Create(_clotheWithUsJsonPath);
                file.Dispose();
            }
            else
            {
                string textFile = File.ReadAllText(_clotheWithUsJsonPath);

                //Check if the file is not empty
                if (!string.IsNullOrEmpty(textFile))
                {
                    result = JsonConvert.DeserializeObject<List<ClotheOrderModel>>(textFile);
                }
            }

            return result;
        }
    }
}

