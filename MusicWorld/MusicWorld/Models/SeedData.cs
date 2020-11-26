using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using System;

namespace MusicWorld.Models
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
                        DescriptionAuthor = "Teddy Park (sinh ngày 14 tháng 9 năm 1978) là một rapper, nhạc sĩ và nhà sản xuất thu âm người Mỹ gốc Hàn, nhà sản xuất nội bộ cho YG Entertainment."
                    },
                    new Author
                    {
                        AuthorName = "Đen Vâu",
                        DescriptionAuthor = "Đen Vâu (sinh ngày 13 tháng 5 năm 1989) hay Đen là một nam rapper và nhạc sĩ người Việt Nam là một trong số ít nghệ sĩ thành công từ làn sóng underground và âm nhạc indie của Việt Nam."
                    },
                    new Author
                    {
                        AuthorName = "Khắc Hưng",
                        DescriptionAuthor = "Khắc Hưng tên đầy đủ là Nguyễn Khắc Hưng, còn có nghệ danh KHÙNG (sinh ngày 12 tháng 12 năm 1992 tại Yên Bái) là một nhà sản xuất âm nhạc, nhạc sĩ, ca sĩ người Việt Nam."
                    },
                    new Author
                    {
                        AuthorName = "Tiên Cookie",
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
                        DescriptionSinger = "BlackPink(BLΛƆKPIИK) là một nhóm nhạc nữ Hàn Quốc do công ty YG Entertainment thành lập và quản lý. Nhóm gồm 4 thành viên Jisoo, Jennie, Rosé, Lisa. Blackpink chính thức ra mắt với đĩa mở rộng đầu tay mang tên Square One gồm hai ca khúc 'Boombayah' và 'Whistle' vào năm 2016"
                    },
                    new Singer
                    {
                        SingerName = "Min",
                        DescriptionSinger = "Min (sinh ngày 7 tháng 12 năm 1988) là một nữ ca sĩ, vũ công và nhà sản xuất âm nhạc người Việt Nam. Sau một thời gian được biết đến với tư cách là thành viên của nhóm nhảy St.319 (tiền thân của công ty giải trí St.319 Entertainment), cô ra mắt với tư cách ca sĩ solo vào năm 2013 với đĩa đơn đầu tay 'Tìm'"
                    },
                    new Singer
                    {
                        SingerName = "Trúc Nhân",
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
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/how-you-like-that-tsvwvsb3q924qw.html",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Ice Cream",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink-selena-gomez/ice-cream-tsvmqmvbq8e82q.html",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Pretty Savage",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/pretty-savage-tsvmccbsq8vvq4.html",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Bet You Wanna",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink-cardi-b/bet-you-wanna-tsvmccbmq8vvq8.html",
                            AuthorId = 3,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Lovesick Girls",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/lovesick-girls-tsvmccb5q8vvqh.html",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Crazy Over You",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/crazy-over-you-tsvmccb7q8vvqt.html",
                            AuthorId = 4,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Love To Hate Me",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/love-to-hate-me-tsvmccb6q8vvqk.html",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "You Never Know",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/you-never-know-tsvmccb3q8vvqw.html",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },

                        new Musics
                        {
                            Name = "Trên Tình Bạn Dưới Tình Yêu",
                            Url = "https://vi.chiasenhac.vn/nghe-album/tren-tinh-ban-duoi-tinh-yeu-single-xss7vwwsqt2994.html",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Đừng Yêu Nữa, Em Mệt Rồi",
                            Url = "https://vi.chiasenhac.vn/mp3/min/dung-yeu-nua-em-met-roi-tsvrzdwsqa1m94.html",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Đừng Xin Lỗi Nữa",
                            Url = "https://vi.chiasenhac.vn/nghe-album/dung-xin-loi-nua-single-xss7q6rbqtekaq.html",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Em Mới Là Người Yêu Anh",
                            Url = "https://vi.chiasenhac.vn/nghe-album/em-moi-la-nguoi-yeu-anh-single-xss7cdmvqtvm82.html",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Người Em Tìm Kiếm",
                            Url = "https://vi.chiasenhac.vn/nghe-album/nguoi-em-tim-kiem-single-xss7tbzdqtfq1m.html",
                            AuthorId = 4,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Có Em Chờ",
                            Url = "https://vi.chiasenhac.vn/mp3/min-mra/co-em-cho-tsvdqrqdqmeaem.html",
                            AuthorId = 1,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Hôn Anh",
                            Url = "https://vi.chiasenhac.vn/nghe-album/hon-anh-single-xssm05scq8nh4v.html",
                            AuthorId = 4,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Ghen",
                            Url = "https://vi.chiasenhac.vn/nghe-album/ghen-single-xssm0q5wq8neh9.html",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Sáng Mắt Chưa",
                            Url = "https://vi.chiasenhac.vn/nghe-album/sang-mat-chua-single-xss7mzs3qt814w.html",
                            AuthorId = 4,
                            SingerId = 3,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Name = "Bài Này Chill Phết",
                            Url = "https://vi.chiasenhac.vn/nghe-album/bai-nay-chill-phet-single-xss7mdvwqt8m29.html",
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
