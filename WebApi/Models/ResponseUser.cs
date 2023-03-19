using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Entities;

namespace WebApi.Models {
    public class ResponseUser {
        public ResponseUser(User user) {
            ID = user.ID;

            UserSurname = user.Human.Surname;
            UserFirstname = user.Human.Firstname;
            UserPatronymic = user.Human.Patronymic;
            UserGender = user.Human.Gender;
            UserDateOfBirth = user.Human.DateOfBirth;

            UserName = user.UserName;
            UserPassword = user.UserPassword;
        }
        public int ID { get; set; }
        public string UserSurname { get; set; }
        public string UserFirstname { get; set; }
        public string UserPatronymic { get; set; }
        public string UserGender { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}