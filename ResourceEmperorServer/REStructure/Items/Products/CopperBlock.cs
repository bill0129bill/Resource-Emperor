﻿using REProtocol;

namespace REStructure.Items.Products
{
    public class CopperBlock : Product
    {
        static ItemID _id;
        static string _name;
        static string _description;

        static CopperBlock()
        {
            _id = ItemID.CopperBlock;
            _name = "銅塊";
            _description = "";
        }
        protected CopperBlock() { }
        public CopperBlock(int itemCount) : base(itemCount) { }

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
