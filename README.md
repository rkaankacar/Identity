# Identity
Bu proje, .NET'in Identity kütüphanesinin kullanımını ve mantığını anlamak için geliştirilmiştir. Proje, kullanıcı yönetimi (ekleme, silme, güncelleme) ve kullanıcı rol yönetimi gibi temel özellikleri içermektedir. Ayrıca, kullanıcıların hangi detaylara erişebileceği, roller aracılığıyla belirlenmiştir. Proje, aşağıdaki özellikleri içerir:

## Özellikler
Kullanıcı Yönetimi:

Kullanıcı ekleme, silme ve güncelleme işlemleri yapılabilir.
Kullanıcı detayları görüntülenebilir.
## Rol Tabanlı Erişim:

Kullanıcı rollerine göre erişim yetkileri belirlenmiştir.
Rollere dayalı erişim, uygulamanın farklı bölümlerine yönlendirmeler sağlar.
## Authentication (Kimlik Doğrulama):

Kullanıcılar giriş yaparak kimliklerini doğrular.
## Authorization (Yetkilendirme):

Kullanıcılar, rollerine bağlı olarak uygulamanın farklı bölümlerine erişim sağlarken yetkilendirme kontrolü yapılır.
## E-posta Hesap Onayı:

Kullanıcıların e-posta adresleri onaylanarak, güvenli bir hesap doğrulaması yapılır.
E-posta onayı yapılmadan, kullanıcılar sisteme erişim sağlayamaz.
##Cookie Tabanlı Kullanıcı Girişi:

Kullanıcılar giriş yaptıktan sonra, giriş bilgileri bir cookie aracılığıyla hatırlanır.
Kullanıcılar, belirli bir süre boyunca tekrar giriş yapmadan siteyi kullanabilirler.
Cookie, kullanıcı oturum bilgilerini güvenli bir şekilde saklar ve kullanıcıyı sistemde tanır.
