!function(t){t.extend(t.inputmask.defaults.definitions,{A:{validator:"[A-Za-z]",cardinality:1,casing:"upper"},"#":{validator:"[A-Za-zА-яЁё0-9]",cardinality:1,casing:"upper"}}),t.extend(t.inputmask.defaults.aliases,{url:{mask:"ir",placeholder:"",separator:"",defaultPrefix:"http://",regex:{urlpre1:new RegExp("[fh]"),urlpre2:new RegExp("(ft|ht)"),urlpre3:new RegExp("(ftp|htt)"),urlpre4:new RegExp("(ftp:|http|ftps)"),urlpre5:new RegExp("(ftp:/|ftps:|http:|https)"),urlpre6:new RegExp("(ftp://|ftps:/|http:/|https:)"),urlpre7:new RegExp("(ftp://|ftps://|http://|https:/)"),urlpre8:new RegExp("(ftp://|ftps://|http://|https://)")},definitions:{i:{validator:function(t,e,r,i,n){return!0},cardinality:8,prevalidator:function(){for(var t=[],e=8,r=0;e>r;r++)t[r]=function(){var t=r;return{validator:function(e,r,i,n,a){if(a.regex["urlpre"+(t+1)]){var p,l=e;t+1-e.length>0&&(l=r.join("").substring(0,t+1-e.length)+""+l);var f=a.regex["urlpre"+(t+1)].test(l);if(!n&&!f){for(i-=t,p=0;p<a.defaultPrefix.length;p++)r[i]=a.defaultPrefix[p],i++;for(p=0;p<l.length-1;p++)r[i]=l[p],i++;return{pos:i}}return f}return!1},cardinality:t}}();return t}()},r:{validator:".",cardinality:50}},insertMode:!1,autoUnmask:!1},ip:{mask:["[[x]y]z.[[x]y]z.[[x]y]z.x[yz]","[[x]y]z.[[x]y]z.[[x]y]z.[[x]y][z]"],definitions:{x:{validator:"[012]",cardinality:1,definitionSymbol:"i"},y:{validator:function(t,e,r,i,n){return t=r-1>-1&&"."!=e[r-1]?e[r-1]+t:"0"+t,new RegExp("2[0-5]|[01][0-9]").test(t)},cardinality:1,definitionSymbol:"i"},z:{validator:function(t,e,r,i,n){return r-1>-1&&"."!=e[r-1]?(t=e[r-1]+t,t=r-2>-1&&"."!=e[r-2]?e[r-2]+t:"0"+t):t="00"+t,new RegExp("25[0-5]|2[0-4][0-9]|[01][0-9][0-9]").test(t)},cardinality:1,definitionSymbol:"i"}}}})}(jQuery);