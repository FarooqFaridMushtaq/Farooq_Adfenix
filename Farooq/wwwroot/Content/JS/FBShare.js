window.fbAsyncInit = function () {
    FB.init({
        appId: '715961171925089',
        autoLogAppEvents: true,
        xfbml: true,
        version: 'v2.10'
    });
    FB.AppEvents.logPageView();
};

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));

function shareSoldHome(message) {
    FB.ui({
        method: 'share',
        display: 'popup',
        href: 'https://www.pexels.com/photo/architecture-building-business-buy-259098/',
        quote: message + ' has sold.',
    }, function (response) { });
}