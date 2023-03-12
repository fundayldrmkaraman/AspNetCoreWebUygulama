using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager:INewsLetterService
    {
        INewsletterDal newsletterDal;

        public NewsLetterManager(INewsletterDal newsletterDal)
        {
            this.newsletterDal = newsletterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            newsletterDal.Insert(newsLetter);
        }
    }
}
