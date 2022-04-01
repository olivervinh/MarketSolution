using Market.Domain.Catalogs.Models;
using Market.Domain.Orders.Models;
using Market.Domain.Users.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //category
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            Name="Laptop",
                            CreatedDate = DateTime.Now,
                        },
                        new Category()
                        {
                            Name="Mobile",
                            CreatedDate = DateTime.Now,
                        },
                        new Category()
                        {
                            Name="Tivi",
                            CreatedDate = DateTime.Now,
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(new List<Tag>()
                    {
                        new Tag()
                        {
                            Name="technology",
                            CreatedDate = DateTime.Now,
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            FkCategoryId = 1,
                            ImportPrice = 25000000,
                            SellPrice = 27990000,
                            Name="Laptop Asus TUF Gaming FX517ZC",
                            CreatedDate = DateTime.Now,
                            IsActive = true,
                            Description = @"Sở hữu ngoại hình ấn tượng thu hút mọi ánh nhìn cùng hiệu năng mạnh mẽ đến từ laptop CPU thế hệ 12 mới nhất, Asus TUF Gaming FX517ZC i5 12450H (HN077W) là lựa chọn xứng tầm cho mọi nhu cầu chiến game giải trí hay đồ hoạ - kỹ thuật của người dùng.
• Laptop Asus TUF mang hiệu năng vượt trội cho khả năng giải quyết trơn tru các tác vụ phức tạp như thiết kế hình ảnh, render video,... trên các ứng dụng nhà Adobe hay thoả sức chiến các tựa game hot như CS:GO, GTA V,... nhờ trang bị chip Intel Core i5 Alder Lake 12450H cùng card rời NVIDIA RTX 3050, 4 GB.",
                            FkTagId = 1,
                            IsDeleted = false,
                        },
                        new Product()
                        {
                           FkCategoryId = 1,
                            ImportPrice = 15000000,
                            SellPrice = 17990000,
                            Name="Laptop HP Pavilion 15 eg0541TU",
                            CreatedDate = DateTime.Now,
                            IsActive = true,
                            Description = @"Sở hữu ngoại hình ấn tượng thu hút mọi ánh nhìn cùng hiệu năng mạnh mẽ đến từ laptop CPU thế hệ 12 mới nhất, Asus TUF Gaming FX517ZC i5 12450H (HN077W) là lựa chọn xứng tầm cho mọi nhu cầu chiến game giải trí hay đồ hoạ - kỹ thuật của người dùng.
• Laptop Asus TUF mang hiệu năng vượt trội cho khả năng giải quyết trơn tru các tác vụ phức tạp như thiết kế hình ảnh, render video,... trên các ứng dụng nhà Adobe hay thoả sức chiến các tựa game hot như CS:GO, GTA V,... nhờ trang bị chip Intel Core i5 Alder Lake 12450H cùng card rời NVIDIA RTX 3050, 4 GB.",
                            FkTagId = 1,
                            IsDeleted = false,

                        },
                        new Product()
                        {
                             FkCategoryId = 1,
                            ImportPrice = 11000000,
                            SellPrice = 12990000,
                            Name="Laptop Lenovo Ideapad 3 15IML05 i3",
                            CreatedDate = DateTime.Now,
                            IsActive = true,
                            Description = @"SLaptop Lenovo Ideapad 3 15IML05 i3 (81WB01DPVN) mang diện mạo thời thượng cùng hiệu năng ổn định và sở hữu một mức giá phải chăng, là sản phẩm laptop học tập - văn phòng phù hợp với học sinh, sinh viên.",
                            FkTagId = 1,
                            IsDeleted = false,
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.ProductImages.Any())
                {
                    context.ProductImages.AddRange(new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            ImageName="1laptop1.jpg",
                            IsThumbnail = true,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                        new ProductImage()
                        {
                            ImageName="1laptop2.jpg",
                            IsThumbnail = false,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                        new ProductImage()
                        {
                            ImageName="1laptop3.jpg",
                            IsThumbnail = false,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                       new ProductImage()
                        {
                            ImageName="2laptop1.jpg",
                            IsThumbnail = true,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                      new ProductImage()
                        {
                            ImageName="2laptop2.jpg",
                            IsThumbnail = false,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                       new ProductImage()
                        {
                            ImageName="2laptop3.jpg",
                            IsThumbnail = false,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                      new ProductImage()
                        {
                            ImageName="3laptop1.jpg",
                            IsThumbnail = true,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                       new ProductImage()
                        {
                            ImageName="3laptop2.jpg",
                            IsThumbnail = false,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },
                     new ProductImage()
                        {
                            ImageName="3laptop3.jpg",
                            IsThumbnail = true,
                            FkProductId=1,
                            IsDeleted = false,
                            CreatedDate = DateTime.Now,
                        },

                    });
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            FirstName="Trần",
                            LastName = "Quý Vinh",
                            Email="olivervinh@gmail.com",
                            Birthday = DateTime.Parse("20/07/2000"),
                            Role = "Admin",
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            ImagePath = "1user1.jpg",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                             IsDeleted = false,
                        },
                         new User()
                        {
                            FirstName="Trần",
                            LastName = "Chí Nhân",
                            Email="nhan@gmail.com",
                            Birthday = DateTime.Parse("18/04/2010"),
                            Role = "User",
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            ImagePath = "1user2.jpg",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                             IsDeleted = false,
                        },
                    }); ;
                    context.SaveChanges();
                }
                if (!context.Orders.Any())
                {
                    context.Orders.AddRange(new List<Order>()
                    {
                        new Order()
                        {
                          FkUserId = 1,
                          CreatedDate = DateTime.Now,
                          Note = "Ship tới nhà riêng",
                          Status = "Chờ xác nhận",
                          TotalPrice = 48970000,
                           IsDeleted = false,
                        },
                      
                    });
                    context.SaveChanges();
                }
                if (!context.OrderDetails.Any())
                {
                    context.OrderDetails.AddRange(new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            FkOrderId = 1,
                            Quantity=2,
                            CreatedDate = DateTime.Now,
                            FkProductId = 1,
                            TotalItemPrice = 35980000,
                            IsDeleted = false,
                        },
                         new OrderDetail()
                        {
                            FkOrderId = 1,
                            Quantity=1,
                            CreatedDate = DateTime.Now,
                            FkProductId = 2,
                            TotalItemPrice = 12990000,
                            IsDeleted = false,
                        },
                    });
                    context.SaveChanges();
                }
                
            }
        }
    }
}
