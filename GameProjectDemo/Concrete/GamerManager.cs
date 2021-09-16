using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {

        IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }

        public  void Add(Gamer gamer)
        {

            if (verificationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " isimli kullanıcı kaydedildi.");
            }
            else
            {
                throw new Exception("Not a valid person");
            }   
        }

       

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli kullanıcı sistemden silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli kullanıcı bilgisi güncellendi.\n");
        }
    }
}
