// -----------------------------------------------------------------------
//    This file is part of TSGE.
//
//    TSGE is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    TSGE is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with TSGE.  If not, see <http://www.gnu.org/licenses/>.
// -----------------------------------------------------------------------

namespace tsge.Classes
{
    using Microsoft.Xna.Framework;
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;

    [Serializable]
    public class Item : ModelBase, ICloneable
    {
        /// <summary>
        /// Updates this item entry to the given item.
        /// </summary>
        /// <param name="itemId"></param>
        public void SetItem(int itemId)
        {
            // Obtain item..
            var item = Terraria.Instance.Items.Single(i => i.NetID == itemId).Clone() as Item;
            if (item == null) return;

            // Set this item info..
            this.Mech = item.Mech;
            this.Wet = item.Wet;
            this.WetCount = item.WetCount;
            this.LavaWet = item.LavaWet;
            this.Width = item.Width;
            this.Height = item.Height;
            this.Active = item.Active;
            this.NoGrabDelay = item.NoGrabDelay;
            this.BeingGrabbed = item.BeingGrabbed;
            this.SpawnTime = item.SpawnTime;
            this.WornArmor = item.WornArmor;
            this.OwnIgnore = item.OwnIgnore;
            this.OwnTime = item.OwnTime;
            this.KeepTime = item.KeepTime;
            this.Type = item.Type;
            this.Name = item.Name;
            this.HoldStyle = item.HoldStyle;
            this.UseStyle = item.UseStyle;
            this.Channel = item.Channel;
            this.Accessory = item.Accessory;
            this.UseAnimation = item.UseAnimation;
            this.UseTime = item.UseTime;
            this.Stack = item.Stack;
            this.MaxStack = item.MaxStack;
            this.Pick = item.Pick;
            this.Axe = item.Axe;
            this.Hammer = item.Hammer;
            this.TileBoost = item.TileBoost;
            this.CreateTile = item.CreateTile;
            this.CreateWall = item.CreateWall;
            this.PlaceStyle = item.PlaceStyle;
            this.Damage = item.Damage;
            this.KnockBack = item.KnockBack;
            this.HealLife = item.HealLife;
            this.HealMana = item.HealMana;
            this.Potion = item.Potion;
            this.Consumable = item.Consumable;
            this.AutoReuse = item.AutoReuse;
            this.UseTurn = item.UseTurn;
            this.Color = item.Color;
            this.Alpha = item.Alpha;
            this.Scale = item.Scale;
            this.UseSound = item.UseSound;
            this.Defense = item.Defense;
            this.HeadSlot = item.HeadSlot;
            this.BodySlot = item.BodySlot;
            this.LegSlot = item.LegSlot;
            this.ToolTip = item.ToolTip;
            this.ToolTip2 = item.ToolTip2;
            this.Owner = item.Owner;
            this.Rare = item.Rare;
            this.Shoot = item.Shoot;
            this.ShootSpeed = item.ShootSpeed;
            this.Ammo = item.Ammo;
            this.UseAmmo = item.UseAmmo;
            this.LifeRegen = item.LifeRegen;
            this.ManaIncrease = item.ManaIncrease;
            this.BuyOnce = item.BuyOnce;
            this.Mana = item.Mana;
            this.NoUseGraphic = item.NoUseGraphic;
            this.NoMelee = item.NoMelee;
            this.Release = item.Release;
            this.Value = item.Value;
            this.Buy = item.Buy;
            this.Social = item.Social;
            this.Vanity = item.Vanity;
            this.Material = item.Material;
            this.NoWet = item.NoWet;
            this.BuffType = item.BuffType;
            this.BuffTime = item.BuffTime;
            this.NetID = item.NetID;
            this.Crit = item.Crit;
            this.Prefix = item.Prefix;
            this.Melee = item.Melee;
            this.Magic = item.Magic;
            this.Ranged = item.Ranged;
            this.ReuseDelay = item.ReuseDelay;
            //this.Id = item.Id;
            //this.Icon = item.Icon;
            //this.Count = item.Count;
            this.TileWand = item.TileWand;
            this.Flame = item.Flame;
            this.HoneyWet = item.HoneyWet;
            this.Position = item.Position;
            this.Velocity = item.Velocity;
            this.Dye = item.Dye;
            this.Paint = item.Paint;
            this.NotAmmo = item.NotAmmo;
            this.Summon = item.Summon;
        }

        /// <summary>
        /// Gets or sets the mech of this item.
        /// </summary>
        [XmlElement("mech")]
        public bool Mech
        {
            get { return this.Get<bool>("Mech"); }
            set { this.Set("Mech", value); }
        }

        /// <summary>
        /// Gets or sets the wet of this item.
        /// </summary>
        [XmlElement("wet")]
        public bool Wet
        {
            get { return this.Get<bool>("Wet"); }
            set { this.Set("Wet", value); }
        }

        /// <summary>
        /// Gets or sets the wet count of this item.
        /// </summary>
        [XmlElement("wetCount")]
        public byte WetCount
        {
            get { return this.Get<byte>("WetCount"); }
            set { this.Set("WetCount", value); }
        }

        /// <summary>
        /// Gets or sets the lava wet of this item.
        /// </summary>
        [XmlElement("lavaWet")]
        public bool LavaWet
        {
            get { return this.Get<bool>("LavaWet"); }
            set { this.Set("LavaWet", value); }
        }

        /// <summary>
        /// Gets or sets the width of this item.
        /// </summary>
        [XmlElement("width")]
        public int Width
        {
            get { return this.Get<int>("Width"); }
            set { this.Set("Width", value); }
        }

        /// <summary>
        /// Gets or sets the height of this item.
        /// </summary>
        [XmlElement("height")]
        public int Height
        {
            get { return this.Get<int>("Height"); }
            set { this.Set("Height", value); }
        }

        /// <summary>
        /// Gets or sets the active state of this item.
        /// </summary>
        [XmlElement("active")]
        public bool Active
        {
            get { return this.Get<bool>("Active"); }
            set { this.Set("Active", value); }
        }

        /// <summary>
        /// Gets or sets the no grab delay of this item.
        /// </summary>
        [XmlElement("noGrabDelay")]
        public int NoGrabDelay
        {
            get { return this.Get<int>("NoGrabDelay"); }
            set { this.Set("NoGrabDelay", value); }
        }

        /// <summary>
        /// Gets or sets the being grabbed state of this item.
        /// </summary>
        [XmlElement("beingGrabbed")]
        public bool BeingGrabbed
        {
            get { return this.Get<bool>("BeingGrabbed"); }
            set { this.Set("BeingGrabbed", value); }
        }

        /// <summary>
        /// Gets or sets the spawn time of this item.
        /// </summary>
        [XmlElement("spawnTime")]
        public int SpawnTime
        {
            get { return this.Get<int>("SpawnTime"); }
            set { this.Set("SpawnTime", value); }
        }

        /// <summary>
        /// Gets or sets the worm armor flag of this item.
        /// </summary>
        [XmlElement("wornArmor")]
        public bool WornArmor
        {
            get { return this.Get<bool>("WornArmor"); }
            set { this.Set("WornArmor", value); }
        }

        /// <summary>
        /// Gets or sets the own ignore of this item.
        /// </summary>
        [XmlElement("ownIgnore")]
        public int OwnIgnore
        {
            get { return this.Get<int>("OwnIgnore"); }
            set { this.Set("OwnIgnore", value); }
        }

        /// <summary>
        /// Gets or sets the own time of this item.
        /// </summary>
        [XmlElement("ownTime")]
        public int OwnTime
        {
            get { return this.Get<int>("OwnTime"); }
            set { this.Set("OwnTime", value); }
        }

        /// <summary>
        /// Gets or sets the keep time of this item.
        /// </summary>
        [XmlElement("keepTime")]
        public int KeepTime
        {
            get { return this.Get<int>("KeepTime"); }
            set { this.Set("KeepTime", value); }
        }

        /// <summary>
        /// Gets or sets the type of this item.
        /// </summary>
        [XmlElement("type")]
        public int Type
        {
            get { return this.Get<int>("Type"); }
            set
            {
                this.Id = value;
                this.Set("Type", value);
            }
        }

        /// <summary>
        /// Gets or sets the name of this item.
        /// </summary>
        [XmlElement("name")]
        public string Name
        {
            get { return this.Get<string>("Name"); }
            set { this.Set("Name", value); }
        }

        /// <summary>
        /// Gets or sets the hold style of this item.
        /// </summary>
        [XmlElement("holdStyle")]
        public int HoldStyle
        {
            get { return this.Get<int>("HoldStyle"); }
            set { this.Set("HoldStyle", value); }
        }

        /// <summary>
        /// Gets or sets the use style of this item.
        /// </summary>
        [XmlElement("useStyle")]
        public int UseStyle
        {
            get { return this.Get<int>("UseStyle"); }
            set { this.Set("UseStyle", value); }
        }

        /// <summary>
        /// Gets or sets the channel of this item.
        /// </summary>
        [XmlElement("channel")]
        public bool Channel
        {
            get { return this.Get<bool>("Channel"); }
            set { this.Set("Channel", value); }
        }

        /// <summary>
        /// Gets or sets the accessory flag of this item.
        /// </summary>
        [XmlElement("accessory")]
        public bool Accessory
        {
            get { return this.Get<bool>("Accessory"); }
            set { this.Set("Accessory", value); }
        }

        /// <summary>
        /// Gets or sets the use animation of this item.
        /// </summary>
        [XmlElement("useAnimation")]
        public int UseAnimation
        {
            get { return this.Get<int>("UseAnimation"); }
            set { this.Set("UseAnimation", value); }
        }

        /// <summary>
        /// Gets or sets the use time of this item.
        /// </summary>
        [XmlElement("useTime")]
        public int UseTime
        {
            get { return this.Get<int>("UseTime"); }
            set { this.Set("UseTime", value); }
        }

        /// <summary>
        /// Gets or sets the stack of this item.
        /// </summary>
        [XmlElement("stack")]
        public int Stack
        {
            get { return this.Get<int>("Stack"); }
            set { this.Set("Stack", value); }
        }

        /// <summary>
        /// Gets or sets the max stack of this item.
        /// </summary>
        [XmlElement("maxStack")]
        public int MaxStack
        {
            get { return this.Get<int>("MaxStack"); }
            set { this.Set("MaxStack", value); }
        }

        /// <summary>
        /// Gets or sets the pick of this item.
        /// </summary>
        [XmlElement("pick")]
        public int Pick
        {
            get { return this.Get<int>("Pick"); }
            set { this.Set("Pick", value); }
        }

        /// <summary>
        /// Gets or sets the axe of this item.
        /// </summary>
        [XmlElement("axe")]
        public int Axe
        {
            get { return this.Get<int>("Axe"); }
            set { this.Set("Axe", value); }
        }

        /// <summary>
        /// Gets or sets the hammer of this item.
        /// </summary>
        [XmlElement("hammer")]
        public int Hammer
        {
            get { return this.Get<int>("Hammer"); }
            set { this.Set("Hammer", value); }
        }

        /// <summary>
        /// Gets or sets the tile boost of this item.
        /// </summary>
        [XmlElement("tileBoost")]
        public int TileBoost
        {
            get { return this.Get<int>("TileBoost"); }
            set { this.Set("TileBoost", value); }
        }

        /// <summary>
        /// Gets or sets the create tile of this item.
        /// </summary>
        [XmlElement("createTile")]
        public int CreateTile
        {
            get { return this.Get<int>("CreateTile"); }
            set { this.Set("CreateTile", value); }
        }

        /// <summary>
        /// Gets or sets the create wall of this item.
        /// </summary>
        [XmlElement("createWall")]
        public int CreateWall
        {
            get { return this.Get<int>("CreateWall"); }
            set { this.Set("CreateWall", value); }
        }

        /// <summary>
        /// Gets or sets the place style of this item.
        /// </summary>
        [XmlElement("placeStyle")]
        public int PlaceStyle
        {
            get { return this.Get<int>("PlaceStyle"); }
            set { this.Set("PlaceStyle", value); }
        }

        /// <summary>
        /// Gets or sets the damage of this item.
        /// </summary>
        [XmlElement("damage")]
        public int Damage
        {
            get { return this.Get<int>("Damage"); }
            set { this.Set("Damage", value); }
        }

        /// <summary>
        /// Gets or sets the knock back of this item.
        /// </summary>
        [XmlElement("knockBack")]
        public float KnockBack
        {
            get { return this.Get<float>("KnockBack"); }
            set { this.Set("KnockBack", value); }
        }

        /// <summary>
        /// Gets or sets the heal life of this item.
        /// </summary>
        [XmlElement("healLife")]
        public int HealLife
        {
            get { return this.Get<int>("HealLife"); }
            set { this.Set("HealLife", value); }
        }

        /// <summary>
        /// Gets or sets the heal mana of this item.
        /// </summary>
        [XmlElement("healMana")]
        public int HealMana
        {
            get { return this.Get<int>("HealMana"); }
            set { this.Set("HealMana", value); }
        }

        /// <summary>
        /// Gets or sets the potion flag of this item.
        /// </summary>
        [XmlElement("potion")]
        public bool Potion
        {
            get { return this.Get<bool>("Potion"); }
            set { this.Set("Potion", value); }
        }

        /// <summary>
        /// Gets or sets the consumable flag of this item.
        /// </summary>
        [XmlElement("consumable")]
        public bool Consumable
        {
            get { return this.Get<bool>("Consumable"); }
            set { this.Set("Consumable", value); }
        }

        /// <summary>
        /// Gets or sets the auto reuse flag of this item.
        /// </summary>
        [XmlElement("autoReuse")]
        public bool AutoReuse
        {
            get { return this.Get<bool>("AutoReuse"); }
            set { this.Set("AutoReuse", value); }
        }

        /// <summary>
        /// Gets or sets the use turn flag of this item.
        /// </summary>
        [XmlElement("useTurn")]
        public bool UseTurn
        {
            get { return this.Get<bool>("UseTurn"); }
            set { this.Set("UseTurn", value); }
        }
        [XmlElement("color")]
        public System.Drawing.Color Color
        {
            get { return this.Get<System.Drawing.Color>("Color"); }
            set { this.Set("Color", value); }
        }

        /// <summary>
        /// Gets or sets the alpha of this item.
        /// </summary>
        [XmlElement("alpha")]
        public int Alpha
        {
            get { return this.Get<int>("Alpha"); }
            set { this.Set("Alpha", value); }
        }

        /// <summary>
        /// Gets or sets the scale of this item.
        /// </summary>
        [XmlElement("scale")]
        public float Scale
        {
            get { return this.Get<float>("Scale"); }
            set { this.Set("Scale", value); }
        }

        /// <summary>
        /// Gets or sets the use sound of this item.
        /// </summary>
        [XmlElement("useSound")]
        public int UseSound
        {
            get { return this.Get<int>("UseSound"); }
            set { this.Set("UseSound", value); }
        }

        /// <summary>
        /// Gets or sets the defense of this item.
        /// </summary>
        [XmlElement("defense")]
        public int Defense
        {
            get { return this.Get<int>("Defense"); }
            set { this.Set("Defense", value); }
        }

        /// <summary>
        /// Gets or sets the head slot of this item.
        /// </summary>
        [XmlElement("headSlot")]
        public int HeadSlot
        {
            get { return this.Get<int>("HeadSlot"); }
            set { this.Set("HeadSlot", value); }
        }

        /// <summary>
        /// Gets or sets the body slot of this item.
        /// </summary>
        [XmlElement("bodySlot")]
        public int BodySlot
        {
            get { return this.Get<int>("BodySlot"); }
            set { this.Set("BodySlot", value); }
        }

        /// <summary>
        /// Gets or sets the leg slot of this item.
        /// </summary>
        [XmlElement("legSlot")]
        public int LegSlot
        {
            get { return this.Get<int>("LegSlot"); }
            set { this.Set("LegSlot", value); }
        }

        /// <summary>
        /// Gets or sets the tooltip of this item.
        /// </summary>
        [XmlElement("toolTip")]
        public string ToolTip
        {
            get { return this.Get<string>("ToolTip"); }
            set { this.Set("ToolTip", value); }
        }

        /// <summary>
        /// Gets or sets the tooltip2 of this item.
        /// </summary>
        [XmlElement("toolTip2")]
        public string ToolTip2
        {
            get { return this.Get<string>("ToolTip2"); }
            set { this.Set("ToolTip2", value); }
        }

        /// <summary>
        /// Gets or sets the owner of this item.
        /// </summary>
        [XmlElement("owner")]
        public int Owner
        {
            get { return this.Get<int>("Owner"); }
            set { this.Set("Owner", value); }
        }

        /// <summary>
        /// Gets or sets the rare of this item.
        /// </summary>
        [XmlElement("rare")]
        public int Rare
        {
            get { return this.Get<int>("Rare"); }
            set { this.Set("Rare", value); }
        }

        /// <summary>
        /// Gets or sets the shoot of this item.
        /// </summary>
        [XmlElement("shoot")]
        public int Shoot
        {
            get { return this.Get<int>("Shoot"); }
            set { this.Set("Shoot", value); }
        }

        /// <summary>
        /// Gets or sets the shoot speed of this item.
        /// </summary>
        [XmlElement("shootSpeed")]
        public float ShootSpeed
        {
            get { return this.Get<float>("ShootSpeed"); }
            set { this.Set("ShootSpeed", value); }
        }

        /// <summary>
        /// Gets or sets the ammo of this item.
        /// </summary>
        [XmlElement("ammo")]
        public int Ammo
        {
            get { return this.Get<int>("Ammo"); }
            set { this.Set("Ammo", value); }
        }

        /// <summary>
        /// Gets or sets the use ammo of this item.
        /// </summary>
        [XmlElement("useAmmo")]
        public int UseAmmo
        {
            get { return this.Get<int>("UseAmmo"); }
            set { this.Set("UseAmmo", value); }
        }

        /// <summary>
        /// Gets or sets the life regen of this item.
        /// </summary>
        [XmlElement("lifeRegen")]
        public int LifeRegen
        {
            get { return this.Get<int>("LifeRegen"); }
            set { this.Set("LifeRegen", value); }
        }

        /// <summary>
        /// Gets or sets the mana increase of this item.
        /// </summary>
        [XmlElement("manaIncrease")]
        public int ManaIncrease
        {
            get { return this.Get<int>("ManaIncrease"); }
            set { this.Set("ManaIncrease", value); }
        }

        /// <summary>
        /// Gets or sets the buy once flag of this item.
        /// </summary>
        [XmlElement("buyOnce")]
        public bool BuyOnce
        {
            get { return this.Get<bool>("BuyOnce"); }
            set { this.Set("BuyOnce", value); }
        }

        /// <summary>
        /// Gets or sets the mana of this item.
        /// </summary>
        [XmlElement("mana")]
        public int Mana
        {
            get { return this.Get<int>("Mana"); }
            set { this.Set("Mana", value); }
        }

        /// <summary>
        /// Gets or sets the no use graphic flag of this item.
        /// </summary>
        [XmlElement("noUseGraphic")]
        public bool NoUseGraphic
        {
            get { return this.Get<bool>("NoUseGraphic"); }
            set { this.Set("NoUseGraphic", value); }
        }

        /// <summary>
        /// Gets or sets the no melee flag of this item.
        /// </summary>
        [XmlElement("noMelee")]
        public bool NoMelee
        {
            get { return this.Get<bool>("NoMelee"); }
            set { this.Set("NoMelee", value); }
        }

        /// <summary>
        /// Gets or sets the release of this item.
        /// </summary>
        [XmlElement("release")]
        public int Release
        {
            get { return this.Get<int>("Release"); }
            set { this.Set("Release", value); }
        }

        /// <summary>
        /// Gets or sets the value of this item.
        /// </summary>
        [XmlElement("value")]
        public int Value
        {
            get { return this.Get<int>("Value"); }
            set { this.Set("Value", value); }
        }

        /// <summary>
        /// Gets or sets the buy of this item.
        /// </summary>
        [XmlElement("buy")]
        public bool Buy
        {
            get { return this.Get<bool>("Buy"); }
            set { this.Set("Buy", value); }
        }

        /// <summary>
        /// Gets or sets the social flag of this item.
        /// </summary>
        [XmlElement("social")]
        public bool Social
        {
            get { return this.Get<bool>("Social"); }
            set { this.Set("Social", value); }
        }

        /// <summary>
        /// Gets or sets the vanity flag of this item.
        /// </summary>
        [XmlElement("vanity")]
        public bool Vanity
        {
            get { return this.Get<bool>("Vanity"); }
            set { this.Set("Vanity", value); }
        }

        /// <summary>
        /// Gets or sets the metarial flag of this item.
        /// </summary>
        [XmlElement("material")]
        public bool Material
        {
            get { return this.Get<bool>("Material"); }
            set { this.Set("Material", value); }
        }

        /// <summary>
        /// Gets or sets the no wet flag of this item.
        /// </summary>
        [XmlElement("noWet")]
        public bool NoWet
        {
            get { return this.Get<bool>("NoWet"); }
            set { this.Set("NoWet", value); }
        }

        /// <summary>
        /// Gets or sets the buff type of this item.
        /// </summary>
        [XmlElement("buffType")]
        public int BuffType
        {
            get { return this.Get<int>("BuffType"); }
            set { this.Set("BuffType", value); }
        }

        /// <summary>
        /// Gets or sets the buff time of this item.
        /// </summary>
        [XmlElement("buffTime")]
        public int BuffTime
        {
            get { return this.Get<int>("BuffTime"); }
            set { this.Set("BuffTime", value); }
        }

        /// <summary>
        /// Gets or sets the net id of this item.
        /// </summary>
        [XmlElement("netID")]
        public int NetID
        {
            get { return this.Get<int>("NetID"); }
            set { this.Set("NetID", value); }
        }

        /// <summary>
        /// Gets or sets the crit of this item.
        /// </summary>
        [XmlElement("crit")]
        public int Crit
        {
            get { return this.Get<int>("Crit"); }
            set { this.Set("Crit", value); }
        }

        /// <summary>
        /// Gets or sets the prefix of this item.
        /// </summary>
        [XmlElement("prefix")]
        public byte Prefix
        {
            get { return this.Get<byte>("Prefix"); }
            set { this.Set("Prefix", value); }
        }

        /// <summary>
        /// Gets or sets the melee flag of this item.
        /// </summary>
        [XmlElement("melee")]
        public bool Melee
        {
            get { return this.Get<bool>("Melee"); }
            set { this.Set("Melee", value); }
        }

        /// <summary>
        /// Gets or sets the magic flag of this item.
        /// </summary>
        [XmlElement("magic")]
        public bool Magic
        {
            get { return this.Get<bool>("Magic"); }
            set { this.Set("Magic", value); }
        }

        /// <summary>
        /// Gets or sets the ranged flag of this item.
        /// </summary>
        [XmlElement("ranged")]
        public bool Ranged
        {
            get { return this.Get<bool>("Ranged"); }
            set { this.Set("Ranged", value); }
        }

        /// <summary>
        /// Gets or sets the reuse delay of this item.
        /// </summary>
        [XmlElement("reuseDelay")]
        public int ReuseDelay
        {
            get { return this.Get<int>("ReuseDelay"); }
            set { this.Set("ReuseDelay", value); }
        }

        /// <summary>
        /// Gets or sets the id of this item.
        /// </summary>
        [XmlIgnore]
        public int Id
        {
            get { return this.Get<int>("Id"); }
            set
            {
                this.Icon = new Uri(string.Format(@"{0}\Data\Items\item_{1}.png", AppDomain.CurrentDomain.BaseDirectory, value), UriKind.Absolute);
                this.Set("Id", value);
            }
        }

        /// <summary>
        /// Gets or sets the icon of this item.
        /// </summary>
        [XmlIgnore]
        public Uri Icon
        {
            get { return this.Get<Uri>("Icon"); }
            set { this.Set("Icon", value); }
        }

        /// <summary>
        /// Gets or sets the count of this item.
        /// </summary>
        [XmlIgnore]
        public int Count
        {
            get { return this.Get<int>("Count"); }
            set { this.Set("Count", value); }
        }

        //
        // New Properties in 1.2
        //

        /// <summary>
        /// Gets or sets the tile wand of this item.
        /// </summary>
        [XmlElement("tileWand")]
        public int TileWand
        {
            get { return this.Get<int>("TileWand"); }
            set { this.Set("TileWand", value); }
        }

        /// <summary>
        /// Gets or sets the flame of this item.
        /// </summary>
        [XmlElement("flame")]
        public bool Flame
        {
            get { return this.Get<bool>("Flame"); }
            set { this.Set("Flame", value); }
        }

        /// <summary>
        /// Gets or sets the honey wet of this item.
        /// </summary>
        [XmlElement("honeyWet")]
        public bool HoneyWet
        {
            get { return this.Get<bool>("HoneyWet"); }
            set { this.Set("HoneyWet", value); }
        }

        /// <summary>
        /// Gets or sets the position of this item.
        /// </summary>
        [XmlElement("position")]
        public Vector2 Position
        {
            get { return this.Get<Vector2>("Position"); }
            set { this.Set("Position", value); }
        }

        /// <summary>
        /// Gets or sets the velocity of this item.
        /// </summary>
        [XmlElement("velocity")]
        public Vector2 Velocity
        {
            get { return this.Get<Vector2>("Velocity"); }
            set { this.Set("Velocity", value); }
        }

        /// <summary>
        /// Gets or sets the dye of this item.
        /// </summary>
        [XmlElement("dye")]
        public byte Dye
        {
            get { return this.Get<byte>("Dye"); }
            set { this.Set("Dye", value); }
        }

        /// <summary>
        /// Gets or sets the paint of this item.
        /// </summary>
        [XmlElement("paint")]
        public byte Paint
        {
            get { return this.Get<byte>("Paint"); }
            set { this.Set("Paint", value); }
        }

        /// <summary>
        /// Gets or sets the not ammo of this item.
        /// </summary>
        [XmlElement("notAmmo")]
        public bool NotAmmo
        {
            get { return this.Get<bool>("NotAmmo"); }
            set { this.Set("NotAmmo", value); }
        }

        /// <summary>
        /// Gets or sets the summon of this item.
        /// </summary>
        [XmlElement("summon")]
        public bool Summon
        {
            get { return this.Get<bool>("Summon"); }
            set { this.Set("Summon", value); }
        }

        /// <summary>
        /// ToString override to return the name of the item with its prefix.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var toolTip = string.Empty; // string.Format("[{0:D04}]", this.NetID);
            var prefix = Terraria.Instance.Prefixes.SingleOrDefault(p => p.Id == this.Prefix);
            if (prefix != null && prefix.Id > 0)
                toolTip += prefix.Prefix + " ";
            toolTip += this.Name;

            return toolTip;
        }

        /// <summary>
        /// ICloneable implementation.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            try
            {
                using (var mStream = new MemoryStream())
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(mStream, this);
                    mStream.Position = 0;
                    return formatter.Deserialize(mStream);
                }
            }
            catch
            {
                return this.MemberwiseClone();
            }
        }
    }
}
