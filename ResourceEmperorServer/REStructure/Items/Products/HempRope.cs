﻿using REProtocol;

namespace REStructure.Items.Products
{
    public class HempRope : Product
    {
        static ItemID _id;
        static string _name;
        static string _description;

        static HempRope()
        {
            _id = ItemID.HempRope;
            _name = "麻繩";
            _description = "";
        }
        protected HempRope() { }
        public HempRope(int itemCount) : base(itemCount) { }

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
