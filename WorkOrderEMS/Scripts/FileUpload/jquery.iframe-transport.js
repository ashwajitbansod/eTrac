!function(e){"use strict";"function"==typeof define&&define.amd?define(["jquery"],e):e(window.jQuery)}(function(e){"use strict";var n=0;e.ajaxTransport("iframe",function(t){if(t.async&&("POST"===t.type||"GET"===t.type)){var a,r;return{send:function(o,i){a=e('<form style="display:none;"></form>'),r=e('<iframe src="javascript:false;" name="iframe-transport-'+(n+=1)+'"></iframe>').bind("load",function(){var n;r.unbind("load").bind("load",function(){var n;try{if(n=r.contents(),!n.length||!n[0].firstChild)throw new Error}catch(t){n=void 0}i(200,"success",{iframe:n}),e('<iframe src="javascript:false;"></iframe>').appendTo(a),a.remove()}),a.prop("target",r.prop("name")).prop("action",t.url).prop("method",t.type),t.formData&&e.each(t.formData,function(n,t){e('<input type="hidden"/>').prop("name",t.name).val(t.value).appendTo(a)}),t.fileInput&&t.fileInput.length&&"POST"===t.type&&(n=t.fileInput.clone(),t.fileInput.after(function(e){return n[e]}),t.paramName&&t.fileInput.each(function(){e(this).prop("name",t.paramName)}),a.append(t.fileInput).prop("enctype","multipart/form-data").prop("encoding","multipart/form-data")),a.submit(),n&&n.length&&t.fileInput.each(function(t,a){var r=e(n[t]);e(a).prop("name",r.prop("name")),r.replaceWith(a)})}),a.append(r).appendTo(document.body)},abort:function(){r&&r.unbind("load").prop("src","javascript".concat(":false;")),a&&a.remove()}}}}),e.ajaxSetup({converters:{"iframe text":function(n){return e(n[0].body).text()},"iframe json":function(n){return e.parseJSON(e(n[0].body).text())},"iframe html":function(n){return e(n[0].body).html()},"iframe script":function(n){return e.globalEval(e(n[0].body).text())}}})});