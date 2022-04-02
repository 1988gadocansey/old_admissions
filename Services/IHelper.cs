﻿//
//  Copyright 2021  2021
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Threading.Tasks;
namespace TTU_CORE_ASP_ADMISSION_PORTAL.Services
{
    public interface IHelper
    {
         public string GetProgrammeName(int id);
         
         public string GetApplicantIdFromFormNo(string id);
         
         public string GetApplicantCodeFromId(int id);
         
         public string GetHallName(int hall);
         
         public double GetHallFee(int hall);

        public int SendFileToServer(string host, int port, string username, string password, string filePath);

        public string SendSMSNotification(string PhoneNumber, string Message);

        public void SendEmailNotification(string Email,string Message);

        public  bool ContainsDuplicates(int[] a);
         
    }
}
