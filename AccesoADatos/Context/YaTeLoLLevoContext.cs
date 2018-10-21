namespace AccesoADatos
{
    using AccesoADatos.Modelo;
    using System;
    using System.Collections.Concurrent;
    using System.Configuration;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;

    public class YaTeLoLLevoContext : DbContext
    {
        // Your context has been configured to use a 'YaTeLoLLevoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AccesoADatos.YaTeLoLLevoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'YaTeLoLLevoContext' 
        // connection string in the application configuration file.
        /*public YaTeLoLLevoContext()
            : base("name=YaTeLoLLevoContext")
        {
        }*/
        private YaTeLoLLevoContext(DbConnection connection, DbCompiledModel model)
    : base(connection, model, contextOwnsConnection: true)
        {
            Database.SetInitializer<YaTeLoLLevoContext>(null);
            //base.OnModelCreating(model);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminTienda> AdminTiendas { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<EstadoOrden> EstadoOrdenes { get; set; }
        public DbSet<LineaVenta> LineasVenta { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }

        private static ConcurrentDictionary<Tuple<string, string>, DbCompiledModel> modelCache
            = new ConcurrentDictionary<Tuple<string, string>, DbCompiledModel>();

        public static YaTeLoLLevoContext Create(string tenantSchema/*, DbConnection connection*/)
        {
            DbConnection connection = new SqlConnection(@ConfigurationManager.ConnectionStrings["YaTeLoLLevoContext"].ConnectionString);
            var compiledModel = modelCache.GetOrAdd(
                Tuple.Create(connection.ConnectionString, tenantSchema),
                t =>
                {
                    var builder = new DbModelBuilder();
                    builder.Conventions.Remove<IncludeMetadataConvention>();
                    builder.Entity<Usuario>().ToTable("Usuarios", tenantSchema);
                    builder.Entity<Admin>().ToTable("Admins", tenantSchema);
                    builder.Entity<AdminTienda>().ToTable("AdminTiendas", tenantSchema);
                    builder.Entity<Carrito>().ToTable("Carritos", tenantSchema);
                    builder.Entity<Cliente>()
                        .HasMany<Tienda>(c => c.Tiendas)
                        .WithMany(ti => ti.Clientes)
                        .Map(tc =>
                                    {
                                        tc.MapLeftKey("ClienteRefId");
                                        tc.MapRightKey("TiendaRefId");
                                        tc.ToTable("ClienteTienda", tenantSchema);
                                    }
                        );
                    builder.Entity<Comentario>().ToTable("Comentarios", tenantSchema);
                    builder.Entity<Delivery>().ToTable("Deliveries", tenantSchema);
                    builder.Entity<EstadoOrden>().ToTable("EstadoOrdenes", tenantSchema);
                    builder.Entity<LineaVenta>().ToTable("LineasVenta", tenantSchema);
                    builder.Entity<Orden>().ToTable("Ordenes", tenantSchema);
                    builder.Entity<Pedido>().ToTable("Pedidos", tenantSchema);
                    builder.Entity<Producto>().ToTable("Productos", tenantSchema);
                    builder.Entity<Tienda>().ToTable("Tiendas", tenantSchema);
                    //    builder.HasDefaultSchema(tenantSchema);

                    var model = builder.Build(connection);
                    return model.Compile();
                });

            return new YaTeLoLLevoContext(connection, compiledModel);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<YaTeLoLLevoContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public static void ProvisionTenant(string tenantSchema/*, DbConnection connection*/)
        {
            using (var ctx = Create(tenantSchema/*, connection*/))
            {
                if (!ctx.Database.Exists())
                {
                    ctx.Database.Create();
                }
                else
                {
                    var createScript = ((IObjectContextAdapter)ctx).ObjectContext.CreateDatabaseScript();
                    ctx.Database.ExecuteSqlCommand(createScript);
                }
            }
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}