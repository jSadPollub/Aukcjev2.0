using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aukcje
{
    public abstract class BasePresenter<TView> : BasePresenter where TView : IBaseView
    {
        AuctionRepository _aRepo;
        public AuctionRepository AuctionRepo
        {
            get
            {
                if (_aRepo == null)
                    _aRepo = new AuctionRepository();
                return _aRepo;
            }
        }
        ColorRepository _cRepo;
        public ColorRepository ColorRepo
        {
            get
            {
                if (_cRepo == null)
                    _cRepo = new ColorRepository();
                return _cRepo;
            }
        }
        MembershipRepository _mRepo;
        public MembershipRepository MembershipRepo
        {
            get
            {
                if (_mRepo == null)
                    _mRepo = new MembershipRepository();
                return _mRepo;
            }
        }

        public new TView View
        {
            get
            {
                return (TView)base.View;
            }
            set
            {
                base.View = value;
            }
        }

    }
    public class BasePresenter : IBasePresenter
    {
        public IBaseView View { get; set; }
    }

}