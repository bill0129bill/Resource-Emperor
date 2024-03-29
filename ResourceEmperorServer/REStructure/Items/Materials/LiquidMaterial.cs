﻿using REProtocol;

namespace REStructure.Items.Materials
{
    public abstract class LiquidMaterial : Material
    {
        public abstract LiquidType type { get; protected set; }
        protected LiquidMaterial() : base() { }
        protected LiquidMaterial(int itemCount) : base(itemCount)
        {

        }
    }
}
