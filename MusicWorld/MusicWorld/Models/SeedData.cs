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

            if (!context.Musics.Any())
            {
                context.Musics.AddRange(
                        new Musics
                        {
                            Id = 1,
                            Name = "How You Like That",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/how-you-like-that-tsvwvsb3q924qw.html",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 2,
                            Name = "Ice Cream",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink-selena-gomez/ice-cream-tsvmqmvbq8e82q.html",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 3,
                            Name = "Pretty Savage",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/pretty-savage-tsvmccbsq8vvq4.html",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 4,
                            Name = "Bet You Wanna",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink-cardi-b/bet-you-wanna-tsvmccbmq8vvq8.html",
                            AuthorId = 3,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 5,
                            Name = "Lovesick Girls",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/lovesick-girls-tsvmccb5q8vvqh.html",
                            AuthorId = 1,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 6,
                            Name = "Crazy Over You",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/crazy-over-you-tsvmccb7q8vvqt.html",
                            AuthorId = 4,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 7,
                            Name = "Love To Hate Me",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/love-to-hate-me-tsvmccb6q8vvqk.html",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 8,
                            Name = "You Never Know",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/you-never-know-tsvmccb3q8vvqw.html",
                            AuthorId = 2,
                            SingerId = 1,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },

                        new Musics
                        {
                            Id = 9,
                            Name = "Trên Tình Bạn Dưới Tình Yêu",
                            Url = "https://vi.chiasenhac.vn/nghe-album/tren-tinh-ban-duoi-tinh-yeu-single-xss7vwwsqt2994.html",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 10,
                            Name = "Đừng Yêu Nữa, Em Mệt Rồi",
                            Url = "https://vi.chiasenhac.vn/mp3/min/dung-yeu-nua-em-met-roi-tsvrzdwsqa1m94.html",
                            AuthorId = 2,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 11,
                            Name = "Đừng Xin Lỗi Nữa",
                            Url = "https://vi.chiasenhac.vn/nghe-album/dung-xin-loi-nua-single-xss7q6rbqtekaq.html",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Id = 12,
                            Name = "Em Mới Là Người Yêu Anh",
                            Url = "https://vi.chiasenhac.vn/nghe-album/em-moi-la-nguoi-yeu-anh-single-xss7cdmvqtvm82.html",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Id = 13,
                            Name = "Người Em Tìm Kiếm",
                            Url = "https://vi.chiasenhac.vn/nghe-album/nguoi-em-tim-kiem-single-xss7tbzdqtfq1m.html",
                            AuthorId = 4,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 14,
                            Name = "Có Em Chờ",
                            Url = "https://vi.chiasenhac.vn/mp3/min-mra/co-em-cho-tsvdqrqdqmeaem.html",
                            AuthorId = 1,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 15,
                            Name = "Hôn Anh",
                            Url = "https://vi.chiasenhac.vn/nghe-album/hon-anh-single-xssm05scq8nh4v.html",
                            AuthorId = 4,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 16,
                            Name = "Ghen",
                            Url = "https://vi.chiasenhac.vn/nghe-album/ghen-single-xssm0q5wq8neh9.html",
                            AuthorId = 3,
                            SingerId = 2,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 17,
                            Name = "Sáng Mắt Chưa",
                            Url = "https://vi.chiasenhac.vn/nghe-album/sang-mat-chua-single-xss7mzs3qt814w.html",
                            AuthorId = 4,
                            SingerId = 3,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 18,
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
