using MessageApp.DataAccessLayer.Abstract;
using MessageApp.DataAccessLayer.Context;
using MessageApp.DataAccessLayer.Repositories;
using MessageApp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        MessageAppContext _context = new MessageAppContext();    
        public List<Message> GetRecieverTrashMessage ( string mail )
        {
            var values = _context.Messages.Where(x => (x.ReceiverMail == mail && x.ReceiverDelete == false && x.ReceiverTrashDelete == true) || (x.SenderMail == mail && x.SenderDelete == false && x.SenderTrashDelete == true)).ToList();
            return values;
        }

        public List<Message> GetReciverListMessage ( string mail )
        {
            var values = _context.Messages.Where(x => x.ReceiverMail == mail && x.ReceiverDelete == false && x.ReceiverTrashDelete == false).ToList();
            return values;
        }

        public List<Message> GetSenderListMessage ( string mail )
        {
            var values = _context.Messages.Where(x => x.SenderMail == mail && x.SenderDelete == false && x.SenderTrashDelete == false).ToList(); return values;
        }

        public List<Message> GetSenderTrashMessage ( string mail )
        {
            var values = _context.Messages.Where(x => x.SenderMail == mail && x.SenderDelete == false && x.SenderTrashDelete == true).ToList(); return values;
        }
    }
}
