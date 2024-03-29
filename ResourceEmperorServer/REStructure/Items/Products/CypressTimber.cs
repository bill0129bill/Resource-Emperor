﻿using REProtocol;

namespace REStructure.Items.Products
{
    public class CypressTimber : Product
    {
        static ItemID _id;
        static string _name;
        static string _description;

        static CypressTimber()
        {
            _id = ItemID.CypressTimber;
            _name = "檜木材";
            _description = "";
        }
        protected CypressTimber() { }
        public CypressTimber(int itemCount) : base(itemCount) { }

        public override ItemID id
        {
            get
            {
                return _id;
            }

            protected set
            {
                _id = value;
            }
        }

        public override string name
        {
            get
            {
                return _name;
            }

            protected set
            {
                _name = value;
            }
        }

        public override string description
        {
            get
            {
                return _description;
            }

            protected set
            {
                _description = value;
            }
        }
    }
}
