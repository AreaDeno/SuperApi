import{cG as u,co as o,cB as f,da as p}from"./index-e9ed0e0e.js";var h=/\.|\[(?:[^[\]]*|(["'])(?:(?!\1)[^\\]|\\.)*?\1)\]/,d=/^\w*$/;function y(r,n){if(u(r))return!1;var e=typeof r;return e=="number"||e=="symbol"||e=="boolean"||r==null||o(r)?!0:d.test(r)||!h.test(r)||n!=null&&r in Object(n)}var m="Expected a function";function c(r,n){if(typeof r!="function"||n!=null&&typeof n!="function")throw new TypeError(m);var e=function(){var t=arguments,i=n?n.apply(this,t):t[0],a=e.cache;if(a.has(i))return a.get(i);var s=r.apply(this,t);return e.cache=a.set(i,s)||a,s};return e.cache=new(c.Cache||f),e}c.Cache=f;var g=500;function l(r){var n=c(r,function(t){return e.size===g&&e.clear(),t}),e=n.cache;return n}var E=/[^.[\]]+|\[(?:(-?\d+(?:\.\d+)?)|(["'])((?:(?!\2)[^\\]|\\.)*?)\2)\]|(?=(?:\.|\[\])(?:\.|\[\]|$))/g,C=/\\(\\)?/g,I=l(function(r){var n=[];return r.charCodeAt(0)===46&&n.push(""),r.replace(E,function(e,t,i,a){n.push(i?a.replace(C,"$1"):t||e)}),n});const P=I;function T(r,n){return u(r)?r:y(r,n)?[r]:P(p(r))}var w=1/0;function z(r){if(typeof r=="string"||o(r))return r;var n=r+"";return n=="0"&&1/r==-w?"-0":n}function M(r,n){n=T(n,r);for(var e=0,t=n.length;r!=null&&e<t;)r=r[z(n[e++])];return e&&e==t?r:void 0}function _(r,n,e){var t=r==null?void 0:M(r,n);return t===void 0?e:t}export{M as b,T as c,_ as g,y as i,z as t};
