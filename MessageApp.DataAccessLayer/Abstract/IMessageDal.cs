using MessageApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        List<Message> GetReciverListMessage ( string mail );
        List<Message> GetSenderListMessage ( string mail );
        List<Message> GetSenderTrashMessage ( string mail );
        List<Message> GetRecieverTrashMessage ( string mail );
    }
}
