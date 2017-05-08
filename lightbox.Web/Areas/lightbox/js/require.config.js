window.require = window.require || {};
window.require.baseUrl = "/Areas/lightbox/js";

window.require.paths = window.require.paths || {};

window.require.paths.lightbox = "/Areas/lightbox/js";

window.require.shim = window.require.shim || {};
window.require.shim.bootstrap                 = { deps: ["jquery"] };
window.require.shim.matchHeight               = { deps: ["jquery"] };
window.require.shim.jqueryValidate            = { deps: ["jquery"] };
window.require.shim.jqueryUnobtrusiveAjax     = { deps: ["jquery", "jqueryValidate", "jqueryValidateUnobtrusive"] };
window.require.shim.jqueryValidateUnobtrusive = { deps: ["jqueryValidate"] };
window.require.shim.scorevalidation           = { deps: ["jqueryUnobtrusiveAjax", "jqueryValidateUnobtrusive"] };
