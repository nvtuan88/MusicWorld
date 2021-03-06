﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using System;

namespace Admin.Models
{
    public static class SeedData
    {
        public static void SeedDataMusic(IApplicationBuilder app)
        {
            StoreDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            

            if (!context.Authors.Any())
            {
                context.Authors.AddRange(
                    new Author
                    {
                        AuthorName = "Teddy",
                        AuthorImg = "https://file.tinnhac.com/resize/600x-/music/2017/09/06/2700ve1453099589-bdc3.jpg",
                        DescriptionAuthor = "Teddy Park (sinh ngày 14 tháng 9 năm 1978) là một rapper, nhạc sĩ và nhà sản xuất thu âm người Mỹ gốc Hàn, nhà sản xuất nội bộ cho YG Entertainment."
                    },
                    new Author
                    {
                        AuthorName = "Đen Vâu",
                        AuthorImg = "https://image.phunuonline.com.vn/news/2017/20171107/thumbnail/750x450/115656_tieu-su-rapper-den-vau-nguyen-duc-cuong-6189-7620792.jpg",
                        DescriptionAuthor = "Đen Vâu (sinh ngày 13 tháng 5 năm 1989) hay Đen là một nam rapper và nhạc sĩ người Việt Nam là một trong số ít nghệ sĩ thành công từ làn sóng underground và âm nhạc indie của Việt Nam."
                    },
                    new Author
                    {
                        AuthorName = "Khắc Hưng",
                        AuthorImg = "https://cdn.pose.com.vn/assets/2018/10/khac_hung_1.jpg",
                        DescriptionAuthor = "Khắc Hưng tên đầy đủ là Nguyễn Khắc Hưng, còn có nghệ danh KHÙNG (sinh ngày 12 tháng 12 năm 1992 tại Yên Bái) là một nhà sản xuất âm nhạc, nhạc sĩ, ca sĩ người Việt Nam."
                    },
                    new Author
                    {
                        AuthorName = "Tiên Cookie",
                        AuthorImg = "https://znews-photo.zadn.vn/w660/Uploaded/wyhktpu/2017_07_10/TienCookieslaaivagioitinhthatcuaTienCookies26e1471310307404.jpg",
                        DescriptionAuthor = "Tiên Cookie, tên thật là Nguyễn Thủy Tiên (sinh ngày 26 tháng 2 năm 1994) là nhạc sĩ, ca sĩ, nhà sản xuất âm nhạc của Việt Nam."
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Singers.Any())
            {
                context.Singers.AddRange(
                    
                    new Singer
                    {
                        SingerName = "BlackPink",
                        SingerImg = "https://cuoifly.tuoitre.vn/1200/900/ttc/r/2020/10/15/blackpink-1602732852-16x9.jpg",
                        DescriptionSinger = "BlackPink(BLΛƆKPIИK) là một nhóm nhạc nữ Hàn Quốc do công ty YG Entertainment thành lập và quản lý. Nhóm gồm 4 thành viên Jisoo, Jennie, Rosé, Lisa. Blackpink chính thức ra mắt với đĩa mở rộng đầu tay mang tên Square One gồm hai ca khúc 'Boombayah' và 'Whistle' vào năm 2016"
                    },
                    new Singer
                    {
                        SingerName = "Min",
                        SingerImg = "https://static2.yan.vn/YanNews/2167221/201905/tieu-su-su-nghiep-va-cuoc-doi-cua-ca-si-min-f0ea35dc.jpg",
                        DescriptionSinger = "Min (sinh ngày 7 tháng 12 năm 1988) là một nữ ca sĩ, vũ công và nhà sản xuất âm nhạc người Việt Nam. Sau một thời gian được biết đến với tư cách là thành viên của nhóm nhảy St.319 (tiền thân của công ty giải trí St.319 Entertainment), cô ra mắt với tư cách ca sĩ solo vào năm 2013 với đĩa đơn đầu tay 'Tìm'"
                    },
                    new Singer
                    {
                        SingerName = "Trúc Nhân",
                        SingerImg = "https://avatar-nct.nixcdn.com/singer/avatar/2019/08/19/3/e/8/c/1566179852233_600.jpg",
                        DescriptionSinger = "Trúc Nhân (sinh ngày 30 tháng 11 năm 1991) là một nam ca sĩ người Việt Nam. Anh được biết đến khi tham gia chương trình Giọng hát Việt mùa đầu tiên"
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Albums.Any())
            {
                context.Albums.AddRange(
                    new Album
                    {
                        AlbumName = "The Album",
                        Image = "/images/The Album-BlackPink.jpg"
                    },
                    new Album
                    {
                        AlbumName = "Min Collection",
                        Image = "/images/TTBDTY-Min.jpg"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Musics.Any())
            {
                context.Musics.AddRange(
                        new Musics
                        {
                            Name = "How You Like That",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Ice Cream",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Pretty Savage",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Bet You Wanna",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 3,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Lovesick Girls",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Crazy Over You",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 4,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Love To Hate Me",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "You Never Know",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },

                        new Musics
                        {
                            Name = "Trên Tình Bạn Dưới Tình Yêu",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Đừng Yêu Nữa, Em Mệt Rồi",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Đừng Xin Lỗi Nữa",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Em Mới Là Người Yêu Anh",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Người Em Tìm Kiếm",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 4,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Có Em Chờ",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 1,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Hôn Anh",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 4,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Ghen",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Sáng Mắt Chưa",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 4,
                            SingerId = 3,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Bài Này Chill Phết",
                            Url = "/Media/Hoa-Hai-Duong-Jack.mp3",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        }

                    );
                context.SaveChanges();
            }

        }
    }
}
