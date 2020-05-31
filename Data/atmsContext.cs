using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using dtms.Models;

namespace dtms.data
{
    public partial class atmsContext : DbContext
    {
        public atmsContext()
        {
        }

        public atmsContext(DbContextOptions<atmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Amphur> Amphur { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<ChargeItem> ChargeItem { get; set; }
        public virtual DbSet<Chargeable> Chargeable { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientDefinedZone> ClientDefinedZone { get; set; }
        public virtual DbSet<ClientHoliday> ClientHoliday { get; set; }
        public virtual DbSet<ClientOrder> ClientOrder { get; set; }
        public virtual DbSet<ClientOrderDetail> ClientOrderDetail { get; set; }
        public virtual DbSet<ClientServiceChargeRate> ClientServiceChargeRate { get; set; }
        public virtual DbSet<ClientServiceRateCharge> ClientServiceRateCharge { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerZone> CustomerZone { get; set; }
        public virtual DbSet<DeliveryIncident> DeliveryIncident { get; set; }
        public virtual DbSet<DistributionAlias> DistributionAlias { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<OrderDate> OrderDate { get; set; }
        public virtual DbSet<OrderEvent> OrderEvent { get; set; }
        public virtual DbSet<OrderFileStaging> OrderFileStaging { get; set; }
        public virtual DbSet<OrderInstruction> OrderInstruction { get; set; }
        public virtual DbSet<OrderNote> OrderNote { get; set; }
        public virtual DbSet<OrderReference> OrderReference { get; set; }
        public virtual DbSet<OrderServiceType> OrderServiceType { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<PlaceClientZoneAssociation> PlaceClientZoneAssociation { get; set; }
        public virtual DbSet<PodGrouping> PodGrouping { get; set; }
        public virtual DbSet<PodHeader> PodHeader { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductUom> ProductUom { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectClient> ProjectClient { get; set; }
        public virtual DbSet<ProjectGsin> ProjectGsin { get; set; }
        public virtual DbSet<ProjectUser> ProjectUser { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<QuantityRateCost> QuantityRateCost { get; set; }
        public virtual DbSet<ReceiptEntity> ReceiptEntity { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ServiceChargeByVehicleType> ServiceChargeByVehicleType { get; set; }
        public virtual DbSet<SkyfrogUser> SkyfrogUser { get; set; }
        public virtual DbSet<ThailandLocation> ThailandLocation { get; set; }
        public virtual DbSet<ThailandPostalCode> ThailandPostalCode { get; set; }
        public virtual DbSet<TransportServiceProvider> TransportServiceProvider { get; set; }
        public virtual DbSet<TripRateChargeDetail> TripRateChargeDetail { get; set; }
        public virtual DbSet<TripRateChargeHeader> TripRateChargeHeader { get; set; }
        public virtual DbSet<Truck> Truck { get; set; }
        public virtual DbSet<TruckDriver> TruckDriver { get; set; }
        public virtual DbSet<TruckLoad> TruckLoad { get; set; }
        public virtual DbSet<TruckLoadDetail> TruckLoadDetail { get; set; }
        public virtual DbSet<TruckloadCharge> TruckloadCharge { get; set; }
        public virtual DbSet<TruckloadCity> TruckloadCity { get; set; }
        public virtual DbSet<TruckloadDropPoint> TruckloadDropPoint { get; set; }
        public virtual DbSet<TruckloadDropPointDetail> TruckloadDropPointDetail { get; set; }
        public virtual DbSet<TruckloadExtracharge> TruckloadExtracharge { get; set; }
        public virtual DbSet<TruckloadSenderOrder> TruckloadSenderOrder { get; set; }
        public virtual DbSet<TruckloadService> TruckloadService { get; set; }
        public virtual DbSet<UserOrigin> UserOrigin { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserStorer> UserStorer { get; set; }
        public virtual DbSet<VOrderInformation> VOrderInformation { get; set; }
        public virtual DbSet<VProductBarcode> VProductBarcode { get; set; }
        public virtual DbSet<VclientOrder> VclientOrder { get; set; }
        public virtual DbSet<VclientOrderDetail> VclientOrderDetail { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<VolumeRateChargeHeader> VolumeRateChargeHeader { get; set; }
        public virtual DbSet<VolumeRateCost> VolumeRateCost { get; set; }
        public virtual DbSet<VtruckloadDetail> VtruckloadDetail { get; set; }
        public virtual DbSet<ZipCode> ZipCode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=10.170.8.12;Initial Catalog=atms;user id=sa;password=Thailand#1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amphur>(entity =>
            {
                entity.HasKey(e => e.AmphurCode);

                entity.ToTable("amphur");

                entity.Property(e => e.AmphurCode)
                    .HasColumnName("amphur_code")
                    .HasMaxLength(50);

                entity.Property(e => e.EnglishName)
                    .HasColumnName("english_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Progress).HasColumnName("progress");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.ResourceLoad).HasColumnName("resourceLoad");

                entity.Property(e => e.TaskId).HasColumnName("task_id");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.CalendarDate);

                entity.ToTable("calendar");

                entity.Property(e => e.CalendarDate)
                    .HasColumnName("calendar_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ChargeItem>(entity =>
            {
                entity.HasKey(e => e.ServiceChargeCode);

                entity.ToTable("charge_item");

                entity.Property(e => e.ServiceChargeCode)
                    .HasColumnName("service_charge_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ChargeType)
                    .HasColumnName("charge_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Chargeable>(entity =>
            {
                entity.ToTable("chargeable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Charge)
                    .HasColumnName("charge")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientName)
                    .HasColumnName("client_name")
                    .HasMaxLength(100);

                entity.Property(e => e.DefaultTripType)
                    .HasColumnName("default_trip_type")
                    .HasMaxLength(100);

                entity.Property(e => e.InActive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastOrderNumber)
                    .HasColumnName("last_order_number")
                    .HasDefaultValueSql("((1000000))");

                entity.Property(e => e.MonthlyLastOrderNumber)
                    .HasColumnName("monthly_last_order_number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateType)
                    .HasColumnName("Rate_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TruckOrderPrefix)
                    .HasColumnName("truck_order_prefix")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClientDefinedZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK_transport_zone");

                entity.ToTable("client_defined_zone");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zone_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.ShortCode)
                    .HasColumnName("short_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClientHoliday>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.HolidayDate });

                entity.ToTable("client_holiday");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.HolidayDate)
                    .HasColumnName("holiday_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DescriptionEnglish)
                    .HasColumnName("description_english")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionThai)
                    .HasColumnName("description_thai")
                    .HasMaxLength(50);

                entity.Property(e => e.HolidayYear).HasColumnName("holiday_year");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientHoliday)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_client_holiday_client");
            });

            modelBuilder.Entity<ClientOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderNumber, e.ClientId })
                    .HasName("pk_wmspOrder_storere");

                entity.ToTable("client_order");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("ix_create_date");

                entity.HasIndex(e => e.CustomerReceivedDate)
                    .HasName("x_customer_received_date");

                entity.HasIndex(e => e.DueDate)
                    .HasName("x_due_date");

                entity.HasIndex(e => e.LoadedDate)
                    .HasName("x_loaded_date");

                entity.HasIndex(e => e.OrderDate)
                    .HasName("ix_order_date");

                entity.HasIndex(e => e.PodToSender)
                    .HasName("x_pod_to_sender");

                entity.HasIndex(e => e.RemarkDelivery)
                    .HasName("ix_remark_delivery");

                entity.HasIndex(e => e.ShipToName1)
                    .HasName("x_ship_to_name1");

                entity.HasIndex(e => e.TruckBookingDate)
                    .HasName("ix_truck_booking_date");

                entity.HasIndex(e => new { e.PodToSender, e.DueDate })
                    .HasName("x_pod_to_sender_due_date");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ApllRemark)
                    .HasColumnName("APLL_remark")
                    .HasMaxLength(250);

                entity.Property(e => e.AppointmentFlag)
                    .HasColumnName("appointment_flag")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CancelledDate)
                    .HasColumnName("cancelled_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("change_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientCustomerId)
                    .HasColumnName("client_customer_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmShipDate)
                    .HasColumnName("confirm_ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPickup)
                    .HasColumnName("customer_pickup")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CustomerPo)
                    .HasColumnName("Customer_po")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryStatus)
                    .HasColumnName("delivery_status")
                    .HasMaxLength(10);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gsin)
                    .HasColumnName("GSIN")
                    .HasMaxLength(100);

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.LoadedDate)
                    .HasColumnName("loaded_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberOfOrderLines)
                    .HasColumnName("Number_of_Order_Lines")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NumberOfShipment).HasColumnName("number_of_shipment");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PickAssignedDate)
                    .HasColumnName("pick_assigned_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickupType)
                    .HasColumnName("pickup_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Po)
                    .HasColumnName("PO")
                    .HasMaxLength(50);

                entity.Property(e => e.PodEnterDate)
                    .HasColumnName("pod_enter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodGroup)
                    .HasColumnName("pod_group")
                    .HasMaxLength(50);

                entity.Property(e => e.PodReceivedDate)
                    .HasColumnName("pod_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecordSource)
                    .HasColumnName("record_source")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseToPickDate)
                    .HasColumnName("release_to_pick_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.RevisedDueDate)
                    .HasColumnName("revised_due_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevisedDueDateReason)
                    .HasColumnName("revised_due_date_reason")
                    .HasMaxLength(100);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(50);

                entity.Property(e => e.SenderOrder)
                    .IsRequired()
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress1)
                    .HasColumnName("Ship_To_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToAddress2)
                    .HasColumnName("Ship_To_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToCity)
                    .HasColumnName("Ship_To_City")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.ShipToCountryCode)
                    .HasColumnName("Ship_To_Country_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName1)
                    .HasColumnName("ship_to_Name1")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToName2)
                    .HasColumnName("Ship_to_Name2")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToName3)
                    .HasColumnName("Ship_To_Name3")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToPostalCode)
                    .HasColumnName("Ship_To_Postal_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToState)
                    .HasColumnName("Ship_To_State")
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TermOfPayment)
                    .HasColumnName("term_of_payment")
                    .HasMaxLength(50);

                entity.Property(e => e.ToBeRemoved)
                    .HasColumnName("to_be_removed")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TotalShippedQty)
                    .HasColumnName("Total_Shipped_Qty")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("Total_volume")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.TransportZone)
                    .HasColumnName("transport_zone")
                    .HasMaxLength(50);

                entity.Property(e => e.TruckBookingDate)
                    .HasColumnName("truck_booking_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.DestinationNavigation)
                    .WithMany(p => p.ClientOrder)
                    .HasForeignKey(d => d.Destination)
                    .HasConstraintName("FK_client_order_place");

                entity.HasOne(d => d.ShipToPostalCodeNavigation)
                    .WithMany(p => p.ClientOrder)
                    .HasForeignKey(d => d.ShipToPostalCode)
                    .HasConstraintName("FK_client_order_Thailand_postal_code");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.ClientOrder)
                    .HasForeignKey(d => new { d.CustomerCode, d.ClientId })
                    .HasConstraintName("fk_client_order_customer");
            });

            modelBuilder.Entity<ClientOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderNumber, e.ClientId, e.Line })
                    .HasName("PK__shiporder_detail__7849DB76");

                entity.ToTable("client_order_detail");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Line)
                    .HasColumnName("line")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.BatchLot)
                    .HasColumnName("batch_lot")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangedDate)
                    .HasColumnName("changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangedTime)
                    .HasColumnName("changed_time")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.DeliveredQty)
                    .HasColumnName("delivered_qty")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoadedQty)
                    .HasColumnName("loaded_qty")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderQty)
                    .HasColumnName("order_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PodEnterDate)
                    .HasColumnName("pod_enter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodIdentfication)
                    .HasColumnName("pod_identfication")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductOwner)
                    .HasColumnName("product_owner")
                    .HasMaxLength(6);

                entity.Property(e => e.RecordStatus)
                    .HasColumnName("record_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(100);

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(50);

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ClientOrder)
                    .WithMany(p => p.ClientOrderDetail)
                    .HasForeignKey(d => new { d.OrderNumber, d.ClientId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_shiporder_detail_shiporder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ClientOrderDetail)
                    .HasForeignKey(d => new { d.ProductCode, d.ClientId })
                    .HasConstraintName("fk_client_order_detail_product");
            });

            modelBuilder.Entity<ClientServiceChargeRate>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.ServiceChargeCode });

                entity.ToTable("client_service_charge_rate");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceChargeCode)
                    .HasColumnName("service_charge_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClientServiceRateCharge>(entity =>
            {
                entity.HasKey(e => new { e.BeginDate, e.EndDate, e.ClientId, e.ServiceChargeCode, e.TransportServiceProvider })
                    .HasName("PK_client_service_rate_charge_1");

                entity.ToTable("client_service_rate_charge");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceChargeCode)
                    .HasColumnName("service_charge_code")
                    .HasMaxLength(50);

                entity.Property(e => e.TransportServiceProvider)
                    .HasColumnName("transport_service_provider")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.DestinationId)
                    .HasColumnName("Destination_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OriginId)
                    .HasColumnName("Origin_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerCode, e.ClientId });

                entity.ToTable("customer");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerAddressLine1)
                    .HasColumnName("customer_address_line1")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerAddressLine2)
                    .HasColumnName("customer_address_line2")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerAddressLine3)
                    .HasColumnName("customer_address_line3")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerType)
                    .HasColumnName("customer_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerZone>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.ZoneName })
                    .HasName("PK_customer_zone_1");

                entity.ToTable("customer_zone");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ZoneName)
                    .HasColumnName("zone_name")
                    .HasMaxLength(50);

                entity.Property(e => e.QtyTariff)
                    .HasColumnName("qty_tariff")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VolumeTariff)
                    .HasColumnName("volume_tariff")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightTariff)
                    .HasColumnName("weight_tariff")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DeliveryIncident>(entity =>
            {
                entity.HasKey(e => e.IncidentCode);

                entity.ToTable("delivery_incident");

                entity.Property(e => e.IncidentCode)
                    .HasColumnName("incident_code")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DistributionAlias>(entity =>
            {
                entity.HasKey(e => new { e.ShipToName, e.ChannelId });

                entity.ToTable("distribution_alias");

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(200);

                entity.Property(e => e.ChannelId)
                    .HasColumnName("channel_id")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.DistrictCode);

                entity.ToTable("district");

                entity.HasIndex(e => e.ProvinceCode)
                    .HasName("IX_province_code");

                entity.Property(e => e.DistrictCode)
                    .HasColumnName("district_code")
                    .HasMaxLength(50);

                entity.Property(e => e.AmphurCode)
                    .HasColumnName("amphur_code")
                    .HasMaxLength(50);

                entity.Property(e => e.EnglishName)
                    .HasColumnName("english_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasMaxLength(50);

                entity.HasOne(d => d.AmphurCodeNavigation)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.AmphurCode)
                    .HasConstraintName("FK_district_amphur");

                entity.HasOne(d => d.PostalCodeNavigation)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.PostalCode)
                    .HasConstraintName("FK_district_Thailand_postal_code");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.ProvinceCode)
                    .HasConstraintName("FK_district_province");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("holiday");

                entity.Property(e => e.HolDate)
                    .HasColumnName("HOL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.HolEndesc)
                    .HasColumnName("HOL_ENDESC")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HolThdesc)
                    .HasColumnName("HOL_THDESC")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HolYear).HasColumnName("HOL_YEAR");
            });

            modelBuilder.Entity<OrderDate>(entity =>
            {
                entity.HasKey(e => new { e.OrderNumber, e.DateType, e.ClientId })
                    .HasName("PK__OrderDate__15502E78");

                entity.ToTable("order_date");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateType)
                    .HasColumnName("date_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ChangedDate)
                    .HasColumnName("changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTypeDate)
                    .HasColumnName("date_type_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTypeTime)
                    .HasColumnName("date_type_time")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ClientOrder)
                    .WithMany(p => p.OrderDateNavigation)
                    .HasForeignKey(d => new { d.OrderNumber, d.ClientId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_date_client_order");
            });

            modelBuilder.Entity<OrderEvent>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.OrderNumber, e.EventType, e.EventDate, e.EventTime })
                    .HasName("PK_OrderEvent_1");

                entity.ToTable("order_event");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EventType)
                    .HasColumnName("event_type")
                    .HasMaxLength(50);

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventTime)
                    .HasColumnName("event_time")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EventDescription)
                    .HasColumnName("event_description")
                    .HasMaxLength(50);

                entity.Property(e => e.LocalEventDate)
                    .HasColumnName("local_event_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalEventTime)
                    .HasColumnName("local_event_time")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ClientOrder)
                    .WithMany(p => p.OrderEvent)
                    .HasForeignKey(d => new { d.OrderNumber, d.ClientId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_order_event_client_order");
            });

            modelBuilder.Entity<OrderFileStaging>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNumber, e.ClientId, e.ProductCode, e.Qty, e.OrderDate, e.Destination })
                    .HasName("PK_transport_memo");

                entity.ToTable("order_file_staging");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(6);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.ActualQty)
                    .HasColumnName("actual_qty")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line1")
                    .HasMaxLength(200);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line2")
                    .HasMaxLength(200);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerPickup)
                    .HasColumnName("customer_pickup")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(200);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsImportedToOrder)
                    .HasColumnName("is_imported_to_order")
                    .HasMaxLength(10);

                entity.Property(e => e.LoadedDate)
                    .HasColumnName("loaded_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoadedQty)
                    .HasColumnName("loaded_qty")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PodReceivedDate)
                    .HasColumnName("pod_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(200);

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderInstruction>(entity =>
            {
                entity.HasKey(e => new { e.WmspOrder, e.Storer })
                    .HasName("PK__OrderIns__A51F2E5A1ED998B2");

                entity.Property(e => e.WmspOrder).HasColumnName("wmspOrder");

                entity.Property(e => e.Storer)
                    .HasColumnName("storer")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instruction).HasColumnType("text");
            });

            modelBuilder.Entity<OrderNote>(entity =>
            {
                entity.HasKey(e => new { e.OrderNumber, e.Sequence, e.ClientId })
                    .HasName("PK_OrderNote");

                entity.ToTable("order_note");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedDate)
                    .HasColumnName("changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoteType)
                    .IsRequired()
                    .HasColumnName("note_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteValue)
                    .HasColumnName("note_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderReference>(entity =>
            {
                entity.HasKey(e => new { e.Storer, e.WmspOrder, e.Sequence });

                entity.ToTable("orderReference");

                entity.Property(e => e.Storer)
                    .HasColumnName("storer")
                    .HasMaxLength(10);

                entity.Property(e => e.WmspOrder)
                    .HasColumnName("WMSpOrder")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.RefQualifier)
                    .HasColumnName("ref_qualifier")
                    .HasMaxLength(50);

                entity.Property(e => e.RefValue)
                    .HasColumnName("ref_value")
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<OrderServiceType>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeName);

                entity.ToTable("order_service_type");

                entity.Property(e => e.ServiceTypeName)
                    .HasColumnName("service_type_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.HasKey(e => e.OrderTypeCode);

                entity.ToTable("order_type");

                entity.Property(e => e.OrderTypeCode)
                    .HasColumnName("order_type_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("place");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Amphur)
                    .HasColumnName("amphur")
                    .HasMaxLength(50);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceTh)
                    .HasColumnName("province_th")
                    .HasMaxLength(100);

                entity.Property(e => e.Tombol)
                    .HasColumnName("tombol")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PlaceClientZoneAssociation>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.ZoneId, e.ClientId });

                entity.ToTable("place_client_zone_association");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zone_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.PlaceClientZoneAssociation)
                    .HasForeignKey(d => d.ZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_place_client_zone_association_client_defined_zone");
            });

            modelBuilder.Entity<PodGrouping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pod_grouping");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(6);

                entity.Property(e => e.PodGroup)
                    .HasColumnName("pod_group")
                    .HasMaxLength(50);

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PodHeader>(entity =>
            {
                entity.HasKey(e => e.PodToSender);

                entity.ToTable("pod_header");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(6);

                entity.Property(e => e.PodGroup)
                    .HasColumnName("pod_group")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => new { e.ProductCode, e.ClientId })
                    .HasName("PK__product__0BC6C43E");

                entity.ToTable("product");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CartonSize)
                    .HasColumnName("carton_size")
                    .HasMaxLength(50);

                entity.Property(e => e.Cbm)
                    .HasColumnName("cbm")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChangedDate)
                    .HasColumnName("changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("division_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCategory)
                    .HasColumnName("product_category")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.ProductLifeCycle)
                    .HasColumnName("product_life_cycle")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.ProductType)
                    .HasColumnName("product_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("short_description")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductUom>(entity =>
            {
                entity.HasKey(e => new { e.Storer, e.ProductCode, e.Uom });

                entity.ToTable("product_uom");

                entity.Property(e => e.Storer)
                    .HasColumnName("storer")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("change_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("change_time")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InvQty)
                    .HasColumnName("inv_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubQty)
                    .HasColumnName("sub_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubUom)
                    .HasColumnName("sub_uom")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectCode);

                entity.ToTable("project");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasMaxLength(8);

                entity.Property(e => e.DefaultTripType)
                    .HasColumnName("default_trip_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.LastTlpNumber)
                    .HasColumnName("last_tlp_number")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthlyLastOrderNumber).HasColumnName("monthly_last_order_number");

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectLastTruckOrderNumber).HasColumnName("project_last_truck_order_number");

                entity.Property(e => e.TruckOrderPrefix)
                    .HasColumnName("truck_order_prefix")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProjectClient>(entity =>
            {
                entity.HasKey(e => new { e.ProjectCode, e.ClientId })
                    .HasName("PK_project_storer");

                entity.ToTable("project_client");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasMaxLength(8);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.ProjectClient)
                    .HasForeignKey(d => d.ProjectCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_storer_project");
            });

            modelBuilder.Entity<ProjectGsin>(entity =>
            {
                entity.HasKey(e => e.ProjectCode);

                entity.ToTable("project_gsin");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasMaxLength(8);

                entity.Property(e => e.DefaultTripType)
                    .HasColumnName("default_trip_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.LastTlpNumber)
                    .HasColumnName("last_tlp_number")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthlyLastOrderNumber).HasColumnName("monthly_last_order_number");

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectLastTruckOrderNumber).HasColumnName("project_last_truck_order_number");

                entity.Property(e => e.TruckOrderPrefix)
                    .HasColumnName("truck_order_prefix")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProjectUser>(entity =>
            {
                entity.HasKey(e => new { e.ProjectCode, e.UserId });

                entity.ToTable("project_user");

                entity.Property(e => e.ProjectCode)
                    .HasColumnName("project_code")
                    .HasMaxLength(8);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8);

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.ProjectUser)
                    .HasForeignKey(d => d.ProjectCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_user_project");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_project_user_user_profile");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceCode);

                entity.ToTable("province");

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasMaxLength(50);

                entity.Property(e => e.EnglishName)
                    .HasColumnName("english_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QuantityRateCost>(entity =>
            {
                entity.HasKey(e => new { e.StorerCode, e.OriginId, e.DestinationId, e.VehicleTypeCode });

                entity.ToTable("quantity_rate_cost");

                entity.Property(e => e.StorerCode)
                    .HasColumnName("storer_code")
                    .HasMaxLength(6);

                entity.Property(e => e.OriginId)
                    .HasColumnName("Origin_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationId)
                    .HasColumnName("Destination_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ReceiptEntity>(entity =>
            {
                entity.HasKey(e => new { e.ReceiptNumber, e.ClientId })
                    .HasName("PK__Receipt___D20C513651300E55");

                entity.ToTable("Receipt_entity");

                entity.Property(e => e.ReceiptNumber)
                    .HasColumnName("receipt_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ChangedDate)
                    .HasColumnName("changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress1)
                    .HasColumnName("ship_to_address1")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToAddress2)
                    .HasColumnName("ship_to_address2")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToCity)
                    .HasColumnName("ship_to_city")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountry)
                    .HasColumnName("ship_to_country")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToName1)
                    .HasColumnName("ship_to_name1")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToName2)
                    .HasColumnName("ship_to_name2")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToName3)
                    .HasColumnName("ship_to_name3")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToPostalCode)
                    .HasColumnName("ship_to_postal_code")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceChargeByVehicleType>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.ChargeCode, e.VehicleTypeCode });

                entity.ToTable("service_charge_by_vehicle_type");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ChargeCode)
                    .HasColumnName("charge_code")
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Deecription)
                    .HasColumnName("deecription")
                    .HasMaxLength(250);

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SkyfrogUser>(entity =>
            {
                entity.HasKey(e => e.SkyfrogId);

                entity.ToTable("skyfrog_user");

                entity.Property(e => e.SkyfrogId)
                    .HasColumnName("skyfrog_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CarLicense)
                    .HasColumnName("Car_license")
                    .HasMaxLength(50);

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Project)
                    .HasColumnName("project")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ThailandLocation>(entity =>
            {
                entity.HasKey(e => new { e.LocationCode, e.Location });

                entity.ToTable("Thailand_location");

                entity.Property(e => e.LocationCode).HasColumnName("location_code");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.Amphur).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50);

                entity.Property(e => e.Tambol).HasMaxLength(50);
            });

            modelBuilder.Entity<ThailandPostalCode>(entity =>
            {
                entity.HasKey(e => e.PostalCode);

                entity.ToTable("Thailand_postal_code");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransportServiceProvider>(entity =>
            {
                entity.HasKey(e => e.TransportServiceProvider1);

                entity.ToTable("transport_service_provider");

                entity.Property(e => e.TransportServiceProvider1)
                    .HasColumnName("transport_service_provider")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TripRateChargeDetail>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.OriginId, e.BeginDate, e.EndDate, e.DestinationId, e.VehicleTypeCode, e.TransportServiceProvider })
                    .HasName("PK_Trip_rate_cost_1");

                entity.ToTable("Trip_rate_charge_detail");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(8);

                entity.Property(e => e.OriginId)
                    .HasColumnName("Origin_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestinationId)
                    .HasColumnName("Destination_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_code")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportServiceProvider)
                    .HasColumnName("transport_service_provider")
                    .HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.TripRateChargeHeader)
                    .WithMany(p => p.TripRateChargeDetail)
                    .HasForeignKey(d => new { d.ClientId, d.OriginId, d.BeginDate, d.EndDate })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trip_rate_cost_trip_rate_cost_header");
            });

            modelBuilder.Entity<TripRateChargeHeader>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.OriginId, e.BeginDate, e.EndDate })
                    .HasName("PK_trip_rate_cost_header");

                entity.ToTable("trip_rate_charge_header");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(8);

                entity.Property(e => e.OriginId)
                    .HasColumnName("origin_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Truck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("truck");

                entity.Property(e => e.Driver)
                    .HasColumnName("driver")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("truck_license")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TruckDriver>(entity =>
            {
                entity.HasKey(e => e.Driver);

                entity.ToTable("truck_driver");

                entity.Property(e => e.Driver)
                    .HasColumnName("driver")
                    .HasMaxLength(50);

                entity.Property(e => e.DriverName)
                    .HasColumnName("driver_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TruckLoad>(entity =>
            {
                entity.HasKey(e => e.TruckOrder);

                entity.HasIndex(e => e.Etd)
                    .HasName("x_etd");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.AppointmentFlag)
                    .HasColumnName("appointment_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BillingStatus)
                    .HasColumnName("billing_status")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CarLicense)
                    .HasColumnName("car_License")
                    .HasMaxLength(50);

                entity.Property(e => e.Cbm)
                    .HasColumnName("CBM")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closed_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryInstruction)
                    .HasColumnName("delivery_instruction")
                    .HasMaxLength(250);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DriverPhone)
                    .HasColumnName("Driver_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Etd)
                    .HasColumnName("etd")
                    .HasColumnType("datetime");

                entity.Property(e => e.GsinCode)
                    .HasColumnName("gsin_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .HasColumnName("job_type")
                    .HasMaxLength(100);

                entity.Property(e => e.LoadedDate)
                    .HasColumnName("loaded_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberOfDropPoints).HasColumnName("number_of_drop_points");

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50);

                entity.Property(e => e.PodReturnDate)
                    .HasColumnName("POD_return_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Project)
                    .HasColumnName("project")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectTruckOrder).HasColumnName("project_truck_order");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("Reference_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Revenue)
                    .HasColumnName("revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(8);

                entity.Property(e => e.SkyfrogId)
                    .HasColumnName("skyfrog_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TlpNumber)
                    .HasColumnName("TLP_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ToTrackingSystem)
                    .HasColumnName("to_tracking_system")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalQty)
                    .HasColumnName("total_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalTrip).HasColumnName("total_trip");

                entity.Property(e => e.TransportServiceProvider)
                    .HasColumnName("transport_service_provider")
                    .HasMaxLength(50);

                entity.Property(e => e.TripType)
                    .HasColumnName("trip_type")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.VehicleTypeCodeNavigation)
                    .WithMany(p => p.TruckLoad)
                    .HasForeignKey(d => d.VehicleTypeCode)
                    .HasConstraintName("FK_truckload_vehicle_type");
            });

            modelBuilder.Entity<TruckLoadDetail>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.Line });

                entity.ToTable("TruckLoad_Detail");

                entity.HasIndex(e => new { e.ClientId, e.OrderNumber, e.OrderLine })
                    .HasName("x_client_order_detail");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.ActualQuantity)
                    .HasColumnName("actual_quantity")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("Address_line1")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("Address_line2")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cbm)
                    .HasColumnName("CBM")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPo)
                    .HasColumnName("customer_po")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveredDate)
                    .HasColumnName("delivered_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryQuantity)
                    .HasColumnName("delivery_quantity")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(50);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GsinCode)
                    .HasColumnName("gsin_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderLine)
                    .HasColumnName("order_line")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ParcelType)
                    .HasColumnName("parcel_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PickupDate)
                    .HasColumnName("pickup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickupQty)
                    .HasColumnName("pickup_qty")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PodReceiveDate)
                    .HasColumnName("POD_receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToCustomerDate)
                    .HasColumnName("POD_to_customer_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductStorer)
                    .HasColumnName("product_storer")
                    .HasMaxLength(6);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RejectReason)
                    .HasColumnName("Reject_reason")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.ReturnQuantity)
                    .HasColumnName("return_quantity")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SenderOrder)
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(10);

                entity.HasOne(d => d.TruckOrderNavigation)
                    .WithMany(p => p.TruckLoadDetail)
                    .HasForeignKey(d => d.TruckOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_truckload_detail_truckload");

                entity.HasOne(d => d.ClientOrderDetail)
                    .WithMany(p => p.TruckLoadDetail)
                    .HasForeignKey(d => new { d.OrderNumber, d.ClientId, d.OrderLine })
                    .HasConstraintName("fk_truckload_detail_client_order_detail");
            });

            modelBuilder.Entity<TruckloadCharge>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.ChargeType });

                entity.ToTable("truckload_charge");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.ChargeType)
                    .HasColumnName("charge_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeUnit)
                    .HasColumnName("charge_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Revenue)
                    .HasColumnName("revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.TruckOrderNavigation)
                    .WithMany(p => p.TruckloadCharge)
                    .HasForeignKey(d => d.TruckOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_truckload_charge_TruckLoad");
            });

            modelBuilder.Entity<TruckloadCity>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.City });

                entity.ToTable("truckload_city");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TruckloadDropPoint>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.DropNumber });

                entity.ToTable("truckload_drop_point");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.DropNumber).HasColumnName("drop_number");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.NumberOfOrder)
                    .HasColumnName("number_of_order")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QtyByCarton)
                    .HasColumnName("qty_by_carton")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.TruckOrderNavigation)
                    .WithMany(p => p.TruckloadDropPoint)
                    .HasForeignKey(d => d.TruckOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_truckload_drop_point_TruckLoad");
            });

            modelBuilder.Entity<TruckloadDropPointDetail>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.DropNumber, e.Sequence });

                entity.ToTable("truckload_drop_point_detail");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.DropNumber).HasColumnName("drop_number");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.IncidentCode)
                    .HasColumnName("incident_code")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.PodReceivedDate)
                    .HasColumnName("pod_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SenderOrder)
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentType)
                    .HasColumnName("source_document_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.TruckloadDropPoint)
                    .WithMany(p => p.TruckloadDropPointDetail)
                    .HasForeignKey(d => new { d.TruckOrder, d.DropNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_truckload_drop_point_detail_truckload_drop_point");
            });

            modelBuilder.Entity<TruckloadExtracharge>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.ChargeType });

                entity.ToTable("truckload_extracharge");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.ChargeType)
                    .HasColumnName("charge_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Revenue)
                    .HasColumnName("revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.TruckOrderNavigation)
                    .WithMany(p => p.TruckloadExtracharge)
                    .HasForeignKey(d => d.TruckOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_truckload_extracharge_TruckLoad");
            });

            modelBuilder.Entity<TruckloadSenderOrder>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.Sequence });

                entity.ToTable("truckload_sender_order");

                entity.HasIndex(e => e.TrackingCode)
                    .HasName("x_trackingCode");

                entity.HasIndex(e => new { e.ClientId, e.OrderNumber })
                    .HasName("x_client_order");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PodReceivedDate)
                    .HasColumnName("pod_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SenderOrder)
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipmentNumber).HasColumnName("shipment_number");

                entity.Property(e => e.SourceDocumentType)
                    .HasColumnName("source_document_type")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialNote)
                    .HasColumnName("special_note")
                    .HasMaxLength(200);

                entity.Property(e => e.TrackingCode)
                    .HasColumnName("tracking_code")
                    .HasMaxLength(50);

                entity.Property(e => e.TrackingNumber).HasColumnName("tracking_number");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.TruckOrderNavigation)
                    .WithMany(p => p.TruckloadSenderOrder)
                    .HasForeignKey(d => d.TruckOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_truckload_sender_order_TruckLoad");

                entity.HasOne(d => d.ClientOrder)
                    .WithMany(p => p.TruckloadSenderOrder)
                    .HasForeignKey(d => new { d.OrderNumber, d.ClientId })
                    .HasConstraintName("FK_truckload_sender_order_client_order");
            });

            modelBuilder.Entity<TruckloadService>(entity =>
            {
                entity.HasKey(e => new { e.TruckOrder, e.ServiceType });

                entity.ToTable("truckload_service");

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Revenue)
                    .HasColumnName("revenue")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<UserOrigin>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Origin });

                entity.ToTable("user_origin");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("user_profile");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLastName)
                    .HasColumnName("user_last_name")
                    .HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("user_role");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserRole)
                    .HasForeignKey<UserRole>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_role_user_profile");
            });

            modelBuilder.Entity<UserStorer>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Storer });

                entity.ToTable("user_storer");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Storer)
                    .HasColumnName("storer")
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VOrderInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vOrderInformation");

                entity.Property(e => e.AppointmentFlag)
                    .HasColumnName("appointment_flag")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CancelledDate)
                    .HasColumnName("cancelled_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmShipDate)
                    .HasColumnName("confirm_ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerPickup)
                    .HasColumnName("customer_pickup")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.LoadedDate)
                    .HasColumnName("loaded_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PickAssignedDate)
                    .HasColumnName("pick_assigned_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodReceivedDate)
                    .HasColumnName("pod_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.Project)
                    .HasColumnName("project")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseToPickDate)
                    .HasColumnName("release_to_pick_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.SenderOrder)
                    .IsRequired()
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName1)
                    .HasColumnName("ship_to_Name1")
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TotalQty)
                    .HasColumnName("total_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("Total_volume")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TripType)
                    .HasColumnName("trip_type")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<VProductBarcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductBarcode");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasColumnName("product_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VclientOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vclient_order");

                entity.Property(e => e.AppointmentFlag)
                    .HasColumnName("appointment_flag")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CancelledDate)
                    .HasColumnName("cancelled_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("change_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientCustomerId)
                    .HasColumnName("client_customer_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPickup)
                    .HasColumnName("customer_pickup")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CustomerPo)
                    .HasColumnName("Customer_po")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerReceivedDate)
                    .HasColumnName("customer_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryDays).HasColumnName("delivery_days");

                entity.Property(e => e.DeliveryStatus)
                    .HasColumnName("delivery_status")
                    .HasMaxLength(10);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.LoadedDate)
                    .HasColumnName("loaded_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumberOfOrderLines)
                    .HasColumnName("Number_of_Order_Lines")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NumberOfShipment).HasColumnName("number_of_shipment");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderType)
                    .HasColumnName("order_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PickAssignedDate)
                    .HasColumnName("pick_assigned_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickupType)
                    .HasColumnName("pickup_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PodEnterDate)
                    .HasColumnName("pod_enter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodGroup)
                    .HasColumnName("pod_group")
                    .HasMaxLength(50);

                entity.Property(e => e.PodReceivedDate)
                    .HasColumnName("pod_received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToSender)
                    .HasColumnName("pod_to_sender")
                    .HasColumnType("datetime");

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.RevisedDueDate)
                    .HasColumnName("revised_due_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevisedDueDateReason)
                    .HasColumnName("revised_due_date_reason")
                    .HasMaxLength(100);

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(50);

                entity.Property(e => e.SenderOrder)
                    .IsRequired()
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress1)
                    .HasColumnName("Ship_To_Address1")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToAddress2)
                    .HasColumnName("Ship_To_Address2")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipToCity)
                    .HasColumnName("Ship_To_City")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToCountryCode)
                    .HasColumnName("Ship_To_Country_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName1)
                    .HasColumnName("ship_to_Name1")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToName2)
                    .HasColumnName("Ship_to_Name2")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToName3)
                    .HasColumnName("Ship_To_Name3")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToPostalCode)
                    .HasColumnName("Ship_To_Postal_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToState)
                    .HasColumnName("Ship_To_State")
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TermOfPayment)
                    .HasColumnName("term_of_payment")
                    .HasMaxLength(50);

                entity.Property(e => e.ToBeRemoved)
                    .HasColumnName("to_be_removed")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TotalShippedQty)
                    .HasColumnName("Total_Shipped_Qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("Total_volume")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TruckBookingDate)
                    .HasColumnName("truck_booking_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VclientOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vclient_order_detail");

                entity.Property(e => e.BatchLot)
                    .HasColumnName("batch_lot")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangedDate)
                    .HasColumnName("changed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChangedTime)
                    .HasColumnName("changed_time")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.DeliveredQty)
                    .HasColumnName("delivered_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Line)
                    .HasColumnName("line")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.LoadedQty)
                    .HasColumnName("loaded_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OrderQty)
                    .HasColumnName("order_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PodEnterDate)
                    .HasColumnName("pod_enter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodIdentfication)
                    .HasColumnName("pod_identfication")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductOwner)
                    .HasColumnName("product_owner")
                    .HasMaxLength(6);

                entity.Property(e => e.RecordStatus)
                    .HasColumnName("record_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(50);

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.HasKey(e => e.VehicleTypeCode);

                entity.ToTable("Vehicle_type");

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("VehicleType_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MaxVolume)
                    .HasColumnName("Max_volume")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxWeight)
                    .HasColumnName("Max_weight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehichleTypeDescription)
                    .HasColumnName("VehichleType_description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VolumeRateChargeHeader>(entity =>
            {
                entity.HasKey(e => new { e.Sender, e.BeginDate, e.EndDate });

                entity.ToTable("volume_rate_charge_header");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(8);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VolumeRateCost>(entity =>
            {
                entity.HasKey(e => new { e.BeginDate, e.EndDate, e.Sender, e.DestinationId })
                    .HasName("PK_volume_rate_cost_1");

                entity.ToTable("volume_rate_cost");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(8);

                entity.Property(e => e.DestinationId)
                    .HasColumnName("Destination_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UrgentPrice)
                    .HasColumnName("Urgent_Price")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VtruckloadDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vtruckload_detail");

                entity.Property(e => e.ActualQuantity)
                    .HasColumnName("actual_quantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("Address_line1")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("Address_line2")
                    .HasMaxLength(255);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cbm)
                    .HasColumnName("CBM")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerPo)
                    .HasColumnName("customer_po")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveredDate)
                    .HasColumnName("delivered_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryQuantity)
                    .HasColumnName("delivery_quantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(50);

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expr1).HasMaxLength(50);

                entity.Property(e => e.Incident)
                    .HasColumnName("incident")
                    .HasMaxLength(255);

                entity.Property(e => e.Invoice)
                    .HasColumnName("invoice")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderLine)
                    .HasColumnName("order_line")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ParcelType)
                    .HasColumnName("parcel_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PickupDate)
                    .HasColumnName("pickup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickupQty)
                    .HasColumnName("pickup_qty")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PodReceiveDate)
                    .HasColumnName("POD_receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PodToCustomerDate)
                    .HasColumnName("POD_to_customer_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductStorer)
                    .HasColumnName("product_storer")
                    .HasMaxLength(6);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RejectReason)
                    .HasColumnName("Reject_reason")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarkDelivery)
                    .HasColumnName("remark_delivery")
                    .HasMaxLength(255);

                entity.Property(e => e.ReturnQuantity)
                    .HasColumnName("return_quantity")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SenderOrder)
                    .HasColumnName("sender_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceType)
                    .HasColumnName("service_type")
                    .HasMaxLength(50);

                entity.Property(e => e.TruckOrder).HasColumnName("truck_order");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.HasKey(e => e.DistrictCode);

                entity.ToTable("zip_code");

                entity.Property(e => e.DistrictCode)
                    .HasColumnName("district_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("postal_code")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
