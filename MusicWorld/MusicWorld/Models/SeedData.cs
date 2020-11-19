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
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 7,
                            Name = "Love To Hate Me",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/love-to-hate-me-tsvmccb6q8vvqk.html",
                            AuthorId = 5,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 8,
                            Name = "You Never Know",
                            Url = "https://vi.chiasenhac.vn/mp3/blackpink/you-never-know-tsvmccb3q8vvqw.html",
                            AuthorId = 6,
                            SingerId = 1,
                            AlbumId = 1,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },

                        new Musics
                        {
                            Id = 9,
                            Name = "Trên Tình Bạn Dưới Tình Yêu",
                            Url = "https://vi.chiasenhac.vn/nghe-album/tren-tinh-ban-duoi-tinh-yeu-single-xss7vwwsqt2994.html",
                            AuthorId = 7,
                            SingerId = 2,
                            AlbumId = 2,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 10,
                            Name = "Đừng Yêu Nữa, Em Mệt Rồi",
                            Url = "https://vi.chiasenhac.vn/mp3/min/dung-yeu-nua-em-met-roi-tsvrzdwsqa1m94.html",
                            AuthorId = 8,
                            SingerId = 2,
                            AlbumId = 3,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 11,
                            Name = "Đừng Xin Lỗi Nữa",
                            Url = "https://vi.chiasenhac.vn/nghe-album/dung-xin-loi-nua-single-xss7q6rbqtekaq.html",
                            AuthorId = 9,
                            SingerId = 2,
                            AlbumId = 4,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Id = 12,
                            Name = "Em Mới Là Người Yêu Anh",
                            Url = "https://vi.chiasenhac.vn/nghe-album/em-moi-la-nguoi-yeu-anh-single-xss7cdmvqtvm82.html",
                            AuthorId = 7,
                            SingerId = 2,
                            AlbumId = 5,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Id = 13,
                            Name = "Người Em Tìm Kiếm",
                            Url = "https://vi.chiasenhac.vn/nghe-album/nguoi-em-tim-kiem-single-xss7tbzdqtfq1m.html",
                            AuthorId = 10,
                            SingerId = 2,
                            AlbumId = 6,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 14,
                            Name = "Có Em Chờ",
                            Url = "https://vi.chiasenhac.vn/mp3/min-mra/co-em-cho-tsvdqrqdqmeaem.html",
                            AuthorId = 11,
                            SingerId = 2,
                            AlbumId = 7,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 15,
                            Name = "Hôn Anh",
                            Url = "https://vi.chiasenhac.vn/nghe-album/hon-anh-single-xssm05scq8nh4v.html",
                            AuthorId = 12,
                            SingerId = 2,
                            AlbumId = 8,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 16,
                            Name = "Ghen",
                            Url = "https://vi.chiasenhac.vn/nghe-album/ghen-single-xssm0q5wq8neh9.html",
                            AuthorId = 7,
                            SingerId = 2,
                            AlbumId = 9,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 17,
                            Name = "Sáng Mắt Chưa",
                            Url = "https://vi.chiasenhac.vn/nghe-album/sang-mat-chua-single-xss7mzs3qt814w.html",
                            AuthorId = 13,
                            SingerId = 3,
                            AlbumId = 10,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 18,
                            Name = "Bài Này Chill Phết",
                            Url = "https://vi.chiasenhac.vn/nghe-album/bai-nay-chill-phet-single-xss7mdvwqt8m29.html",
                            AuthorId = 14,
                            SingerId = 4,
                            AlbumId = 11,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 19,
                            Name = "Cảm Ơn",
                            Url = "https://vi.chiasenhac.vn/nghe-album/cam-on-single-xss77s00qtt4nn.html",
                            AuthorId = 15,
                            SingerId = 4,
                            AlbumId = 12,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 20,
                            Name = "Anh Đếch Cần Gì Nhiều Ngoài Em",
                            Url = "https://vi.chiasenhac.vn/nghe-album/anh-dech-can-gi-nhieu-ngoai-em-single-xss7rr5vqtaah2.html",
                            AuthorId = 15,
                            SingerId = 4,
                            AlbumId = 13,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Id = 21,
                            Name = "Đố Em Biết Anh Đang Nghĩ Gì",
                            Url = "https://vi.chiasenhac.vn/nghe-album/do-em-biet-anh-dang-nghi-gi-single-xss7b5dwqtqhm9.html",
                            AuthorId = 15,
                            SingerId = 4,
                            AlbumId = 14,
                            ReleaseDate = new DateTime(2018, 06, 05)
                        },
                        new Musics
                        {
                            Id = 22,
                            Name = "Ta Cứ Đi Cùng Nhau",
                            Url = "https://vi.chiasenhac.vn/nghe-album/ta-cu-di-cung-nhau-single-xss7tddrqtfmma.html",
                            AuthorId = 15,
                            SingerId = 4,
                            AlbumId = 15,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 23,
                            Name = "Lời Đường Mật",
                            Url = "https://vi.chiasenhac.vn/mp3/lyly-hieuthuhai/loi-duong-mat-tsvmrb6qq8aqke.html",
                            AuthorId = 16,
                            SingerId = 5,
                            AlbumId = 16,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 24,
                            Name = "Người Ơi Người Ở Đừng Về",
                            Url = "https://vi.chiasenhac.vn/mp3/duc-phuc-suboi/nguoi-oi-nguoi-o-dung-ve-tsvmd05cq8mnhv.html",
                            AuthorId = 17,
                            SingerId = 6,
                            AlbumId = 17,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 25,
                            Name = "Ánh Nắng Của Anh",
                            Url = "https://vi.chiasenhac.vn/mp3/duc-phuc/anh-nang-cua-anh-tsvq7z76qet1tk.html",
                            AuthorId = 7,
                            SingerId = 6,
                            AlbumId = 18,
                            ReleaseDate = new DateTime(2016, 06, 05)
                        },
                        new Musics
                        {
                            Id = 26,
                            Name = "Yêu Được Không",
                            Url = "https://vi.chiasenhac.vn/mp3/duc-phuc/yeu-duoc-khong-tsvr7w6wqat9k9.html",
                            AuthorId = 18,
                            SingerId = 6,
                            AlbumId = 19,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 27,
                            Name = "Đen Đá Không Đường",
                            Url = "https://vi.chiasenhac.vn/mp3/amee/den-da-khong-duong-tsvr7b53qatqhw.html",
                            AuthorId = 16,
                            SingerId = 7,
                            AlbumId = 20,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 28,
                            Name = "Yêu Thì Yêu Không Yêu Thì Yêu",
                            Url = "https://vi.chiasenhac.vn/mp3/amee/yeu-thi-yeu-khong-yeu-thi-yeu-tsvwvccwq92vv9.html",
                            AuthorId = 19,
                            SingerId = 7,
                            AlbumId = 21,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 29,
                            Name = "Sao Anh Chưa Về Nhà",
                            Url = "https://vi.chiasenhac.vn/mp3/amee-ricky-star/sao-anh-chua-ve-nha-tsvwmc3bq98vwq.html",
                            AuthorId = 16,
                            SingerId = 7,
                            AlbumId = 22,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 30,
                            Name = "Trời Giấu Trời Mang Đi",
                            Url = "https://vi.chiasenhac.vn/mp3/amee-viruss/troi-giau-troi-mang-di-tsvr00qqqannee.html",
                            AuthorId = 18,
                            SingerId = 7,
                            AlbumId = 23,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 31,
                            Name = "Anh Đánh Rơi Người Yêu Này!",
                            Url = "https://vi.chiasenhac.vn/mp3/ameeandiez/anh-danh-roi-nguoi-yeu-nay-tsvr37w7qawt9t.html",
                            AuthorId = 20,
                            SingerId = 7,
                            AlbumId = 24,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 32,
                            Name = "Em Bé",
                            Url = "https://vi.chiasenhac.vn/mp3/amee-karik/em-be-tsvmd6zqq8mk1e.html",
                            AuthorId = 21,
                            SingerId = 7,
                            AlbumId = 25,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 33,
                            Name = "Làm Gì Phải Hốt",
                            Url = "https://vi.chiasenhac.vn/nghe-album/lam-gi-phai-hot-single-xss7667zqtkkt1.html",
                            AuthorId = 15,
                            SingerId = 8,
                            AlbumId = 26,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 34,
                            Name = "Để Mị nói cho mà nghe",
                            Url = "https://vi.chiasenhac.vn/mp3/hoang-thuy-linh/de-mi-noi-cho-ma-nghe-tsvwtcqdq9fvem.html",
                            AuthorId = 17,
                            SingerId = 8,
                            AlbumId = 27,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 35,
                            Name = "Kẻ Cắp Gặp Bà Già",
                            Url = "https://vi.chiasenhac.vn/mp3/hoang-thuy-linh-binz/ke-cap-gap-ba-gia-tsvwtcq7q9fvet.html",
                            AuthorId = 17,
                            SingerId = 8,
                            AlbumId = 27,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 36,
                            Name = "DUYÊN ÂM",
                            Url = "https://vi.chiasenhac.vn/mp3/hoang-thuy-linh/duyen-am-tsvwtcqcq9fvev.html",
                            AuthorId = 18,
                            SingerId = 8,
                            AlbumId = 27,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 37,
                            Name = "Em Đây Chẳng Phải Thúy Kiều",
                            Url = "https://vi.chiasenhac.vn/mp3/hoang-thuy-linh/em-day-chang-phai-thuy-kieu-tsvwtcqbq9fveq.html",
                            AuthorId = 19,
                            SingerId = 8,
                            AlbumId = 27,
                            ReleaseDate = new DateTime(2019, 06, 05)
                        },
                        new Musics
                        {
                            Id = 38,
                            Name = "Tứ Phủ",
                            Url = "https://vi.chiasenhac.vn/mp3/hoang-thuy-linh/tu-phu-tsvr33svqaww42.html",
                            AuthorId = 20,
                            SingerId = 8,
                            AlbumId = 27,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        },
                        new Musics
                        {
                            Id = 39,
                            Name = "They Said",
                            Url = "https://vi.chiasenhac.vn/mp3/binz-touliver/they-said-tsvmtwdmq8f9m8.html",
                            AuthorId = 21,
                            SingerId = 9,
                            AlbumId = 28,
                            ReleaseDate = new DateTime(2017, 06, 05)
                        },
                        new Musics
                        {
                            Id = 40,
                            Name = "Big City Boi",
                            Url = "https://vi.chiasenhac.vn/nghe-album/bigcityboi-single-xss7sswtqt449f.html",
                            AuthorId = 21,
                            SingerId = 9,
                            AlbumId = 29,
                            ReleaseDate = new DateTime(2020, 06, 05)
                        }
                    //    new Musics
                    //    {
                    //        Id = ,
                    //        Name = "",
                    //        Url = "",
                    //        AuthorId = ,
                    //        SingerId = ,
                    //        AlbumId = ,
                    //        ReleaseDate = new DateTime(2020, 06, 05)
                    //    }

                    );
                context.SaveChanges();
            }
        }
    }
}
