/**
 * @version 4.1.0.47200 R.local - EleWise.ELMA.TestFramework
 * @author ELMA - https://www.elma-bpm.ru/
 * @copyright Copyright (c) 2006-2023, 
 * @license 
 */
/*!
 * QUnit 2.5.0
 * https://qunitjs.com/
 *
 * Copyright jQuery Foundation and other contributors
 * Released under the MIT license
 * https://jquery.org/license
 *
 * Date: 2018-01-10T02:56Z
 */
var QUnit;

var qunitLoader = function() {
    QUnit = {
        config: {
            autostart: false,
            reorder: false,
            altertitle: false
        }
    };
(function (global$1) {
  'use strict';

  global$1 = global$1 && global$1.hasOwnProperty('default') ? global$1['default'] : global$1;

  var window = global$1.window;
  var self$1 = global$1.self;
  var console = global$1.console;
  var setTimeout = global$1.setTimeout;
  var clearTimeout = global$1.clearTimeout;

  var document = window && window.document;
  var navigator = window && window.navigator;

  var localSessionStorage = function () {
  	var x = "qunit-test-string";
  	try {
  		global$1.sessionStorage.setItem(x, x);
  		global$1.sessionStorage.removeItem(x);
  		return global$1.sessionStorage;
  	} catch (e) {
  		return undefined;
  	}
  }();

  var _typeof = typeof Symbol === "function" && typeof Symbol.iterator === "symbol" ? function (obj) {
    return typeof obj;
  } : function (obj) {
    return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj;
  };











  var classCallCheck = function (instance, Constructor) {
    if (!(instance instanceof Constructor)) {
      throw new TypeError("Cannot call a class as a function");
    }
  };

  var createClass = function () {
    function defineProperties(target, props) {
      for (var i = 0; i < props.length; i++) {
        var descriptor = props[i];
        descriptor.enumerable = descriptor.enumerable || false;
        descriptor.configurable = true;
        if ("value" in descriptor) descriptor.writable = true;
        Object.defineProperty(target, descriptor.key, descriptor);
      }
    }

    return function (Constructor, protoProps, staticProps) {
      if (protoProps) defineProperties(Constructor.prototype, protoProps);
      if (staticProps) defineProperties(Constructor, staticProps);
      return Constructor;
    };
  }();









































  var toConsumableArray = function (arr) {
    if (Array.isArray(arr)) {
      for (var i = 0, arr2 = Array(arr.length); i < arr.length; i++) arr2[i] = arr[i];

      return arr2;
    } else {
      return Array.from(arr);
    }
  };

  var toString = Object.prototype.toString;
  var hasOwn = Object.prototype.hasOwnProperty;
  var now = Date.now || function () {
  	return new Date().getTime();
  };

  var defined = {
  	document: window && window.document !== undefined,
  	setTimeout: setTimeout !== undefined
  };

  // Returns a new Array with the elements that are in a but not in b
  function diff(a, b) {
  	var i,
  	    j,
  	    result = a.slice();

  	for (i = 0; i < result.length; i++) {
  		for (j = 0; j < b.length; j++) {
  			if (result[i] === b[j]) {
  				result.splice(i, 1);
  				i--;
  				break;
  			}
  		}
  	}
  	return result;
  }

  /**
   * Determines whether an element exists in a given array or not.
   *
   * @method inArray
   * @param {Any} elem
   * @param {Array} array
   * @return {Boolean}
   */
  function inArray(elem, array) {
  	return array.indexOf(elem) !== -1;
  }

  /**
   * Makes a clone of an object using only Array or Object as base,
   * and copies over the own enumerable properties.
   *
   * @param {Object} obj
   * @return {Object} New object with only the own properties (recursively).
   */
  function objectValues(obj) {
  	var key,
  	    val,
  	    vals = is("array", obj) ? [] : {};
  	for (key in obj) {
  		if (hasOwn.call(obj, key)) {
  			val = obj[key];
  			vals[key] = val === Object(val) ? objectValues(val) : val;
  		}
  	}
  	return vals;
  }

  function extend(a, b, undefOnly) {
  	for (var prop in b) {
  		if (hasOwn.call(b, prop)) {
  			if (b[prop] === undefined) {
  				delete a[prop];
  			} else if (!(undefOnly && typeof a[prop] !== "undefined")) {
  				a[prop] = b[prop];
  			}
  		}
  	}

  	return a;
  }

  function objectType(obj) {
  	if (typeof obj === "undefined") {
  		return "undefined";
  	}

  	// Consider: typeof null === object
  	if (obj === null) {
  		return "null";
  	}

  	var match = toString.call(obj).match(/^\[object\s(.*)\]$/),
  	    type = match && match[1];

  	switch (type) {
  		case "Number":
  			if (isNaN(obj)) {
  				return "nan";
  			}
  			return "number";
  		case "String":
  		case "Boolean":
  		case "Array":
  		case "Set":
  		case "Map":
  		case "Date":
  		case "RegExp":
  		case "Function":
  		case "Symbol":
  			return type.toLowerCase();
  		default:
  			return typeof obj === "undefined" ? "undefined" : _typeof(obj);
  	}
  }

  // Safe object type checking
  function is(type, obj) {
  	return objectType(obj) === type;
  }

  // Based on Java's String.hashCode, a simple but not
  // rigorously collision resistant hashing function
  function generateHash(module, testName) {
  	var str = module + "\x1C" + testName;
  	var hash = 0;

  	for (var i = 0; i < str.length; i++) {
  		hash = (hash << 5) - hash + str.charCodeAt(i);
  		hash |= 0;
  	}

  	// Convert the possibly negative integer hash code into an 8 character hex string, which isn't
  	// strictly necessary but increases user understanding that the id is a SHA-like hash
  	var hex = (0x100000000 + hash).toString(16);
  	if (hex.length < 8) {
  		hex = "0000000" + hex;
  	}

  	return hex.slice(-8);
  }

  // Test for equality any JavaScript type.
  // Authors: Philippe Rathé <prathe@gmail.com>, David Chan <david@troi.org>
  var equiv = (function () {

  	// Value pairs queued for comparison. Used for breadth-first processing order, recursion
  	// detection and avoiding repeated comparison (see below for details).
  	// Elements are { a: val, b: val }.
  	var pairs = [];

  	var getProto = Object.getPrototypeOf || function (obj) {
  		return obj.__proto__;
  	};

  	function useStrictEquality(a, b) {

  		// This only gets called if a and b are not strict equal, and is used to compare on
  		// the primitive values inside object wrappers. For example:
  		// `var i = 1;`
  		// `var j = new Number(1);`
  		// Neither a nor b can be null, as a !== b and they have the same type.
  		if ((typeof a === "undefined" ? "undefined" : _typeof(a)) === "object") {
  			a = a.valueOf();
  		}
  		if ((typeof b === "undefined" ? "undefined" : _typeof(b)) === "object") {
  			b = b.valueOf();
  		}

  		return a === b;
  	}

  	function compareConstructors(a, b) {
  		var protoA = getProto(a);
  		var protoB = getProto(b);

  		// Comparing constructors is more strict than using `instanceof`
  		if (a.constructor === b.constructor) {
  			return true;
  		}

  		// Ref #851
  		// If the obj prototype descends from a null constructor, treat it
  		// as a null prototype.
  		if (protoA && protoA.constructor === null) {
  			protoA = null;
  		}
  		if (protoB && protoB.constructor === null) {
  			protoB = null;
  		}

  		// Allow objects with no prototype to be equivalent to
  		// objects with Object as their constructor.
  		if (protoA === null && protoB === Object.prototype || protoB === null && protoA === Object.prototype) {
  			return true;
  		}

  		return false;
  	}

  	function getRegExpFlags(regexp) {
  		return "flags" in regexp ? regexp.flags : regexp.toString().match(/[gimuy]*$/)[0];
  	}

  	function isContainer(val) {
  		return ["object", "array", "map", "set"].indexOf(objectType(val)) !== -1;
  	}

  	function breadthFirstCompareChild(a, b) {

  		// If a is a container not reference-equal to b, postpone the comparison to the
  		// end of the pairs queue -- unless (a, b) has been seen before, in which case skip
  		// over the pair.
  		if (a === b) {
  			return true;
  		}
  		if (!isContainer(a)) {
  			return typeEquiv(a, b);
  		}
  		if (pairs.every(function (pair) {
  			return pair.a !== a || pair.b !== b;
  		})) {

  			// Not yet started comparing this pair
  			pairs.push({ a: a, b: b });
  		}
  		return true;
  	}

  	var callbacks = {
  		"string": useStrictEquality,
  		"boolean": useStrictEquality,
  		"number": useStrictEquality,
  		"null": useStrictEquality,
  		"undefined": useStrictEquality,
  		"symbol": useStrictEquality,
  		"date": useStrictEquality,

  		"nan": function nan() {
  			return true;
  		},

  		"regexp": function regexp(a, b) {
  			return a.source === b.source &&

  			// Include flags in the comparison
  			getRegExpFlags(a) === getRegExpFlags(b);
  		},

  		// abort (identical references / instance methods were skipped earlier)
  		"function": function _function() {
  			return false;
  		},

  		"array": function array(a, b) {
  			var i, len;

  			len = a.length;
  			if (len !== b.length) {

  				// Safe and faster
  				return false;
  			}

  			for (i = 0; i < len; i++) {

  				// Compare non-containers; queue non-reference-equal containers
  				if (!breadthFirstCompareChild(a[i], b[i])) {
  					return false;
  				}
  			}
  			return true;
  		},

  		// Define sets a and b to be equivalent if for each element aVal in a, there
  		// is some element bVal in b such that aVal and bVal are equivalent. Element
  		// repetitions are not counted, so these are equivalent:
  		// a = new Set( [ {}, [], [] ] );
  		// b = new Set( [ {}, {}, [] ] );
  		"set": function set$$1(a, b) {
  			var innerEq,
  			    outerEq = true;

  			if (a.size !== b.size) {

  				// This optimization has certain quirks because of the lack of
  				// repetition counting. For instance, adding the same
  				// (reference-identical) element to two equivalent sets can
  				// make them non-equivalent.
  				return false;
  			}

  			a.forEach(function (aVal) {

  				// Short-circuit if the result is already known. (Using for...of
  				// with a break clause would be cleaner here, but it would cause
  				// a syntax error on older Javascript implementations even if
  				// Set is unused)
  				if (!outerEq) {
  					return;
  				}

  				innerEq = false;

  				b.forEach(function (bVal) {
  					var parentPairs;

  					// Likewise, short-circuit if the result is already known
  					if (innerEq) {
  						return;
  					}

  					// Swap out the global pairs list, as the nested call to
  					// innerEquiv will clobber its contents
  					parentPairs = pairs;
  					if (innerEquiv(bVal, aVal)) {
  						innerEq = true;
  					}

  					// Replace the global pairs list
  					pairs = parentPairs;
  				});

  				if (!innerEq) {
  					outerEq = false;
  				}
  			});

  			return outerEq;
  		},

  		// Define maps a and b to be equivalent if for each key-value pair (aKey, aVal)
  		// in a, there is some key-value pair (bKey, bVal) in b such that
  		// [ aKey, aVal ] and [ bKey, bVal ] are equivalent. Key repetitions are not
  		// counted, so these are equivalent:
  		// a = new Map( [ [ {}, 1 ], [ {}, 1 ], [ [], 1 ] ] );
  		// b = new Map( [ [ {}, 1 ], [ [], 1 ], [ [], 1 ] ] );
  		"map": function map(a, b) {
  			var innerEq,
  			    outerEq = true;

  			if (a.size !== b.size) {

  				// This optimization has certain quirks because of the lack of
  				// repetition counting. For instance, adding the same
  				// (reference-identical) key-value pair to two equivalent maps
  				// can make them non-equivalent.
  				return false;
  			}

  			a.forEach(function (aVal, aKey) {

  				// Short-circuit if the result is already known. (Using for...of
  				// with a break clause would be cleaner here, but it would cause
  				// a syntax error on older Javascript implementations even if
  				// Map is unused)
  				if (!outerEq) {
  					return;
  				}

  				innerEq = false;

  				b.forEach(function (bVal, bKey) {
  					var parentPairs;

  					// Likewise, short-circuit if the result is already known
  					if (innerEq) {
  						return;
  					}

  					// Swap out the global pairs list, as the nested call to
  					// innerEquiv will clobber its contents
  					parentPairs = pairs;
  					if (innerEquiv([bVal, bKey], [aVal, aKey])) {
  						innerEq = true;
  					}

  					// Replace the global pairs list
  					pairs = parentPairs;
  				});

  				if (!innerEq) {
  					outerEq = false;
  				}
  			});

  			return outerEq;
  		},

  		"object": function object(a, b) {
  			var i,
  			    aProperties = [],
  			    bProperties = [];

  			if (compareConstructors(a, b) === false) {
  				return false;
  			}

  			// Be strict: don't ensure hasOwnProperty and go deep
  			for (i in a) {

  				// Collect a's properties
  				aProperties.push(i);

  				// Skip OOP methods that look the same
  				if (a.constructor !== Object && typeof a.constructor !== "undefined" && typeof a[i] === "function" && typeof b[i] === "function" && a[i].toString() === b[i].toString()) {
  					continue;
  				}

  				// Compare non-containers; queue non-reference-equal containers
  				if (!breadthFirstCompareChild(a[i], b[i])) {
  					return false;
  				}
  			}

  			for (i in b) {

  				// Collect b's properties
  				bProperties.push(i);
  			}

  			// Ensures identical properties name
  			return typeEquiv(aProperties.sort(), bProperties.sort());
  		}
  	};

  	function typeEquiv(a, b) {
  		var type = objectType(a);

  		// Callbacks for containers will append to the pairs queue to achieve breadth-first
  		// search order. The pairs queue is also used to avoid reprocessing any pair of
  		// containers that are reference-equal to a previously visited pair (a special case
  		// this being recursion detection).
  		//
  		// Because of this approach, once typeEquiv returns a false value, it should not be
  		// called again without clearing the pair queue else it may wrongly report a visited
  		// pair as being equivalent.
  		return objectType(b) === type && callbacks[type](a, b);
  	}

  	function innerEquiv(a, b) {
  		var i, pair;

  		// We're done when there's nothing more to compare
  		if (arguments.length < 2) {
  			return true;
  		}

  		// Clear the global pair queue and add the top-level values being compared
  		pairs = [{ a: a, b: b }];

  		for (i = 0; i < pairs.length; i++) {
  			pair = pairs[i];

  			// Perform type-specific comparison on any pairs that are not strictly
  			// equal. For container types, that comparison will postpone comparison
  			// of any sub-container pair to the end of the pair queue. This gives
  			// breadth-first search order. It also avoids the reprocessing of
  			// reference-equal siblings, cousins etc, which can have a significant speed
  			// impact when comparing a container of small objects each of which has a
  			// reference to the same (singleton) large object.
  			if (pair.a !== pair.b && !typeEquiv(pair.a, pair.b)) {
  				return false;
  			}
  		}

  		// ...across all consecutive argument pairs
  		return arguments.length === 2 || innerEquiv.apply(this, [].slice.call(arguments, 1));
  	}

  	return function () {
  		var result = innerEquiv.apply(undefined, arguments);

  		// Release any retained objects
  		pairs.length = 0;
  		return result;
  	};
  })();

  /**
   * Config object: Maintain internal state
   * Later exposed as QUnit.config
   * `config` initialized at top of scope
   */
  var config = {

  	// The queue of tests to run
  	queue: [],

  	// Block until document ready
  	blocking: true,

  	// By default, run previously failed tests first
  	// very useful in combination with "Hide passed tests" checked
  	reorder: true,

  	// By default, modify document.title when suite is done
  	altertitle: true,

  	// HTML Reporter: collapse every test except the first failing test
  	// If false, all failing tests will be expanded
  	collapse: true,

  	// By default, scroll to top of the page when suite is done
  	scrolltop: true,

  	// Depth up-to which object will be dumped
  	maxDepth: 5,

  	// When enabled, all tests must call expect()
  	requireExpects: false,

  	// Placeholder for user-configurable form-exposed URL parameters
  	urlConfig: [],

  	// Set of all modules.
  	modules: [],

  	// The first unnamed module
  	currentModule: {
  		name: "",
  		tests: [],
  		childModules: [],
  		testsRun: 0,
  		unskippedTestsRun: 0,
  		hooks: {
  			before: [],
  			beforeEach: [],
  			afterEach: [],
  			after: []
  		}
  	},

  	callbacks: {},

  	// The storage module to use for reordering tests
  	storage: localSessionStorage
  };

  // take a predefined QUnit.config and extend the defaults
  var globalConfig = window && window.QUnit && window.QUnit.config;

  // only extend the global config if there is no QUnit overload
  if (window && window.QUnit && !window.QUnit.version) {
  	extend(config, globalConfig);
  }

  // Push a loose unnamed module to the modules collection
  config.modules.push(config.currentModule);

  // Based on jsDump by Ariel Flesler
  // http://flesler.blogspot.com/2008/05/jsdump-pretty-dump-of-any-javascript.html
  var dump = (function () {
  	function quote(str) {
  		return "\"" + str.toString().replace(/\\/g, "\\\\").replace(/"/g, "\\\"") + "\"";
  	}
  	function literal(o) {
  		return o + "";
  	}
  	function join(pre, arr, post) {
  		var s = dump.separator(),
  		    base = dump.indent(),
  		    inner = dump.indent(1);
  		if (arr.join) {
  			arr = arr.join("," + s + inner);
  		}
  		if (!arr) {
  			return pre + post;
  		}
  		return [pre, inner + arr, base + post].join(s);
  	}
  	function array(arr, stack) {
  		var i = arr.length,
  		    ret = new Array(i);

  		if (dump.maxDepth && dump.depth > dump.maxDepth) {
  			return "[object Array]";
  		}

  		this.up();
  		while (i--) {
  			ret[i] = this.parse(arr[i], undefined, stack);
  		}
  		this.down();
  		return join("[", ret, "]");
  	}

  	function isArray(obj) {
  		return (

  			//Native Arrays
  			toString.call(obj) === "[object Array]" ||

  			// NodeList objects
  			typeof obj.length === "number" && obj.item !== undefined && (obj.length ? obj.item(0) === obj[0] : obj.item(0) === null && obj[0] === undefined)
  		);
  	}

  	var reName = /^function (\w+)/,
  	    dump = {

  		// The objType is used mostly internally, you can fix a (custom) type in advance
  		parse: function parse(obj, objType, stack) {
  			stack = stack || [];
  			var res,
  			    parser,
  			    parserType,
  			    objIndex = stack.indexOf(obj);

  			if (objIndex !== -1) {
  				return "recursion(" + (objIndex - stack.length) + ")";
  			}

  			objType = objType || this.typeOf(obj);
  			parser = this.parsers[objType];
  			parserType = typeof parser === "undefined" ? "undefined" : _typeof(parser);

  			if (parserType === "function") {
  				stack.push(obj);
  				res = parser.call(this, obj, stack);
  				stack.pop();
  				return res;
  			}
  			return parserType === "string" ? parser : this.parsers.error;
  		},
  		typeOf: function typeOf(obj) {
  			var type;

  			if (obj === null) {
  				type = "null";
  			} else if (typeof obj === "undefined") {
  				type = "undefined";
  			} else if (is("regexp", obj)) {
  				type = "regexp";
  			} else if (is("date", obj)) {
  				type = "date";
  			} else if (is("function", obj)) {
  				type = "function";
  			} else if (obj.setInterval !== undefined && obj.document !== undefined && obj.nodeType === undefined) {
  				type = "window";
  			} else if (obj.nodeType === 9) {
  				type = "document";
  			} else if (obj.nodeType) {
  				type = "node";
  			} else if (isArray(obj)) {
  				type = "array";
  			} else if (obj.constructor === Error.prototype.constructor) {
  				type = "error";
  			} else {
  				type = typeof obj === "undefined" ? "undefined" : _typeof(obj);
  			}
  			return type;
  		},

  		separator: function separator() {
  			if (this.multiline) {
  				return this.HTML ? "<br />" : "\n";
  			} else {
  				return this.HTML ? "&#160;" : " ";
  			}
  		},

  		// Extra can be a number, shortcut for increasing-calling-decreasing
  		indent: function indent(extra) {
  			if (!this.multiline) {
  				return "";
  			}
  			var chr = this.indentChar;
  			if (this.HTML) {
  				chr = chr.replace(/\t/g, "   ").replace(/ /g, "&#160;");
  			}
  			return new Array(this.depth + (extra || 0)).join(chr);
  		},
  		up: function up(a) {
  			this.depth += a || 1;
  		},
  		down: function down(a) {
  			this.depth -= a || 1;
  		},
  		setParser: function setParser(name, parser) {
  			this.parsers[name] = parser;
  		},

  		// The next 3 are exposed so you can use them
  		quote: quote,
  		literal: literal,
  		join: join,
  		depth: 1,
  		maxDepth: config.maxDepth,

  		// This is the list of parsers, to modify them, use dump.setParser
  		parsers: {
  			window: "[Window]",
  			document: "[Document]",
  			error: function error(_error) {
  				return "Error(\"" + _error.message + "\")";
  			},
  			unknown: "[Unknown]",
  			"null": "null",
  			"undefined": "undefined",
  			"function": function _function(fn) {
  				var ret = "function",


  				// Functions never have name in IE
  				name = "name" in fn ? fn.name : (reName.exec(fn) || [])[1];

  				if (name) {
  					ret += " " + name;
  				}
  				ret += "(";

  				ret = [ret, dump.parse(fn, "functionArgs"), "){"].join("");
  				return join(ret, dump.parse(fn, "functionCode"), "}");
  			},
  			array: array,
  			nodelist: array,
  			"arguments": array,
  			object: function object(map, stack) {
  				var keys,
  				    key,
  				    val,
  				    i,
  				    nonEnumerableProperties,
  				    ret = [];

  				if (dump.maxDepth && dump.depth > dump.maxDepth) {
  					return "[object Object]";
  				}

  				dump.up();
  				keys = [];
  				for (key in map) {
  					keys.push(key);
  				}

  				// Some properties are not always enumerable on Error objects.
  				nonEnumerableProperties = ["message", "name"];
  				for (i in nonEnumerableProperties) {
  					key = nonEnumerableProperties[i];
  					if (key in map && !inArray(key, keys)) {
  						keys.push(key);
  					}
  				}
  				keys.sort();
  				for (i = 0; i < keys.length; i++) {
  					key = keys[i];
  					val = map[key];
  					ret.push(dump.parse(key, "key") + ": " + dump.parse(val, undefined, stack));
  				}
  				dump.down();
  				return join("{", ret, "}");
  			},
  			node: function node(_node) {
  				var len,
  				    i,
  				    val,
  				    open = dump.HTML ? "&lt;" : "<",
  				    close = dump.HTML ? "&gt;" : ">",
  				    tag = _node.nodeName.toLowerCase(),
  				    ret = open + tag,
  				    attrs = _node.attributes;

  				if (attrs) {
  					for (i = 0, len = attrs.length; i < len; i++) {
  						val = attrs[i].nodeValue;

  						// IE6 includes all attributes in .attributes, even ones not explicitly
  						// set. Those have values like undefined, null, 0, false, "" or
  						// "inherit".
  						if (val && val !== "inherit") {
  							ret += " " + attrs[i].nodeName + "=" + dump.parse(val, "attribute");
  						}
  					}
  				}
  				ret += close;

  				// Show content of TextNode or CDATASection
  				if (_node.nodeType === 3 || _node.nodeType === 4) {
  					ret += _node.nodeValue;
  				}

  				return ret + open + "/" + tag + close;
  			},

  			// Function calls it internally, it's the arguments part of the function
  			functionArgs: function functionArgs(fn) {
  				var args,
  				    l = fn.length;

  				if (!l) {
  					return "";
  				}

  				args = new Array(l);
  				while (l--) {

  					// 97 is 'a'
  					args[l] = String.fromCharCode(97 + l);
  				}
  				return " " + args.join(", ") + " ";
  			},

  			// Object calls it internally, the key part of an item in a map
  			key: quote,

  			// Function calls it internally, it's the content of the function
  			functionCode: "[code]",

  			// Node calls it internally, it's a html attribute value
  			attribute: quote,
  			string: quote,
  			date: quote,
  			regexp: literal,
  			number: literal,
  			"boolean": literal,
  			symbol: function symbol(sym) {
  				return sym.toString();
  			}
  		},

  		// If true, entities are escaped ( <, >, \t, space and \n )
  		HTML: false,

  		// Indentation unit
  		indentChar: "  ",

  		// If true, items in a collection, are separated by a \n, else just a space.
  		multiline: true
  	};

  	return dump;
  })();

  var LISTENERS = Object.create(null);
  var SUPPORTED_EVENTS = ["runStart", "suiteStart", "testStart", "assertion", "testEnd", "suiteEnd", "runEnd"];

  /**
   * Emits an event with the specified data to all currently registered listeners.
   * Callbacks will fire in the order in which they are registered (FIFO). This
   * function is not exposed publicly; it is used by QUnit internals to emit
   * logging events.
   *
   * @private
   * @method emit
   * @param {String} eventName
   * @param {Object} data
   * @return {Void}
   */
  function emit(eventName, data) {
  	if (objectType(eventName) !== "string") {
  		throw new TypeError("eventName must be a string when emitting an event");
  	}

  	// Clone the callbacks in case one of them registers a new callback
  	var originalCallbacks = LISTENERS[eventName];
  	var callbacks = originalCallbacks ? [].concat(toConsumableArray(originalCallbacks)) : [];

  	for (var i = 0; i < callbacks.length; i++) {
  		callbacks[i](data);
  	}
  }

  /**
   * Registers a callback as a listener to the specified event.
   *
   * @public
   * @method on
   * @param {String} eventName
   * @param {Function} callback
   * @return {Void}
   */
  function on(eventName, callback) {
  	if (objectType(eventName) !== "string") {
  		throw new TypeError("eventName must be a string when registering a listener");
  	} else if (!inArray(eventName, SUPPORTED_EVENTS)) {
  		var events = SUPPORTED_EVENTS.join(", ");
  		throw new Error("\"" + eventName + "\" is not a valid event; must be one of: " + events + ".");
  	} else if (objectType(callback) !== "function") {
  		throw new TypeError("callback must be a function when registering a listener");
  	}

  	if (!LISTENERS[eventName]) {
  		LISTENERS[eventName] = [];
  	}

  	// Don't register the same callback more than once
  	if (!inArray(callback, LISTENERS[eventName])) {
  		LISTENERS[eventName].push(callback);
  	}
  }

  // Register logging callbacks
  function registerLoggingCallbacks(obj) {
  	var i,
  	    l,
  	    key,
  	    callbackNames = ["begin", "done", "log", "testStart", "testDone", "moduleStart", "moduleDone"];

  	function registerLoggingCallback(key) {
  		var loggingCallback = function loggingCallback(callback) {
  			if (objectType(callback) !== "function") {
  				throw new Error("QUnit logging methods require a callback function as their first parameters.");
  			}

  			config.callbacks[key].push(callback);
  		};

  		return loggingCallback;
  	}

  	for (i = 0, l = callbackNames.length; i < l; i++) {
  		key = callbackNames[i];

  		// Initialize key collection of logging callback
  		if (objectType(config.callbacks[key]) === "undefined") {
  			config.callbacks[key] = [];
  		}

  		obj[key] = registerLoggingCallback(key);
  	}
  }

  function runLoggingCallbacks(key, args) {
  	var i, l, callbacks;

  	callbacks = config.callbacks[key];
  	for (i = 0, l = callbacks.length; i < l; i++) {
  		callbacks[i](args);
  	}
  }

  // Doesn't support IE9, it will return undefined on these browsers
  // See also https://developer.mozilla.org/en/JavaScript/Reference/Global_Objects/Error/Stack
  var fileName = (sourceFromStacktrace(0) || "").replace(/(:\d+)+\)?/, "").replace(/.+\//, "");

  function extractStacktrace(e, offset) {
  	offset = offset === undefined ? 4 : offset;

  	var stack, include, i;

  	if (e && e.stack) {
  		stack = e.stack.split("\n");
  		if (/^error$/i.test(stack[0])) {
  			stack.shift();
  		}
  		if (fileName) {
  			include = [];
  			for (i = offset; i < stack.length; i++) {
  				if (stack[i].indexOf(fileName) !== -1) {
  					break;
  				}
  				include.push(stack[i]);
  			}
  			if (include.length) {
  				return include.join("\n");
  			}
  		}
  		return stack[offset];
  	}
  }

  function sourceFromStacktrace(offset) {
  	var error = new Error();

  	// Support: Safari <=7 only, IE <=10 - 11 only
  	// Not all browsers generate the `stack` property for `new Error()`, see also #636
  	if (!error.stack) {
  		try {
  			throw error;
  		} catch (err) {
  			error = err;
  		}
  	}

  	return extractStacktrace(error, offset);
  }

  var priorityCount = 0;
  var unitSampler = void 0;

  /**
   * Advances the ProcessingQueue to the next item if it is ready.
   * @param {Boolean} last
   */
  function advance() {
  	var start = now();
  	config.depth = (config.depth || 0) + 1;

  	while (config.queue.length && !config.blocking) {
  		var elapsedTime = now() - start;

  		if (!defined.setTimeout || config.updateRate <= 0 || elapsedTime < config.updateRate) {
  			if (priorityCount > 0) {
  				priorityCount--;
  			}

  			config.queue.shift()();
  		} else {
  			setTimeout(advance);
  			break;
  		}
  	}

  	config.depth--;

  	if (!config.blocking && !config.queue.length && config.depth === 0) {
  		done();
  	}
  }

  function addToQueueImmediate(callback) {
  	if (objectType(callback) === "array") {
  		while (callback.length) {
  			addToQueueImmediate(callback.pop());
  		}

  		return;
  	}

  	config.queue.unshift(callback);
  	priorityCount++;
  }

  /**
   * Adds a function to the ProcessingQueue for execution.
   * @param {Function|Array} callback
   * @param {Boolean} priority
   * @param {String} seed
   */
  function addToQueue(callback, prioritize, seed) {
  	if (prioritize) {
  		config.queue.splice(priorityCount++, 0, callback);
  	} else if (seed) {
  		if (!unitSampler) {
  			unitSampler = unitSamplerGenerator(seed);
  		}

  		// Insert into a random position after all prioritized items
  		var index = Math.floor(unitSampler() * (config.queue.length - priorityCount + 1));
  		config.queue.splice(priorityCount + index, 0, callback);
  	} else {
  		config.queue.push(callback);
  	}
  }

  /**
   * Creates a seeded "sample" generator which is used for randomizing tests.
   */
  function unitSamplerGenerator(seed) {

  	// 32-bit xorshift, requires only a nonzero seed
  	// http://excamera.com/sphinx/article-xorshift.html
  	var sample = parseInt(generateHash(seed), 16) || -1;
  	return function () {
  		sample ^= sample << 13;
  		sample ^= sample >>> 17;
  		sample ^= sample << 5;

  		// ECMAScript has no unsigned number type
  		if (sample < 0) {
  			sample += 0x100000000;
  		}

  		return sample / 0x100000000;
  	};
  }

  /**
   * This function is called when the ProcessingQueue is done processing all
   * items. It handles emitting the final run events.
   */
  function done() {
  	var storage = config.storage;

  	ProcessingQueue.finished = true;

  	var runtime = now() - config.started;
  	var passed = config.stats.all - config.stats.bad;

  	emit("runEnd", globalSuite.end(true));
  	runLoggingCallbacks("done", {
  		passed: passed,
  		failed: config.stats.bad,
  		total: config.stats.all,
  		runtime: runtime
  	});

  	// Clear own storage items if all tests passed
  	if (storage && config.stats.bad === 0) {
  		for (var i = storage.length - 1; i >= 0; i--) {
  			var key = storage.key(i);

  			if (key.indexOf("qunit-test-") === 0) {
  				storage.removeItem(key);
  			}
  		}
  	}
  }

  var ProcessingQueue = {
  	finished: false,
  	add: addToQueue,
  	addImmediate: addToQueueImmediate,
  	advance: advance
  };

  var TestReport = function () {
  	function TestReport(name, suite, options) {
  		classCallCheck(this, TestReport);

  		this.name = name;
  		this.suiteName = suite.name;
  		this.fullName = suite.fullName.concat(name);
  		this.runtime = 0;
  		this.assertions = [];

  		this.skipped = !!options.skip;
  		this.todo = !!options.todo;

  		this.valid = options.valid;

  		this._startTime = 0;
  		this._endTime = 0;

  		suite.pushTest(this);
  	}

  	createClass(TestReport, [{
  		key: "start",
  		value: function start(recordTime) {
  			if (recordTime) {
  				this._startTime = Date.now();
  			}

  			return {
  				name: this.name,
  				suiteName: this.suiteName,
  				fullName: this.fullName.slice()
  			};
  		}
  	}, {
  		key: "end",
  		value: function end(recordTime) {
  			if (recordTime) {
  				this._endTime = Date.now();
  			}

  			return extend(this.start(), {
  				runtime: this.getRuntime(),
  				status: this.getStatus(),
  				errors: this.getFailedAssertions(),
  				assertions: this.getAssertions()
  			});
  		}
  	}, {
  		key: "pushAssertion",
  		value: function pushAssertion(assertion) {
  			this.assertions.push(assertion);
  		}
  	}, {
  		key: "getRuntime",
  		value: function getRuntime() {
  			return this._endTime - this._startTime;
  		}
  	}, {
  		key: "getStatus",
  		value: function getStatus() {
  			if (this.skipped) {
  				return "skipped";
  			}

  			var testPassed = this.getFailedAssertions().length > 0 ? this.todo : !this.todo;

  			if (!testPassed) {
  				return "failed";
  			} else if (this.todo) {
  				return "todo";
  			} else {
  				return "passed";
  			}
  		}
  	}, {
  		key: "getFailedAssertions",
  		value: function getFailedAssertions() {
  			return this.assertions.filter(function (assertion) {
  				return !assertion.passed;
  			});
  		}
  	}, {
  		key: "getAssertions",
  		value: function getAssertions() {
  			return this.assertions.slice();
  		}

  		// Remove actual and expected values from assertions. This is to prevent
  		// leaking memory throughout a test suite.

  	}, {
  		key: "slimAssertions",
  		value: function slimAssertions() {
  			this.assertions = this.assertions.map(function (assertion) {
  				delete assertion.actual;
  				delete assertion.expected;
  				return assertion;
  			});
  		}
  	}]);
  	return TestReport;
  }();

  var focused$1 = false;

  function Test(settings) {
  	var i, l;

  	++Test.count;

  	this.expected = null;
  	this.assertions = [];
  	this.semaphore = 0;
  	this.module = config.currentModule;
  	this.stack = sourceFromStacktrace(3);
  	this.steps = [];
  	this.timeout = undefined;

  	// If a module is skipped, all its tests and the tests of the child suites
  	// should be treated as skipped even if they are defined as `only` or `todo`.
  	// As for `todo` module, all its tests will be treated as `todo` except for
  	// tests defined as `skip` which will be left intact.
  	//
  	// So, if a test is defined as `todo` and is inside a skipped module, we should
  	// then treat that test as if was defined as `skip`.
  	if (this.module.skip) {
  		settings.skip = true;
  		settings.todo = false;

  		// Skipped tests should be left intact
  	} else if (this.module.todo && !settings.skip) {
  		settings.todo = true;
  	}

  	extend(this, settings);

  	this.testReport = new TestReport(settings.testName, this.module.suiteReport, {
  		todo: settings.todo,
  		skip: settings.skip,
  		valid: this.valid()
  	});

  	// Register unique strings
  	for (i = 0, l = this.module.tests; i < l.length; i++) {
  		if (this.module.tests[i].name === this.testName) {
  			this.testName += " ";
  		}
  	}

  	this.testId = generateHash(this.module.name, this.testName);

  	this.module.tests.push({
  		name: this.testName,
  		testId: this.testId,
  		skip: !!settings.skip
  	});

  	if (settings.skip) {

  		// Skipped tests will fully ignore any sent callback
  		this.callback = function () {};
  		this.async = false;
  		this.expected = 0;
  	} else {
  		if (typeof this.callback !== "function") {
  			var method = this.todo ? "todo" : "test";

  			// eslint-disable-next-line max-len
  			throw new TypeError("You must provide a function as a test callback to QUnit." + method + "(\"" + settings.testName + "\")");
  		}

  		this.assert = new Assert(this);
  	}
  }

  Test.count = 0;

  function getNotStartedModules(startModule) {
  	var module = startModule,
  	    modules = [];

  	while (module && module.testsRun === 0) {
  		modules.push(module);
  		module = module.parentModule;
  	}

  	return modules;
  }

  Test.prototype = {
  	before: function before() {
  		var i,
  		    startModule,
  		    module = this.module,
  		    notStartedModules = getNotStartedModules(module);

  		for (i = notStartedModules.length - 1; i >= 0; i--) {
  			startModule = notStartedModules[i];
  			startModule.stats = { all: 0, bad: 0, started: now() };
  			emit("suiteStart", startModule.suiteReport.start(true));
  			runLoggingCallbacks("moduleStart", {
  				name: startModule.name,
  				tests: startModule.tests
  			});
  		}

  		config.current = this;

  		this.testEnvironment = extend({}, module.testEnvironment);

  		this.started = now();
  		emit("testStart", this.testReport.start(true));
  		runLoggingCallbacks("testStart", {
  			name: this.testName,
  			module: module.name,
  			testId: this.testId,
  			previousFailure: this.previousFailure
  		});

  		if (!config.pollution) {
  			saveGlobal();
  		}
  	},

  	run: function run() {
  		var promise;

  		config.current = this;

  		this.callbackStarted = now();

  		if (config.notrycatch) {
  			runTest(this);
  			return;
  		}

  		try {
  			runTest(this);
  		} catch (e) {
  			this.pushFailure("Died on test #" + (this.assertions.length + 1) + " " + this.stack + ": " + (e.message || e), extractStacktrace(e, 0));

  			// Else next test will carry the responsibility
  			saveGlobal();

  			// Restart the tests if they're blocking
  			if (config.blocking) {
  				internalRecover(this);
  			}
  		}

  		function runTest(test) {
  			promise = test.callback.call(test.testEnvironment, test.assert);
  			test.resolvePromise(promise);

  			// If the test has a "lock" on it, but the timeout is 0, then we push a
  			// failure as the test should be synchronous.
  			if (test.timeout === 0 && test.semaphore !== 0) {
  				pushFailure("Test did not finish synchronously even though assert.timeout( 0 ) was used.", sourceFromStacktrace(2));
  			}
  		}
  	},

  	after: function after() {
  		checkPollution();
  	},

  	queueHook: function queueHook(hook, hookName, hookOwner) {
  		var _this = this;

  		var callHook = function callHook() {
  			var promise = hook.call(_this.testEnvironment, _this.assert);
  			_this.resolvePromise(promise, hookName);
  		};

  		var runHook = function runHook() {
  			if (hookName === "before") {
  				if (hookOwner.unskippedTestsRun !== 0) {
  					return;
  				}

  				_this.preserveEnvironment = true;
  			}

  			if (hookName === "after" && hookOwner.unskippedTestsRun !== numberOfUnskippedTests(hookOwner) - 1 && config.queue.length > 2) {
  				return;
  			}

  			config.current = _this;
  			if (config.notrycatch) {
  				callHook();
  				return;
  			}
  			try {
  				callHook();
  			} catch (error) {
  				_this.pushFailure(hookName + " failed on " + _this.testName + ": " + (error.message || error), extractStacktrace(error, 0));
  			}
  		};

  		return runHook;
  	},


  	// Currently only used for module level hooks, can be used to add global level ones
  	hooks: function hooks(handler) {
  		var hooks = [];

  		function processHooks(test, module) {
  			if (module.parentModule) {
  				processHooks(test, module.parentModule);
  			}

  			if (module.hooks[handler].length) {
  				for (var i = 0; i < module.hooks[handler].length; i++) {
  					hooks.push(test.queueHook(module.hooks[handler][i], handler, module));
  				}
  			}
  		}

  		// Hooks are ignored on skipped tests
  		if (!this.skip) {
  			processHooks(this, this.module);
  		}

  		return hooks;
  	},


  	finish: function finish() {
  		config.current = this;
  		if (config.requireExpects && this.expected === null) {
  			this.pushFailure("Expected number of assertions to be defined, but expect() was " + "not called.", this.stack);
  		} else if (this.expected !== null && this.expected !== this.assertions.length) {
  			this.pushFailure("Expected " + this.expected + " assertions, but " + this.assertions.length + " were run", this.stack);
  		} else if (this.expected === null && !this.assertions.length) {
  			this.pushFailure("Expected at least one assertion, but none were run - call " + "expect(0) to accept zero assertions.", this.stack);
  		}

  		var i,
  		    module = this.module,
  		    moduleName = module.name,
  		    testName = this.testName,
  		    skipped = !!this.skip,
  		    todo = !!this.todo,
  		    bad = 0,
  		    storage = config.storage;

  		this.runtime = now() - this.started;

  		config.stats.all += this.assertions.length;
  		module.stats.all += this.assertions.length;

  		for (i = 0; i < this.assertions.length; i++) {
  			if (!this.assertions[i].result) {
  				bad++;
  				config.stats.bad++;
  				module.stats.bad++;
  			}
  		}

  		notifyTestsRan(module, skipped);

  		// Store result when possible
  		if (storage) {
  			if (bad) {
  				storage.setItem("qunit-test-" + moduleName + "-" + testName, bad);
  			} else {
  				storage.removeItem("qunit-test-" + moduleName + "-" + testName);
  			}
  		}

  		// After emitting the js-reporters event we cleanup the assertion data to
  		// avoid leaking it. It is not used by the legacy testDone callbacks.
  		emit("testEnd", this.testReport.end(true));
  		this.testReport.slimAssertions();

  		runLoggingCallbacks("testDone", {
  			name: testName,
  			module: moduleName,
  			skipped: skipped,
  			todo: todo,
  			failed: bad,
  			passed: this.assertions.length - bad,
  			total: this.assertions.length,
  			runtime: skipped ? 0 : this.runtime,

  			// HTML Reporter use
  			assertions: this.assertions,
  			testId: this.testId,

  			// Source of Test
  			source: this.stack
  		});

  		if (module.testsRun === numberOfTests(module)) {
  			logSuiteEnd(module);

  			// Check if the parent modules, iteratively, are done. If that the case,
  			// we emit the `suiteEnd` event and trigger `moduleDone` callback.
  			var parent = module.parentModule;
  			while (parent && parent.testsRun === numberOfTests(parent)) {
  				logSuiteEnd(parent);
  				parent = parent.parentModule;
  			}
  		}

  		config.current = undefined;

  		function logSuiteEnd(module) {
  			emit("suiteEnd", module.suiteReport.end(true));
  			runLoggingCallbacks("moduleDone", {
  				name: module.name,
  				tests: module.tests,
  				failed: module.stats.bad,
  				passed: module.stats.all - module.stats.bad,
  				total: module.stats.all,
  				runtime: now() - module.stats.started
  			});
  		}
  	},

  	preserveTestEnvironment: function preserveTestEnvironment() {
  		if (this.preserveEnvironment) {
  			this.module.testEnvironment = this.testEnvironment;
  			this.testEnvironment = extend({}, this.module.testEnvironment);
  		}
  	},

  	queue: function queue() {
  		var test = this;

  		if (!this.valid()) {
  			return;
  		}

  		function runTest() {

  			// Each of these can by async
  			ProcessingQueue.addImmediate([function () {
  				test.before();
  			}, test.hooks("before"), function () {
  				test.preserveTestEnvironment();
  			}, test.hooks("beforeEach"), function () {
  				test.run();
  			}, test.hooks("afterEach").reverse(), test.hooks("after").reverse(), function () {
  				test.after();
  			}, function () {
  				test.finish();
  			}]);
  		}

  		var previousFailCount = config.storage && +config.storage.getItem("qunit-test-" + this.module.name + "-" + this.testName);

  		// Prioritize previously failed tests, detected from storage
  		var prioritize = config.reorder && !!previousFailCount;

  		this.previousFailure = !!previousFailCount;

  		ProcessingQueue.add(runTest, prioritize, config.seed);

  		// If the queue has already finished, we manually process the new test
  		if (ProcessingQueue.finished) {
  			ProcessingQueue.advance();
  		}
  	},


  	pushResult: function pushResult(resultInfo) {
  		if (this !== config.current) {
  			throw new Error("Assertion occurred after test had finished.");
  		}

  		// Destructure of resultInfo = { result, actual, expected, message, negative }
  		var source,
  		    details = {
  			module: this.module.name,
  			name: this.testName,
  			result: resultInfo.result,
  			message: resultInfo.message,
  			actual: resultInfo.actual,
  			testId: this.testId,
  			negative: resultInfo.negative || false,
  			runtime: now() - this.started,
  			todo: !!this.todo
  		};

  		if (hasOwn.call(resultInfo, "expected")) {
  			details.expected = resultInfo.expected;
  		}

  		if (!resultInfo.result) {
  			source = resultInfo.source || sourceFromStacktrace();

  			if (source) {
  				details.source = source;
  			}
  		}

  		this.logAssertion(details);

  		this.assertions.push({
  			result: !!resultInfo.result,
  			message: resultInfo.message
  		});
  	},

  	pushFailure: function pushFailure(message, source, actual) {
  		if (!(this instanceof Test)) {
  			throw new Error("pushFailure() assertion outside test context, was " + sourceFromStacktrace(2));
  		}

  		this.pushResult({
  			result: false,
  			message: message || "error",
  			actual: actual || null,
  			source: source
  		});
  	},

  	/**
    * Log assertion details using both the old QUnit.log interface and
    * QUnit.on( "assertion" ) interface.
    *
    * @private
    */
  	logAssertion: function logAssertion(details) {
  		runLoggingCallbacks("log", details);

  		var assertion = {
  			passed: details.result,
  			actual: details.actual,
  			expected: details.expected,
  			message: details.message,
  			stack: details.source,
  			todo: details.todo
  		};
  		this.testReport.pushAssertion(assertion);
  		emit("assertion", assertion);
  	},


  	resolvePromise: function resolvePromise(promise, phase) {
  		var then,
  		    resume,
  		    message,
  		    test = this;
  		if (promise != null) {
  			then = promise.then;
  			if (objectType(then) === "function") {
  				resume = internalStop(test);
  				if (config.notrycatch) {
  					then.call(promise, function () {
  						resume();
  					});
  				} else {
  					then.call(promise, function () {
  						resume();
  					}, function (error) {
  						message = "Promise rejected " + (!phase ? "during" : phase.replace(/Each$/, "")) + " \"" + test.testName + "\": " + (error && error.message || error);
  						test.pushFailure(message, extractStacktrace(error, 0));

  						// Else next test will carry the responsibility
  						saveGlobal();

  						// Unblock
  						resume();
  					});
  				}
  			}
  		}
  	},

  	valid: function valid() {
  		var filter = config.filter,
  		    regexFilter = /^(!?)\/([\w\W]*)\/(i?$)/.exec(filter),
  		    module = config.module && config.module.toLowerCase(),
  		    fullName = this.module.name + ": " + this.testName;

  		function moduleChainNameMatch(testModule) {
  			var testModuleName = testModule.name ? testModule.name.toLowerCase() : null;
  			if (testModuleName === module) {
  				return true;
  			} else if (testModule.parentModule) {
  				return moduleChainNameMatch(testModule.parentModule);
  			} else {
  				return false;
  			}
  		}

  		function moduleChainIdMatch(testModule) {
  			return inArray(testModule.moduleId, config.moduleId) || testModule.parentModule && moduleChainIdMatch(testModule.parentModule);
  		}

  		// Internally-generated tests are always valid
  		if (this.callback && this.callback.validTest) {
  			return true;
  		}

  		if (config.moduleId && config.moduleId.length > 0 && !moduleChainIdMatch(this.module)) {

  			return false;
  		}

  		if (config.testId && config.testId.length > 0 && !inArray(this.testId, config.testId)) {

  			return false;
  		}

  		if (module && !moduleChainNameMatch(this.module)) {
  			return false;
  		}

  		if (!filter) {
  			return true;
  		}

  		return regexFilter ? this.regexFilter(!!regexFilter[1], regexFilter[2], regexFilter[3], fullName) : this.stringFilter(filter, fullName);
  	},

  	regexFilter: function regexFilter(exclude, pattern, flags, fullName) {
  		var regex = new RegExp(pattern, flags);
  		var match = regex.test(fullName);

  		return match !== exclude;
  	},

  	stringFilter: function stringFilter(filter, fullName) {
  		filter = filter.toLowerCase();
  		fullName = fullName.toLowerCase();

  		var include = filter.charAt(0) !== "!";
  		if (!include) {
  			filter = filter.slice(1);
  		}

  		// If the filter matches, we need to honour include
  		if (fullName.indexOf(filter) !== -1) {
  			return include;
  		}

  		// Otherwise, do the opposite
  		return !include;
  	}
  };

  function pushFailure() {
  	if (!config.current) {
  		throw new Error("pushFailure() assertion outside test context, in " + sourceFromStacktrace(2));
  	}

  	// Gets current test obj
  	var currentTest = config.current;

  	return currentTest.pushFailure.apply(currentTest, arguments);
  }

  function saveGlobal() {
  	config.pollution = [];

  	if (config.noglobals) {
  		for (var key in global$1) {
  			if (hasOwn.call(global$1, key)) {

  				// In Opera sometimes DOM element ids show up here, ignore them
  				if (/^qunit-test-output/.test(key)) {
  					continue;
  				}
  				config.pollution.push(key);
  			}
  		}
  	}
  }

  function checkPollution() {
  	var newGlobals,
  	    deletedGlobals,
  	    old = config.pollution;

  	saveGlobal();

  	newGlobals = diff(config.pollution, old);
  	if (newGlobals.length > 0) {
  		pushFailure("Introduced global variable(s): " + newGlobals.join(", "));
  	}

  	deletedGlobals = diff(old, config.pollution);
  	if (deletedGlobals.length > 0) {
  		pushFailure("Deleted global variable(s): " + deletedGlobals.join(", "));
  	}
  }

  // Will be exposed as QUnit.test
  function test(testName, callback) {
  	if (focused$1) {
  		return;
  	}

  	var newTest = new Test({
  		testName: testName,
  		callback: callback
  	});

  	newTest.queue();
  }

  function todo(testName, callback) {
  	if (focused$1) {
  		return;
  	}

  	var newTest = new Test({
  		testName: testName,
  		callback: callback,
  		todo: true
  	});

  	newTest.queue();
  }

  // Will be exposed as QUnit.skip
  function skip(testName) {
  	if (focused$1) {
  		return;
  	}

  	var test = new Test({
  		testName: testName,
  		skip: true
  	});

  	test.queue();
  }

  // Will be exposed as QUnit.only
  function only(testName, callback) {
  	if (focused$1) {
  		return;
  	}

  	config.queue.length = 0;
  	focused$1 = true;

  	var newTest = new Test({
  		testName: testName,
  		callback: callback
  	});

  	newTest.queue();
  }

  // Put a hold on processing and return a function that will release it.
  function internalStop(test) {
  	test.semaphore += 1;
  	config.blocking = true;

  	// Set a recovery timeout, if so configured.
  	if (defined.setTimeout) {
  		var timeoutDuration = void 0;

  		if (typeof test.timeout === "number") {
  			timeoutDuration = test.timeout;
  		} else if (typeof config.testTimeout === "number") {
  			timeoutDuration = config.testTimeout;
  		}

  		if (typeof timeoutDuration === "number" && timeoutDuration > 0) {
  			clearTimeout(config.timeout);
  			config.timeout = setTimeout(function () {
  				pushFailure("Test took longer than " + timeoutDuration + "ms; test timed out.", sourceFromStacktrace(2));
  				internalRecover(test);
  			}, timeoutDuration);
  		}
  	}

  	var released = false;
  	return function resume() {
  		if (released) {
  			return;
  		}

  		released = true;
  		test.semaphore -= 1;
  		internalStart(test);
  	};
  }

  // Forcefully release all processing holds.
  function internalRecover(test) {
  	test.semaphore = 0;
  	internalStart(test);
  }

  // Release a processing hold, scheduling a resumption attempt if no holds remain.
  function internalStart(test) {

  	// If semaphore is non-numeric, throw error
  	if (isNaN(test.semaphore)) {
  		test.semaphore = 0;

  		pushFailure("Invalid value on test.semaphore", sourceFromStacktrace(2));
  		return;
  	}

  	// Don't start until equal number of stop-calls
  	if (test.semaphore > 0) {
  		return;
  	}

  	// Throw an Error if start is called more often than stop
  	if (test.semaphore < 0) {
  		test.semaphore = 0;

  		pushFailure("Tried to restart test while already started (test's semaphore was 0 already)", sourceFromStacktrace(2));
  		return;
  	}

  	// Add a slight delay to allow more assertions etc.
  	if (defined.setTimeout) {
  		if (config.timeout) {
  			clearTimeout(config.timeout);
  		}
  		config.timeout = setTimeout(function () {
  			if (test.semaphore > 0) {
  				return;
  			}

  			if (config.timeout) {
  				clearTimeout(config.timeout);
  			}

  			begin();
  		});
  	} else {
  		begin();
  	}
  }

  function collectTests(module) {
  	var tests = [].concat(module.tests);
  	var modules = [].concat(toConsumableArray(module.childModules));

  	// Do a breadth-first traversal of the child modules
  	while (modules.length) {
  		var nextModule = modules.shift();
  		tests.push.apply(tests, nextModule.tests);
  		modules.push.apply(modules, toConsumableArray(nextModule.childModules));
  	}

  	return tests;
  }

  function numberOfTests(module) {
  	return collectTests(module).length;
  }

  function numberOfUnskippedTests(module) {
  	return collectTests(module).filter(function (test) {
  		return !test.skip;
  	}).length;
  }

  function notifyTestsRan(module, skipped) {
  	module.testsRun++;
  	if (!skipped) {
  		module.unskippedTestsRun++;
  	}
  	while (module = module.parentModule) {
  		module.testsRun++;
  		if (!skipped) {
  			module.unskippedTestsRun++;
  		}
  	}
  }

  /**
   * Returns a function that proxies to the given method name on the globals
   * console object. The proxy will also detect if the console doesn't exist and
   * will appropriately no-op. This allows support for IE9, which doesn't have a
   * console if the developer tools are not open.
   */
  function consoleProxy(method) {
  	return function () {
  		if (console) {
  			console[method].apply(console, arguments);
  		}
  	};
  }

  var Logger = {
  	warn: consoleProxy("warn")
  };

  var Assert = function () {
  	function Assert(testContext) {
  		classCallCheck(this, Assert);

  		this.test = testContext;
  	}

  	// Assert helpers

  	createClass(Assert, [{
  		key: "timeout",
  		value: function timeout(duration) {
  			if (typeof duration !== "number") {
  				throw new Error("You must pass a number as the duration to assert.timeout");
  			}

  			this.test.timeout = duration;
  		}

  		// Documents a "step", which is a string value, in a test as a passing assertion

  	}, {
  		key: "step",
  		value: function step(message) {
  			var result = !!message;

  			this.test.steps.push(message);

  			return this.pushResult({
  				result: result,
  				message: message || "You must provide a message to assert.step"
  			});
  		}

  		// Verifies the steps in a test match a given array of string values

  	}, {
  		key: "verifySteps",
  		value: function verifySteps(steps, message) {
  			this.deepEqual(this.test.steps, steps, message);
  			this.test.steps.length = 0;
  		}

  		// Specify the number of expected assertions to guarantee that failed test
  		// (no assertions are run at all) don't slip through.

  	}, {
  		key: "expect",
  		value: function expect(asserts) {
  			if (arguments.length === 1) {
  				this.test.expected = asserts;
  			} else {
  				return this.test.expected;
  			}
  		}

  		// Put a hold on processing and return a function that will release it a maximum of once.

  	}, {
  		key: "async",
  		value: function async(count) {
  			var test$$1 = this.test;

  			var popped = false,
  			    acceptCallCount = count;

  			if (typeof acceptCallCount === "undefined") {
  				acceptCallCount = 1;
  			}

  			var resume = internalStop(test$$1);

  			return function done() {
  				if (config.current !== test$$1) {
  					throw Error("assert.async callback called after test finished.");
  				}

  				if (popped) {
  					test$$1.pushFailure("Too many calls to the `assert.async` callback", sourceFromStacktrace(2));
  					return;
  				}

  				acceptCallCount -= 1;
  				if (acceptCallCount > 0) {
  					return;
  				}

  				popped = true;
  				resume();
  			};
  		}

  		// Exports test.push() to the user API
  		// Alias of pushResult.

  	}, {
  		key: "push",
  		value: function push(result, actual, expected, message, negative) {
  			Logger.warn("assert.push is deprecated and will be removed in QUnit 3.0." + " Please use assert.pushResult instead (https://api.qunitjs.com/assert/pushResult).");

  			var currentAssert = this instanceof Assert ? this : config.current.assert;
  			return currentAssert.pushResult({
  				result: result,
  				actual: actual,
  				expected: expected,
  				message: message,
  				negative: negative
  			});
  		}
  	}, {
  		key: "pushResult",
  		value: function pushResult(resultInfo) {

  			// Destructure of resultInfo = { result, actual, expected, message, negative }
  			var assert = this;
  			var currentTest = assert instanceof Assert && assert.test || config.current;

  			// Backwards compatibility fix.
  			// Allows the direct use of global exported assertions and QUnit.assert.*
  			// Although, it's use is not recommended as it can leak assertions
  			// to other tests from async tests, because we only get a reference to the current test,
  			// not exactly the test where assertion were intended to be called.
  			if (!currentTest) {
  				throw new Error("assertion outside test context, in " + sourceFromStacktrace(2));
  			}

  			if (!(assert instanceof Assert)) {
  				assert = currentTest.assert;
  			}

  			return assert.test.pushResult(resultInfo);
  		}
  	}, {
  		key: "ok",
  		value: function ok(result, message) {
  			if (!message) {
  				message = result ? "okay" : "failed, expected argument to be truthy, was: " + dump.parse(result);
  			}

  			this.pushResult({
  				result: !!result,
  				actual: result,
  				expected: true,
  				message: message
  			});
  		}
  	}, {
  		key: "notOk",
  		value: function notOk(result, message) {
  			if (!message) {
  				message = !result ? "okay" : "failed, expected argument to be falsy, was: " + dump.parse(result);
  			}

  			this.pushResult({
  				result: !result,
  				actual: result,
  				expected: false,
  				message: message
  			});
  		}
  	}, {
  		key: "equal",
  		value: function equal(actual, expected, message) {

  			// eslint-disable-next-line eqeqeq
  			var result = expected == actual;

  			this.pushResult({
  				result: result,
  				actual: actual,
  				expected: expected,
  				message: message
  			});
  		}
  	}, {
  		key: "notEqual",
  		value: function notEqual(actual, expected, message) {

  			// eslint-disable-next-line eqeqeq
  			var result = expected != actual;

  			this.pushResult({
  				result: result,
  				actual: actual,
  				expected: expected,
  				message: message,
  				negative: true
  			});
  		}
  	}, {
  		key: "propEqual",
  		value: function propEqual(actual, expected, message) {
  			actual = objectValues(actual);
  			expected = objectValues(expected);

  			this.pushResult({
  				result: equiv(actual, expected),
  				actual: actual,
  				expected: expected,
  				message: message
  			});
  		}
  	}, {
  		key: "notPropEqual",
  		value: function notPropEqual(actual, expected, message) {
  			actual = objectValues(actual);
  			expected = objectValues(expected);

  			this.pushResult({
  				result: !equiv(actual, expected),
  				actual: actual,
  				expected: expected,
  				message: message,
  				negative: true
  			});
  		}
  	}, {
  		key: "deepEqual",
  		value: function deepEqual(actual, expected, message) {
  			this.pushResult({
  				result: equiv(actual, expected),
  				actual: actual,
  				expected: expected,
  				message: message
  			});
  		}
  	}, {
  		key: "notDeepEqual",
  		value: function notDeepEqual(actual, expected, message) {
  			this.pushResult({
  				result: !equiv(actual, expected),
  				actual: actual,
  				expected: expected,
  				message: message,
  				negative: true
  			});
  		}
  	}, {
  		key: "strictEqual",
  		value: function strictEqual(actual, expected, message) {
  			this.pushResult({
  				result: expected === actual,
  				actual: actual,
  				expected: expected,
  				message: message
  			});
  		}
  	}, {
  		key: "notStrictEqual",
  		value: function notStrictEqual(actual, expected, message) {
  			this.pushResult({
  				result: expected !== actual,
  				actual: actual,
  				expected: expected,
  				message: message,
  				negative: true
  			});
  		}
  	}, {
  		key: "throws",
  		value: function throws(block, expected, message) {
  			var actual = void 0,
  			    result = false;

  			var currentTest = this instanceof Assert && this.test || config.current;

  			// 'expected' is optional unless doing string comparison
  			if (objectType(expected) === "string") {
  				if (message == null) {
  					message = expected;
  					expected = null;
  				} else {
  					throw new Error("throws/raises does not accept a string value for the expected argument.\n" + "Use a non-string object value (e.g. regExp) instead if it's necessary.");
  				}
  			}

  			currentTest.ignoreGlobalErrors = true;
  			try {
  				block.call(currentTest.testEnvironment);
  			} catch (e) {
  				actual = e;
  			}
  			currentTest.ignoreGlobalErrors = false;

  			if (actual) {
  				var expectedType = objectType(expected);

  				// We don't want to validate thrown error
  				if (!expected) {
  					result = true;
  					expected = null;

  					// Expected is a regexp
  				} else if (expectedType === "regexp") {
  					result = expected.test(errorString(actual));

  					// Expected is a constructor, maybe an Error constructor
  				} else if (expectedType === "function" && actual instanceof expected) {
  					result = true;

  					// Expected is an Error object
  				} else if (expectedType === "object") {
  					result = actual instanceof expected.constructor && actual.name === expected.name && actual.message === expected.message;

  					// Expected is a validation function which returns true if validation passed
  				} else if (expectedType === "function" && expected.call({}, actual) === true) {
  					expected = null;
  					result = true;
  				}
  			}

  			currentTest.assert.pushResult({
  				result: result,
  				actual: actual,
  				expected: expected,
  				message: message
  			});
  		}
  	}, {
  		key: "rejects",
  		value: function rejects(promise, expected, message) {
  			var result = false;

  			var currentTest = this instanceof Assert && this.test || config.current;

  			// 'expected' is optional unless doing string comparison
  			if (objectType(expected) === "string") {
  				if (message === undefined) {
  					message = expected;
  					expected = undefined;
  				} else {
  					message = "assert.rejects does not accept a string value for the expected " + "argument.\nUse a non-string object value (e.g. validator function) instead " + "if necessary.";

  					currentTest.assert.pushResult({
  						result: false,
  						message: message
  					});

  					return;
  				}
  			}

  			var then = promise && promise.then;
  			if (objectType(then) !== "function") {
  				var _message = "The value provided to `assert.rejects` in " + "\"" + currentTest.testName + "\" was not a promise.";

  				currentTest.assert.pushResult({
  					result: false,
  					message: _message,
  					actual: promise
  				});

  				return;
  			}

  			var done = this.async();

  			return then.call(promise, function handleFulfillment() {
  				var message = "The promise returned by the `assert.rejects` callback in " + "\"" + currentTest.testName + "\" did not reject.";

  				currentTest.assert.pushResult({
  					result: false,
  					message: message,
  					actual: promise
  				});

  				done();
  			}, function handleRejection(actual) {
  				if (actual) {
  					var expectedType = objectType(expected);

  					// We don't want to validate
  					if (expected === undefined) {
  						result = true;
  						expected = null;

  						// Expected is a regexp
  					} else if (expectedType === "regexp") {
  						result = expected.test(errorString(actual));

  						// Expected is a constructor, maybe an Error constructor
  					} else if (expectedType === "function" && actual instanceof expected) {
  						result = true;

  						// Expected is an Error object
  					} else if (expectedType === "object") {
  						result = actual instanceof expected.constructor && actual.name === expected.name && actual.message === expected.message;

  						// Expected is a validation function which returns true if validation passed
  					} else {
  						if (expectedType === "function") {
  							result = expected.call({}, actual) === true;
  							expected = null;

  							// Expected is some other invalid type
  						} else {
  							result = false;
  							message = "invalid expected value provided to `assert.rejects` " + "callback in \"" + currentTest.testName + "\": " + expectedType + ".";
  						}
  					}
  				}

  				currentTest.assert.pushResult({
  					result: result,
  					actual: actual,
  					expected: expected,
  					message: message
  				});

  				done();
  			});
  		}
  	}]);
  	return Assert;
  }();

  // Provide an alternative to assert.throws(), for environments that consider throws a reserved word
  // Known to us are: Closure Compiler, Narwhal
  // eslint-disable-next-line dot-notation


  Assert.prototype.raises = Assert.prototype["throws"];

  /**
   * Converts an error into a simple string for comparisons.
   *
   * @param {Error} error
   * @return {String}
   */
  function errorString(error) {
  	var resultErrorString = error.toString();

  	if (resultErrorString.substring(0, 7) === "[object") {
  		var name = error.name ? error.name.toString() : "Error";
  		var message = error.message ? error.message.toString() : "";

  		if (name && message) {
  			return name + ": " + message;
  		} else if (name) {
  			return name;
  		} else if (message) {
  			return message;
  		} else {
  			return "Error";
  		}
  	} else {
  		return resultErrorString;
  	}
  }

  /* global module, exports, define */
  function exportQUnit(QUnit) {

  	if (defined.document) {

  		// QUnit may be defined when it is preconfigured but then only QUnit and QUnit.config may be defined.
  		if (window.QUnit && window.QUnit.version) {
  			throw new Error("QUnit has already been defined.");
  		}

  		window.QUnit = QUnit;
  	}

  	// For nodejs
  	if (typeof module !== "undefined" && module && module.exports) {
  		module.exports = QUnit;

  		// For consistency with CommonJS environments' exports
  		module.exports.QUnit = QUnit;
  	}

  	// For CommonJS with exports, but without module.exports, like Rhino
  	if (typeof exports !== "undefined" && exports) {
  		exports.QUnit = QUnit;
  	}

  	// For Web/Service Workers
  	if (self$1 && self$1.WorkerGlobalScope && self$1 instanceof self$1.WorkerGlobalScope) {
  		self$1.QUnit = QUnit;
  	}
  }

  var SuiteReport = function () {
  	function SuiteReport(name, parentSuite) {
  		classCallCheck(this, SuiteReport);

  		this.name = name;
  		this.fullName = parentSuite ? parentSuite.fullName.concat(name) : [];

  		this.tests = [];
  		this.childSuites = [];

  		if (parentSuite) {
  			parentSuite.pushChildSuite(this);
  		}
  	}

  	createClass(SuiteReport, [{
  		key: "start",
  		value: function start(recordTime) {
  			if (recordTime) {
  				this._startTime = Date.now();
  			}

  			return {
  				name: this.name,
  				fullName: this.fullName.slice(),
  				tests: this.tests.map(function (test) {
  					return test.start();
  				}),
  				childSuites: this.childSuites.map(function (suite) {
  					return suite.start();
  				}),
  				testCounts: {
  					total: this.getTestCounts().total
  				}
  			};
  		}
  	}, {
  		key: "end",
  		value: function end(recordTime) {
  			if (recordTime) {
  				this._endTime = Date.now();
  			}

  			return {
  				name: this.name,
  				fullName: this.fullName.slice(),
  				tests: this.tests.map(function (test) {
  					return test.end();
  				}),
  				childSuites: this.childSuites.map(function (suite) {
  					return suite.end();
  				}),
  				testCounts: this.getTestCounts(),
  				runtime: this.getRuntime(),
  				status: this.getStatus()
  			};
  		}
  	}, {
  		key: "pushChildSuite",
  		value: function pushChildSuite(suite) {
  			this.childSuites.push(suite);
  		}
  	}, {
  		key: "pushTest",
  		value: function pushTest(test) {
  			this.tests.push(test);
  		}
  	}, {
  		key: "getRuntime",
  		value: function getRuntime() {
  			return this._endTime - this._startTime;
  		}
  	}, {
  		key: "getTestCounts",
  		value: function getTestCounts() {
  			var counts = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : { passed: 0, failed: 0, skipped: 0, todo: 0, total: 0 };

  			counts = this.tests.reduce(function (counts, test) {
  				if (test.valid) {
  					counts[test.getStatus()]++;
  					counts.total++;
  				}

  				return counts;
  			}, counts);

  			return this.childSuites.reduce(function (counts, suite) {
  				return suite.getTestCounts(counts);
  			}, counts);
  		}
  	}, {
  		key: "getStatus",
  		value: function getStatus() {
  			var _getTestCounts = this.getTestCounts(),
  			    total = _getTestCounts.total,
  			    failed = _getTestCounts.failed,
  			    skipped = _getTestCounts.skipped,
  			    todo = _getTestCounts.todo;

  			if (failed) {
  				return "failed";
  			} else {
  				if (skipped === total) {
  					return "skipped";
  				} else if (todo === total) {
  					return "todo";
  				} else {
  					return "passed";
  				}
  			}
  		}
  	}]);
  	return SuiteReport;
  }();

  // Handle an unhandled exception. By convention, returns true if further
  // error handling should be suppressed and false otherwise.
  // In this case, we will only suppress further error handling if the
  // "ignoreGlobalErrors" configuration option is enabled.
  function onError(error) {
  	for (var _len = arguments.length, args = Array(_len > 1 ? _len - 1 : 0), _key = 1; _key < _len; _key++) {
  		args[_key - 1] = arguments[_key];
  	}

  	if (config.current) {
  		if (config.current.ignoreGlobalErrors) {
  			return true;
  		}
  		pushFailure.apply(undefined, [error.message, error.fileName + ":" + error.lineNumber].concat(args));
  	} else {
  		test("global failure", extend(function () {
  			pushFailure.apply(undefined, [error.message, error.fileName + ":" + error.lineNumber].concat(args));
  		}, { validTest: true }));
  	}

  	return false;
  }

  // Handle an unhandled rejection
  function onUnhandledRejection(reason) {
  	var resultInfo = {
  		result: false,
  		message: reason.message || "error",
  		actual: reason,
  		source: reason.stack || sourceFromStacktrace(3)
  	};

  	var currentTest = config.current;
  	if (currentTest) {
  		currentTest.assert.pushResult(resultInfo);
  	} else {
  		test("global failure", extend(function (assert) {
  			assert.pushResult(resultInfo);
  		}, { validTest: true }));
  	}
  }

  var focused = false;
  var QUnit = {};
  var globalSuite = new SuiteReport();

  // The initial "currentModule" represents the global (or top-level) module that
  // is not explicitly defined by the user, therefore we add the "globalSuite" to
  // it since each module has a suiteReport associated with it.
  config.currentModule.suiteReport = globalSuite;

  var moduleStack = [];
  var globalStartCalled = false;
  var runStarted = false;

  // Figure out if we're running the tests from a server or not
  QUnit.isLocal = !(defined.document && window.location.protocol !== "file:");

  // Expose the current QUnit version
  QUnit.version = "2.5.0";

  function createModule(name, testEnvironment, modifiers) {
  	var parentModule = moduleStack.length ? moduleStack.slice(-1)[0] : null;
  	var moduleName = parentModule !== null ? [parentModule.name, name].join(" > ") : name;
  	var parentSuite = parentModule ? parentModule.suiteReport : globalSuite;

  	var skip$$1 = parentModule !== null && parentModule.skip || modifiers.skip;
  	var todo$$1 = parentModule !== null && parentModule.todo || modifiers.todo;

  	var module = {
  		name: moduleName,
  		parentModule: parentModule,
  		tests: [],
  		moduleId: generateHash(moduleName),
  		testsRun: 0,
  		unskippedTestsRun: 0,
  		childModules: [],
  		suiteReport: new SuiteReport(name, parentSuite),

  		// Pass along `skip` and `todo` properties from parent module, in case
  		// there is one, to childs. And use own otherwise.
  		// This property will be used to mark own tests and tests of child suites
  		// as either `skipped` or `todo`.
  		skip: skip$$1,
  		todo: skip$$1 ? false : todo$$1
  	};

  	var env = {};
  	if (parentModule) {
  		parentModule.childModules.push(module);
  		extend(env, parentModule.testEnvironment);
  	}
  	extend(env, testEnvironment);
  	module.testEnvironment = env;

  	config.modules.push(module);
  	return module;
  }

  function processModule(name, options, executeNow) {
  	var modifiers = arguments.length > 3 && arguments[3] !== undefined ? arguments[3] : {};

  	var module = createModule(name, options, modifiers);

  	// Move any hooks to a 'hooks' object
  	var testEnvironment = module.testEnvironment;
  	var hooks = module.hooks = {};

  	setHookFromEnvironment(hooks, testEnvironment, "before");
  	setHookFromEnvironment(hooks, testEnvironment, "beforeEach");
  	setHookFromEnvironment(hooks, testEnvironment, "afterEach");
  	setHookFromEnvironment(hooks, testEnvironment, "after");

  	function setHookFromEnvironment(hooks, environment, name) {
  		var potentialHook = environment[name];
  		hooks[name] = typeof potentialHook === "function" ? [potentialHook] : [];
  		delete environment[name];
  	}

  	var moduleFns = {
  		before: setHookFunction(module, "before"),
  		beforeEach: setHookFunction(module, "beforeEach"),
  		afterEach: setHookFunction(module, "afterEach"),
  		after: setHookFunction(module, "after")
  	};

  	var currentModule = config.currentModule;
  	if (objectType(executeNow) === "function") {
  		moduleStack.push(module);
  		config.currentModule = module;
  		executeNow.call(module.testEnvironment, moduleFns);
  		moduleStack.pop();
  		module = module.parentModule || currentModule;
  	}

  	config.currentModule = module;
  }

  // TODO: extract this to a new file alongside its related functions
  function module$1(name, options, executeNow) {
  	if (focused) {
  		return;
  	}

  	if (arguments.length === 2) {
  		if (objectType(options) === "function") {
  			executeNow = options;
  			options = undefined;
  		}
  	}

  	processModule(name, options, executeNow);
  }

  module$1.only = function () {
  	if (focused) {
  		return;
  	}

  	config.modules.length = 0;
  	config.queue.length = 0;

  	module$1.apply(undefined, arguments);

  	focused = true;
  };

  module$1.skip = function (name, options, executeNow) {
  	if (focused) {
  		return;
  	}

  	if (arguments.length === 2) {
  		if (objectType(options) === "function") {
  			executeNow = options;
  			options = undefined;
  		}
  	}

  	processModule(name, options, executeNow, { skip: true });
  };

  module$1.todo = function (name, options, executeNow) {
  	if (focused) {
  		return;
  	}

  	if (arguments.length === 2) {
  		if (objectType(options) === "function") {
  			executeNow = options;
  			options = undefined;
  		}
  	}

  	processModule(name, options, executeNow, { todo: true });
  };

  extend(QUnit, {
  	on: on,

  	module: module$1,

  	test: test,

  	todo: todo,

  	skip: skip,

  	only: only,

  	start: function start(count) {
  		var globalStartAlreadyCalled = globalStartCalled;

  		if (!config.current) {
  			globalStartCalled = true;

  			if (runStarted) {
  				throw new Error("Called start() while test already started running");
  			} else if (globalStartAlreadyCalled || count > 1) {
  				throw new Error("Called start() outside of a test context too many times");
  			} else if (config.autostart) {
  				throw new Error("Called start() outside of a test context when " + "QUnit.config.autostart was true");
  			} else if (!config.pageLoaded) {

  				// The page isn't completely loaded yet, so we set autostart and then
  				// load if we're in Node or wait for the browser's load event.
  				config.autostart = true;

  				// Starts from Node even if .load was not previously called. We still return
  				// early otherwise we'll wind up "beginning" twice.
  				if (!defined.document) {
  					QUnit.load();
  				}

  				return;
  			}
  		} else {
  			throw new Error("QUnit.start cannot be called inside a test context.");
  		}

  		scheduleBegin();
  	},

  	config: config,

  	is: is,

  	objectType: objectType,

  	extend: extend,

  	load: function load() {
  		config.pageLoaded = true;

  		// Initialize the configuration options
  		extend(config, {
  			stats: { all: 0, bad: 0 },
  			started: 0,
  			updateRate: 1000,
  			autostart: true,
  			filter: ""
  		}, true);

  		if (!runStarted) {
  			config.blocking = false;

  			if (config.autostart) {
  				scheduleBegin();
  			}
  		}
  	},

  	stack: function stack(offset) {
  		offset = (offset || 0) + 2;
  		return sourceFromStacktrace(offset);
  	},

  	onError: onError,

  	onUnhandledRejection: onUnhandledRejection
  });

  QUnit.pushFailure = pushFailure;
  QUnit.assert = Assert.prototype;
  QUnit.equiv = equiv;
  QUnit.dump = dump;

  registerLoggingCallbacks(QUnit);

  function scheduleBegin() {

  	runStarted = true;

  	// Add a slight delay to allow definition of more modules and tests.
  	if (defined.setTimeout) {
  		setTimeout(function () {
  			begin();
  		});
  	} else {
  		begin();
  	}
  }

  function begin() {
  	var i,
  	    l,
  	    modulesLog = [];

  	// If the test run hasn't officially begun yet
  	if (!config.started) {

  		// Record the time of the test run's beginning
  		config.started = now();

  		// Delete the loose unnamed module if unused.
  		if (config.modules[0].name === "" && config.modules[0].tests.length === 0) {
  			config.modules.shift();
  		}

  		// Avoid unnecessary information by not logging modules' test environments
  		for (i = 0, l = config.modules.length; i < l; i++) {
  			modulesLog.push({
  				name: config.modules[i].name,
  				tests: config.modules[i].tests
  			});
  		}

  		// The test run is officially beginning now
  		emit("runStart", globalSuite.start(true));
  		runLoggingCallbacks("begin", {
  			totalTests: Test.count,
  			modules: modulesLog
  		});
  	}

  	config.blocking = false;
  	ProcessingQueue.advance();
  }

  function setHookFunction(module, hookName) {
  	return function setHook(callback) {
  		module.hooks[hookName].push(callback);
  	};
  }

  exportQUnit(QUnit);

  (function () {

  	if (typeof window === "undefined" || typeof document === "undefined") {
  		return;
  	}

  	var config = QUnit.config,
  	    hasOwn = Object.prototype.hasOwnProperty;

  	// Stores fixture HTML for resetting later
  	function storeFixture() {

  		// Avoid overwriting user-defined values
  		if (hasOwn.call(config, "fixture")) {
  			return;
  		}

  		var fixture = document.getElementById("qunit-fixture");
  		if (fixture) {
  			config.fixture = fixture.innerHTML;
  		}
  	}

  	QUnit.begin(storeFixture);

  	// Resets the fixture DOM element if available.
  	function resetFixture() {
  		if (config.fixture == null) {
  			return;
  		}

  		var fixture = document.getElementById("qunit-fixture");
  		if (fixture) {
  			fixture.innerHTML = config.fixture;
  		}
  	}

  	QUnit.testStart(resetFixture);
  })();

  (function () {

  	// Only interact with URLs via window.location
  	var location = typeof window !== "undefined" && window.location;
  	if (!location) {
  		return;
  	}

  	var urlParams = getUrlParams();

  	QUnit.urlParams = urlParams;

  	// Match module/test by inclusion in an array
  	QUnit.config.moduleId = [].concat(urlParams.moduleId || []);
  	QUnit.config.testId = [].concat(urlParams.testId || []);

  	// Exact case-insensitive match of the module name
  	QUnit.config.module = urlParams.module;

  	// Regular expression or case-insenstive substring match against "moduleName: testName"
  	QUnit.config.filter = urlParams.filter;

  	// Test order randomization
  	if (urlParams.seed === true) {

  		// Generate a random seed if the option is specified without a value
  		QUnit.config.seed = Math.random().toString(36).slice(2);
  	} else if (urlParams.seed) {
  		QUnit.config.seed = urlParams.seed;
  	}

  	// Add URL-parameter-mapped config values with UI form rendering data
  	QUnit.config.urlConfig.push({
  		id: "hidepassed",
  		label: "Hide passed tests",
  		tooltip: "Only show tests and assertions that fail. Stored as query-strings."
  	}, {
  		id: "noglobals",
  		label: "Check for Globals",
  		tooltip: "Enabling this will test if any test introduces new properties on the " + "global object (`window` in Browsers). Stored as query-strings."
  	}, {
  		id: "notrycatch",
  		label: "No try-catch",
  		tooltip: "Enabling this will run tests outside of a try-catch block. Makes debugging " + "exceptions in IE reasonable. Stored as query-strings."
  	});

  	QUnit.begin(function () {
  		var i,
  		    option,
  		    urlConfig = QUnit.config.urlConfig;

  		for (i = 0; i < urlConfig.length; i++) {

  			// Options can be either strings or objects with nonempty "id" properties
  			option = QUnit.config.urlConfig[i];
  			if (typeof option !== "string") {
  				option = option.id;
  			}

  			if (QUnit.config[option] === undefined) {
  				QUnit.config[option] = urlParams[option];
  			}
  		}
  	});

  	function getUrlParams() {
  		var i, param, name, value;
  		var urlParams = Object.create(null);
  		var params = location.search.slice(1).split("&");
  		var length = params.length;

  		for (i = 0; i < length; i++) {
  			if (params[i]) {
  				param = params[i].split("=");
  				name = decodeQueryParam(param[0]);

  				// Allow just a key to turn on a flag, e.g., test.html?noglobals
  				value = param.length === 1 || decodeQueryParam(param.slice(1).join("="));
  				if (name in urlParams) {
  					urlParams[name] = [].concat(urlParams[name], value);
  				} else {
  					urlParams[name] = value;
  				}
  			}
  		}

  		return urlParams;
  	}

  	function decodeQueryParam(param) {
  		return decodeURIComponent(param.replace(/\+/g, "%20"));
  	}
  })();

  var stats = {
  	passedTests: 0,
  	failedTests: 0,
  	skippedTests: 0,
  	todoTests: 0
  };

  // Escape text for attribute or text content.
  function escapeText(s) {
  	if (!s) {
  		return "";
  	}
  	s = s + "";

  	// Both single quotes and double quotes (for attributes)
  	return s.replace(/['"<>&]/g, function (s) {
  		switch (s) {
  			case "'":
  				return "&#039;";
  			case "\"":
  				return "&quot;";
  			case "<":
  				return "&lt;";
  			case ">":
  				return "&gt;";
  			case "&":
  				return "&amp;";
  		}
  	});
  }

  (function () {

  	// Don't load the HTML Reporter on non-browser environments
  	if (typeof window === "undefined" || !window.document) {
  		return;
  	}

  	var config = QUnit.config,
  	    document$$1 = window.document,
  	    collapseNext = false,
  	    hasOwn = Object.prototype.hasOwnProperty,
  	    unfilteredUrl = setUrl({ filter: undefined, module: undefined,
  		moduleId: undefined, testId: undefined }),
  	    modulesList = [];

  	function addEvent(elem, type, fn) {
  		elem.addEventListener(type, fn, false);
  	}

  	function removeEvent(elem, type, fn) {
  		elem.removeEventListener(type, fn, false);
  	}

  	function addEvents(elems, type, fn) {
  		var i = elems.length;
  		while (i--) {
  			addEvent(elems[i], type, fn);
  		}
  	}

  	function hasClass(elem, name) {
  		return (" " + elem.className + " ").indexOf(" " + name + " ") >= 0;
  	}

  	function addClass(elem, name) {
  		if (!hasClass(elem, name)) {
  			elem.className += (elem.className ? " " : "") + name;
  		}
  	}

  	function toggleClass(elem, name, force) {
  		if (force || typeof force === "undefined" && !hasClass(elem, name)) {
  			addClass(elem, name);
  		} else {
  			removeClass(elem, name);
  		}
  	}

  	function removeClass(elem, name) {
  		var set = " " + elem.className + " ";

  		// Class name may appear multiple times
  		while (set.indexOf(" " + name + " ") >= 0) {
  			set = set.replace(" " + name + " ", " ");
  		}

  		// Trim for prettiness
  		elem.className = typeof set.trim === "function" ? set.trim() : set.replace(/^\s+|\s+$/g, "");
  	}

  	function id(name) {
  		return document$$1.getElementById && document$$1.getElementById(name);
  	}

  	function abortTests() {
  		var abortButton = id("qunit-abort-tests-button");
  		if (abortButton) {
  			abortButton.disabled = true;
  			abortButton.innerHTML = "Aborting...";
  		}
  		QUnit.config.queue.length = 0;
  		return false;
  	}

  	function interceptNavigation(ev) {
  		applyUrlParams();

  		if (ev && ev.preventDefault) {
  			ev.preventDefault();
  		}

  		return false;
  	}

  	function getUrlConfigHtml() {
  		var i,
  		    j,
  		    val,
  		    escaped,
  		    escapedTooltip,
  		    selection = false,
  		    urlConfig = config.urlConfig,
  		    urlConfigHtml = "";

  		for (i = 0; i < urlConfig.length; i++) {

  			// Options can be either strings or objects with nonempty "id" properties
  			val = config.urlConfig[i];
  			if (typeof val === "string") {
  				val = {
  					id: val,
  					label: val
  				};
  			}

  			escaped = escapeText(val.id);
  			escapedTooltip = escapeText(val.tooltip);

  			if (!val.value || typeof val.value === "string") {
  				urlConfigHtml += "<label for='qunit-urlconfig-" + escaped + "' title='" + escapedTooltip + "'><input id='qunit-urlconfig-" + escaped + "' name='" + escaped + "' type='checkbox'" + (val.value ? " value='" + escapeText(val.value) + "'" : "") + (config[val.id] ? " checked='checked'" : "") + " title='" + escapedTooltip + "' />" + escapeText(val.label) + "</label>";
  			} else {
  				urlConfigHtml += "<label for='qunit-urlconfig-" + escaped + "' title='" + escapedTooltip + "'>" + val.label + ": </label><select id='qunit-urlconfig-" + escaped + "' name='" + escaped + "' title='" + escapedTooltip + "'><option></option>";

  				if (QUnit.is("array", val.value)) {
  					for (j = 0; j < val.value.length; j++) {
  						escaped = escapeText(val.value[j]);
  						urlConfigHtml += "<option value='" + escaped + "'" + (config[val.id] === val.value[j] ? (selection = true) && " selected='selected'" : "") + ">" + escaped + "</option>";
  					}
  				} else {
  					for (j in val.value) {
  						if (hasOwn.call(val.value, j)) {
  							urlConfigHtml += "<option value='" + escapeText(j) + "'" + (config[val.id] === j ? (selection = true) && " selected='selected'" : "") + ">" + escapeText(val.value[j]) + "</option>";
  						}
  					}
  				}
  				if (config[val.id] && !selection) {
  					escaped = escapeText(config[val.id]);
  					urlConfigHtml += "<option value='" + escaped + "' selected='selected' disabled='disabled'>" + escaped + "</option>";
  				}
  				urlConfigHtml += "</select>";
  			}
  		}

  		return urlConfigHtml;
  	}

  	// Handle "click" events on toolbar checkboxes and "change" for select menus.
  	// Updates the URL with the new state of `config.urlConfig` values.
  	function toolbarChanged() {
  		var updatedUrl,
  		    value,
  		    tests,
  		    field = this,
  		    params = {};

  		// Detect if field is a select menu or a checkbox
  		if ("selectedIndex" in field) {
  			value = field.options[field.selectedIndex].value || undefined;
  		} else {
  			value = field.checked ? field.defaultValue || true : undefined;
  		}

  		params[field.name] = value;
  		updatedUrl = setUrl(params);

  		// Check if we can apply the change without a page refresh
  		if ("hidepassed" === field.name && "replaceState" in window.history) {
  			QUnit.urlParams[field.name] = value;
  			config[field.name] = value || false;
  			tests = id("qunit-tests");
  			if (tests) {
  				toggleClass(tests, "hidepass", value || false);
  			}
  			window.history.replaceState(null, "", updatedUrl);
  		} else {
  			window.location = updatedUrl;
  		}
  	}

  	function setUrl(params) {
  		var key,
  		    arrValue,
  		    i,
  		    querystring = "?",
  		    location = window.location;

  		params = QUnit.extend(QUnit.extend({}, QUnit.urlParams), params);

  		for (key in params) {

  			// Skip inherited or undefined properties
  			if (hasOwn.call(params, key) && params[key] !== undefined) {

  				// Output a parameter for each value of this key
  				// (but usually just one)
  				arrValue = [].concat(params[key]);
  				for (i = 0; i < arrValue.length; i++) {
  					querystring += encodeURIComponent(key);
  					if (arrValue[i] !== true) {
  						querystring += "=" + encodeURIComponent(arrValue[i]);
  					}
  					querystring += "&";
  				}
  			}
  		}
  		return location.protocol + "//" + location.host + location.pathname + querystring.slice(0, -1);
  	}

  	function applyUrlParams() {
  		var i,
  		    selectedModules = [],
  		    modulesList = id("qunit-modulefilter-dropdown-list").getElementsByTagName("input"),
  		    filter = id("qunit-filter-input").value;

  		for (i = 0; i < modulesList.length; i++) {
  			if (modulesList[i].checked) {
  				selectedModules.push(modulesList[i].value);
  			}
  		}

  		window.location = setUrl({
  			filter: filter === "" ? undefined : filter,
  			moduleId: selectedModules.length === 0 ? undefined : selectedModules,

  			// Remove module and testId filter
  			module: undefined,
  			testId: undefined
  		});
  	}

  	function toolbarUrlConfigContainer() {
  		var urlConfigContainer = document$$1.createElement("span");

  		urlConfigContainer.innerHTML = getUrlConfigHtml();
  		addClass(urlConfigContainer, "qunit-url-config");

  		addEvents(urlConfigContainer.getElementsByTagName("input"), "change", toolbarChanged);
  		addEvents(urlConfigContainer.getElementsByTagName("select"), "change", toolbarChanged);

  		return urlConfigContainer;
  	}

  	function abortTestsButton() {
  		var button = document$$1.createElement("button");
  		button.id = "qunit-abort-tests-button";
  		button.innerHTML = "Abort";
  		addEvent(button, "click", abortTests);
  		return button;
  	}

  	function toolbarLooseFilter() {
  		var filter = document$$1.createElement("form"),
  		    label = document$$1.createElement("label"),
  		    input = document$$1.createElement("input"),
  		    button = document$$1.createElement("button");

  		addClass(filter, "qunit-filter");

  		label.innerHTML = "Filter: ";

  		input.type = "text";
  		input.value = config.filter || "";
  		input.name = "filter";
  		input.id = "qunit-filter-input";

  		button.innerHTML = "Go";

  		label.appendChild(input);

  		filter.appendChild(label);
  		filter.appendChild(document$$1.createTextNode(" "));
  		filter.appendChild(button);
  		addEvent(filter, "submit", interceptNavigation);

  		return filter;
  	}

  	function moduleListHtml() {
  		var i,
  		    checked,
  		    html = "";

  		for (i = 0; i < config.modules.length; i++) {
  			if (config.modules[i].name !== "") {
  				checked = config.moduleId.indexOf(config.modules[i].moduleId) > -1;
  				html += "<li><label class='clickable" + (checked ? " checked" : "") + "'><input type='checkbox' " + "value='" + config.modules[i].moduleId + "'" + (checked ? " checked='checked'" : "") + " />" + escapeText(config.modules[i].name) + "</label></li>";
  			}
  		}

  		return html;
  	}

  	function toolbarModuleFilter() {
  		var allCheckbox,
  		    commit,
  		    reset,
  		    moduleFilter = document$$1.createElement("form"),
  		    label = document$$1.createElement("label"),
  		    moduleSearch = document$$1.createElement("input"),
  		    dropDown = document$$1.createElement("div"),
  		    actions = document$$1.createElement("span"),
  		    dropDownList = document$$1.createElement("ul"),
  		    dirty = false;

  		moduleSearch.id = "qunit-modulefilter-search";
  		addEvent(moduleSearch, "input", searchInput);
  		addEvent(moduleSearch, "input", searchFocus);
  		addEvent(moduleSearch, "focus", searchFocus);
  		addEvent(moduleSearch, "click", searchFocus);

  		label.id = "qunit-modulefilter-search-container";
  		label.innerHTML = "Module: ";
  		label.appendChild(moduleSearch);

  		actions.id = "qunit-modulefilter-actions";
  		actions.innerHTML = "<button style='display:none'>Apply</button>" + "<button type='reset' style='display:none'>Reset</button>" + "<label class='clickable" + (config.moduleId.length ? "" : " checked") + "'><input type='checkbox'" + (config.moduleId.length ? "" : " checked='checked'") + ">All modules</label>";
  		allCheckbox = actions.lastChild.firstChild;
  		commit = actions.firstChild;
  		reset = commit.nextSibling;
  		addEvent(commit, "click", applyUrlParams);

  		dropDownList.id = "qunit-modulefilter-dropdown-list";
  		dropDownList.innerHTML = moduleListHtml();

  		dropDown.id = "qunit-modulefilter-dropdown";
  		dropDown.style.display = "none";
  		dropDown.appendChild(actions);
  		dropDown.appendChild(dropDownList);
  		addEvent(dropDown, "change", selectionChange);
  		selectionChange();

  		moduleFilter.id = "qunit-modulefilter";
  		moduleFilter.appendChild(label);
  		moduleFilter.appendChild(dropDown);
  		addEvent(moduleFilter, "submit", interceptNavigation);
  		addEvent(moduleFilter, "reset", function () {

  			// Let the reset happen, then update styles
  			window.setTimeout(selectionChange);
  		});

  		// Enables show/hide for the dropdown
  		function searchFocus() {
  			if (dropDown.style.display !== "none") {
  				return;
  			}

  			dropDown.style.display = "block";
  			addEvent(document$$1, "click", hideHandler);
  			addEvent(document$$1, "keydown", hideHandler);

  			// Hide on Escape keydown or outside-container click
  			function hideHandler(e) {
  				var inContainer = moduleFilter.contains(e.target);

  				if (e.keyCode === 27 || !inContainer) {
  					if (e.keyCode === 27 && inContainer) {
  						moduleSearch.focus();
  					}
  					dropDown.style.display = "none";
  					removeEvent(document$$1, "click", hideHandler);
  					removeEvent(document$$1, "keydown", hideHandler);
  					moduleSearch.value = "";
  					searchInput();
  				}
  			}
  		}

  		// Processes module search box input
  		function searchInput() {
  			var i,
  			    item,
  			    searchText = moduleSearch.value.toLowerCase(),
  			    listItems = dropDownList.children;

  			for (i = 0; i < listItems.length; i++) {
  				item = listItems[i];
  				if (!searchText || item.textContent.toLowerCase().indexOf(searchText) > -1) {
  					item.style.display = "";
  				} else {
  					item.style.display = "none";
  				}
  			}
  		}

  		// Processes selection changes
  		function selectionChange(evt) {
  			var i,
  			    item,
  			    checkbox = evt && evt.target || allCheckbox,
  			    modulesList = dropDownList.getElementsByTagName("input"),
  			    selectedNames = [];

  			toggleClass(checkbox.parentNode, "checked", checkbox.checked);

  			dirty = false;
  			if (checkbox.checked && checkbox !== allCheckbox) {
  				allCheckbox.checked = false;
  				removeClass(allCheckbox.parentNode, "checked");
  			}
  			for (i = 0; i < modulesList.length; i++) {
  				item = modulesList[i];
  				if (!evt) {
  					toggleClass(item.parentNode, "checked", item.checked);
  				} else if (checkbox === allCheckbox && checkbox.checked) {
  					item.checked = false;
  					removeClass(item.parentNode, "checked");
  				}
  				dirty = dirty || item.checked !== item.defaultChecked;
  				if (item.checked) {
  					selectedNames.push(item.parentNode.textContent);
  				}
  			}

  			commit.style.display = reset.style.display = dirty ? "" : "none";
  			moduleSearch.placeholder = selectedNames.join(", ") || allCheckbox.parentNode.textContent;
  			moduleSearch.title = "Type to filter list. Current selection:\n" + (selectedNames.join("\n") || allCheckbox.parentNode.textContent);
  		}

  		return moduleFilter;
  	}

  	function appendToolbar() {
  		var toolbar = id("qunit-testrunner-toolbar");

  		if (toolbar) {
  			toolbar.appendChild(toolbarUrlConfigContainer());
  			toolbar.appendChild(toolbarModuleFilter());
  			toolbar.appendChild(toolbarLooseFilter());
  			toolbar.appendChild(document$$1.createElement("div")).className = "clearfix";
  		}
  	}

  	function appendHeader() {
  		var header = id("qunit-header");

  		if (header) {
  			header.innerHTML = "<a href='" + escapeText(unfilteredUrl) + "'>" + header.innerHTML + "</a> ";
  		}
  	}

  	function appendBanner() {
  		var banner = id("qunit-banner");

  		if (banner) {
  			banner.className = "";
  		}
  	}

  	function appendTestResults() {
  		var tests = id("qunit-tests"),
  		    result = id("qunit-testresult"),
  		    controls;

  		if (result) {
  			result.parentNode.removeChild(result);
  		}

  		if (tests) {
  			tests.innerHTML = "";
  			result = document$$1.createElement("p");
  			result.id = "qunit-testresult";
  			result.className = "result";
  			tests.parentNode.insertBefore(result, tests);
  			result.innerHTML = "<div id=\"qunit-testresult-display\">Running...<br />&#160;</div>" + "<div id=\"qunit-testresult-controls\"></div>" + "<div class=\"clearfix\"></div>";
  			controls = id("qunit-testresult-controls");
  		}

  		if (controls) {
  			controls.appendChild(abortTestsButton());
  		}
  	}

  	function appendFilteredTest() {
  		var testId = QUnit.config.testId;
  		if (!testId || testId.length <= 0) {
  			return "";
  		}
  		return "<div id='qunit-filteredTest'>Rerunning selected tests: " + escapeText(testId.join(", ")) + " <a id='qunit-clearFilter' href='" + escapeText(unfilteredUrl) + "'>Run all tests</a></div>";
  	}

  	function appendUserAgent() {
  		var userAgent = id("qunit-userAgent");

  		if (userAgent) {
  			userAgent.innerHTML = "";
  			userAgent.appendChild(document$$1.createTextNode("QUnit " + QUnit.version + "; " + navigator.userAgent));
  		}
  	}

  	function appendInterface() {
  		var qunit = id("qunit");

  		if (qunit) {
  			qunit.innerHTML = "<h1 id='qunit-header'>" + escapeText(document$$1.title) + "</h1>" + "<h2 id='qunit-banner'></h2>" + "<div id='qunit-testrunner-toolbar'></div>" + appendFilteredTest() + "<h2 id='qunit-userAgent'></h2>" + "<ol id='qunit-tests'></ol>";
  		}

  		appendHeader();
  		appendBanner();
  		appendTestResults();
  		appendUserAgent();
  		appendToolbar();
  	}

  	function appendTestsList(modules) {
  		var i, l, x, z, test, moduleObj;

  		for (i = 0, l = modules.length; i < l; i++) {
  			moduleObj = modules[i];

  			for (x = 0, z = moduleObj.tests.length; x < z; x++) {
  				test = moduleObj.tests[x];

  				appendTest(test.name, test.testId, moduleObj.name);
  			}
  		}
  	}

  	function appendTest(name, testId, moduleName) {
  		var title,
  		    rerunTrigger,
  		    testBlock,
  		    assertList,
  		    tests = id("qunit-tests");

  		if (!tests) {
  			return;
  		}

  		title = document$$1.createElement("strong");
  		title.innerHTML = getNameHtml(name, moduleName);

  		rerunTrigger = document$$1.createElement("a");
  		rerunTrigger.innerHTML = "Rerun";
  		rerunTrigger.href = setUrl({ testId: testId });

  		testBlock = document$$1.createElement("li");
  		testBlock.appendChild(title);
  		testBlock.appendChild(rerunTrigger);
  		testBlock.id = "qunit-test-output-" + testId;

  		assertList = document$$1.createElement("ol");
  		assertList.className = "qunit-assert-list";

  		testBlock.appendChild(assertList);

  		tests.appendChild(testBlock);
  	}

  	// HTML Reporter initialization and load
  	QUnit.begin(function (details) {
  		var i, moduleObj, tests;

  		// Sort modules by name for the picker
  		for (i = 0; i < details.modules.length; i++) {
  			moduleObj = details.modules[i];
  			if (moduleObj.name) {
  				modulesList.push(moduleObj.name);
  			}
  		}
  		modulesList.sort(function (a, b) {
  			return a.localeCompare(b);
  		});

  		// Initialize QUnit elements
  		appendInterface();
  		appendTestsList(details.modules);
  		tests = id("qunit-tests");
  		if (tests && config.hidepassed) {
  			addClass(tests, "hidepass");
  		}
  	});

  	QUnit.done(function (details) {
  		var banner = id("qunit-banner"),
  		    tests = id("qunit-tests"),
  		    abortButton = id("qunit-abort-tests-button"),
  		    totalTests = stats.passedTests + stats.skippedTests + stats.todoTests + stats.failedTests,
  		    html = [totalTests, " tests completed in ", details.runtime, " milliseconds, with ", stats.failedTests, " failed, ", stats.skippedTests, " skipped, and ", stats.todoTests, " todo.<br />", "<span class='passed'>", details.passed, "</span> assertions of <span class='total'>", details.total, "</span> passed, <span class='failed'>", details.failed, "</span> failed."].join(""),
  		    test,
  		    assertLi,
  		    assertList;

  		// Update remaing tests to aborted
  		if (abortButton && abortButton.disabled) {
  			html = "Tests aborted after " + details.runtime + " milliseconds.";

  			for (var i = 0; i < tests.children.length; i++) {
  				test = tests.children[i];
  				if (test.className === "" || test.className === "running") {
  					test.className = "aborted";
  					assertList = test.getElementsByTagName("ol")[0];
  					assertLi = document$$1.createElement("li");
  					assertLi.className = "fail";
  					assertLi.innerHTML = "Test aborted.";
  					assertList.appendChild(assertLi);
  				}
  			}
  		}

  		if (banner && (!abortButton || abortButton.disabled === false)) {
  			banner.className = stats.failedTests ? "qunit-fail" : "qunit-pass";
  		}

  		if (abortButton) {
  			abortButton.parentNode.removeChild(abortButton);
  		}

  		if (tests) {
  			id("qunit-testresult-display").innerHTML = html;
  		}

  		if (config.altertitle && document$$1.title) {

  			// Show ✖ for good, ✔ for bad suite result in title
  			// use escape sequences in case file gets loaded with non-utf-8
  			// charset
  			document$$1.title = [stats.failedTests ? "\u2716" : "\u2714", document$$1.title.replace(/^[\u2714\u2716] /i, "")].join(" ");
  		}

  		// Scroll back to top to show results
  		if (config.scrolltop && window.scrollTo) {
  			window.scrollTo(0, 0);
  		}
  	});

  	function getNameHtml(name, module) {
  		var nameHtml = "";

  		if (module) {
  			nameHtml = "<span class='module-name'>" + escapeText(module) + "</span>: ";
  		}

  		nameHtml += "<span class='test-name'>" + escapeText(name) + "</span>";

  		return nameHtml;
  	}

  	QUnit.testStart(function (details) {
  		var running, testBlock, bad;

  		testBlock = id("qunit-test-output-" + details.testId);
  		if (testBlock) {
  			testBlock.className = "running";
  		} else {

  			// Report later registered tests
  			appendTest(details.name, details.testId, details.module);
  		}

  		running = id("qunit-testresult-display");
  		if (running) {
  			bad = QUnit.config.reorder && details.previousFailure;

  			running.innerHTML = [bad ? "Rerunning previously failed test: <br />" : "Running: <br />", getNameHtml(details.name, details.module)].join("");
  		}
  	});

  	function stripHtml(string) {

  		// Strip tags, html entity and whitespaces
  		return string.replace(/<\/?[^>]+(>|$)/g, "").replace(/\&quot;/g, "").replace(/\s+/g, "");
  	}

  	QUnit.log(function (details) {
  		var assertList,
  		    assertLi,
  		    message,
  		    expected,
  		    actual,
  		    diff,
  		    showDiff = false,
  		    testItem = id("qunit-test-output-" + details.testId);

  		if (!testItem) {
  			return;
  		}

  		message = escapeText(details.message) || (details.result ? "okay" : "failed");
  		message = "<span class='test-message'>" + message + "</span>";
  		message += "<span class='runtime'>@ " + details.runtime + " ms</span>";

  		// The pushFailure doesn't provide details.expected
  		// when it calls, it's implicit to also not show expected and diff stuff
  		// Also, we need to check details.expected existence, as it can exist and be undefined
  		if (!details.result && hasOwn.call(details, "expected")) {
  			if (details.negative) {
  				expected = "NOT " + QUnit.dump.parse(details.expected);
  			} else {
  				expected = QUnit.dump.parse(details.expected);
  			}

  			actual = QUnit.dump.parse(details.actual);
  			message += "<table><tr class='test-expected'><th>Expected: </th><td><pre>" + escapeText(expected) + "</pre></td></tr>";

  			if (actual !== expected) {

  				message += "<tr class='test-actual'><th>Result: </th><td><pre>" + escapeText(actual) + "</pre></td></tr>";

  				if (typeof details.actual === "number" && typeof details.expected === "number") {
  					if (!isNaN(details.actual) && !isNaN(details.expected)) {
  						showDiff = true;
  						diff = details.actual - details.expected;
  						diff = (diff > 0 ? "+" : "") + diff;
  					}
  				} else if (typeof details.actual !== "boolean" && typeof details.expected !== "boolean") {
  					diff = QUnit.diff(expected, actual);

  					// don't show diff if there is zero overlap
  					showDiff = stripHtml(diff).length !== stripHtml(expected).length + stripHtml(actual).length;
  				}

  				if (showDiff) {
  					message += "<tr class='test-diff'><th>Diff: </th><td><pre>" + diff + "</pre></td></tr>";
  				}
  			} else if (expected.indexOf("[object Array]") !== -1 || expected.indexOf("[object Object]") !== -1) {
  				message += "<tr class='test-message'><th>Message: </th><td>" + "Diff suppressed as the depth of object is more than current max depth (" + QUnit.config.maxDepth + ").<p>Hint: Use <code>QUnit.dump.maxDepth</code> to " + " run with a higher max depth or <a href='" + escapeText(setUrl({ maxDepth: -1 })) + "'>" + "Rerun</a> without max depth.</p></td></tr>";
  			} else {
  				message += "<tr class='test-message'><th>Message: </th><td>" + "Diff suppressed as the expected and actual results have an equivalent" + " serialization</td></tr>";
  			}

  			if (details.source) {
  				message += "<tr class='test-source'><th>Source: </th><td><pre>" + escapeText(details.source) + "</pre></td></tr>";
  			}

  			message += "</table>";

  			// This occurs when pushFailure is set and we have an extracted stack trace
  		} else if (!details.result && details.source) {
  			message += "<table>" + "<tr class='test-source'><th>Source: </th><td><pre>" + escapeText(details.source) + "</pre></td></tr>" + "</table>";
  		}

  		assertList = testItem.getElementsByTagName("ol")[0];

  		assertLi = document$$1.createElement("li");
  		assertLi.className = details.result ? "pass" : "fail";
  		assertLi.innerHTML = message;
  		assertList.appendChild(assertLi);
  	});

  	QUnit.testDone(function (details) {
  		var testTitle,
  		    time,
  		    testItem,
  		    assertList,
  		    good,
  		    bad,
  		    testCounts,
  		    skipped,
  		    sourceName,
  		    tests = id("qunit-tests");

  		if (!tests) {
  			return;
  		}

  		testItem = id("qunit-test-output-" + details.testId);

  		assertList = testItem.getElementsByTagName("ol")[0];

  		good = details.passed;
  		bad = details.failed;

  		// This test passed if it has no unexpected failed assertions
  		var testPassed = details.failed > 0 ? details.todo : !details.todo;

  		if (testPassed) {

  			// Collapse the passing tests
  			addClass(assertList, "qunit-collapsed");
  		} else if (config.collapse) {
  			if (!collapseNext) {

  				// Skip collapsing the first failing test
  				collapseNext = true;
  			} else {

  				// Collapse remaining tests
  				addClass(assertList, "qunit-collapsed");
  			}
  		}

  		// The testItem.firstChild is the test name
  		testTitle = testItem.firstChild;

  		testCounts = bad ? "<b class='failed'>" + bad + "</b>, " + "<b class='passed'>" + good + "</b>, " : "";

  		testTitle.innerHTML += " <b class='counts'>(" + testCounts + details.assertions.length + ")</b>";

  		if (details.skipped) {
  			stats.skippedTests++;

  			testItem.className = "skipped";
  			skipped = document$$1.createElement("em");
  			skipped.className = "qunit-skipped-label";
  			skipped.innerHTML = "skipped";
  			testItem.insertBefore(skipped, testTitle);
  		} else {
  			addEvent(testTitle, "click", function () {
  				toggleClass(assertList, "qunit-collapsed");
  			});

  			testItem.className = testPassed ? "pass" : "fail";

  			if (details.todo) {
  				var todoLabel = document$$1.createElement("em");
  				todoLabel.className = "qunit-todo-label";
  				todoLabel.innerHTML = "todo";
  				testItem.className += " todo";
  				testItem.insertBefore(todoLabel, testTitle);
  			}

  			time = document$$1.createElement("span");
  			time.className = "runtime";
  			time.innerHTML = details.runtime + " ms";
  			testItem.insertBefore(time, assertList);

  			if (!testPassed) {
  				stats.failedTests++;
  			} else if (details.todo) {
  				stats.todoTests++;
  			} else {
  				stats.passedTests++;
  			}
  		}

  		// Show the source of the test when showing assertions
  		if (details.source) {
  			sourceName = document$$1.createElement("p");
  			sourceName.innerHTML = "<strong>Source: </strong>" + details.source;
  			addClass(sourceName, "qunit-source");
  			if (testPassed) {
  				addClass(sourceName, "qunit-collapsed");
  			}
  			addEvent(testTitle, "click", function () {
  				toggleClass(sourceName, "qunit-collapsed");
  			});
  			testItem.appendChild(sourceName);
  		}
  	});

  	// Avoid readyState issue with phantomjs
  	// Ref: #818
  	var notPhantom = function (p) {
  		return !(p && p.version && p.version.major > 0);
  	}(window.phantom);

  	if (notPhantom && document$$1.readyState === "complete") {
  		QUnit.load();
  	} else {
  		addEvent(window, "load", QUnit.load);
  	}

  	// Wrap window.onerror. We will call the original window.onerror to see if
  	// the existing handler fully handles the error; if not, we will call the
  	// QUnit.onError function.
  	var originalWindowOnError = window.onerror;

  	// Cover uncaught exceptions
  	// Returning true will suppress the default browser handler,
  	// returning false will let it run.
  	window.onerror = function (message, fileName, lineNumber) {
  		var ret = false;
  		if (originalWindowOnError) {
  			for (var _len = arguments.length, args = Array(_len > 3 ? _len - 3 : 0), _key = 3; _key < _len; _key++) {
  				args[_key - 3] = arguments[_key];
  			}

  			ret = originalWindowOnError.call.apply(originalWindowOnError, [this, message, fileName, lineNumber].concat(args));
  		}

  		// Treat return value as window.onerror itself does,
  		// Only do our handling if not suppressed.
  		if (ret !== true) {
  			var error = {
  				message: message,
  				fileName: fileName,
  				lineNumber: lineNumber
  			};

  			ret = QUnit.onError(error);
  		}

  		return ret;
  	};

  	// Listen for unhandled rejections, and call QUnit.onUnhandledRejection
  	window.addEventListener("unhandledrejection", function (event) {
  		QUnit.onUnhandledRejection(event.reason);
  	});
  })();

  /*
   * This file is a modified version of google-diff-match-patch's JavaScript implementation
   * (https://code.google.com/p/google-diff-match-patch/source/browse/trunk/javascript/diff_match_patch_uncompressed.js),
   * modifications are licensed as more fully set forth in LICENSE.txt.
   *
   * The original source of google-diff-match-patch is attributable and licensed as follows:
   *
   * Copyright 2006 Google Inc.
   * https://code.google.com/p/google-diff-match-patch/
   *
   * Licensed under the Apache License, Version 2.0 (the "License");
   * you may not use this file except in compliance with the License.
   * You may obtain a copy of the License at
   *
   * https://www.apache.org/licenses/LICENSE-2.0
   *
   * Unless required by applicable law or agreed to in writing, software
   * distributed under the License is distributed on an "AS IS" BASIS,
   * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   * See the License for the specific language governing permissions and
   * limitations under the License.
   *
   * More Info:
   *  https://code.google.com/p/google-diff-match-patch/
   *
   * Usage: QUnit.diff(expected, actual)
   *
   */
  QUnit.diff = function () {
  	function DiffMatchPatch() {}

  	//  DIFF FUNCTIONS

  	/**
    * The data structure representing a diff is an array of tuples:
    * [[DIFF_DELETE, 'Hello'], [DIFF_INSERT, 'Goodbye'], [DIFF_EQUAL, ' world.']]
    * which means: delete 'Hello', add 'Goodbye' and keep ' world.'
    */
  	var DIFF_DELETE = -1,
  	    DIFF_INSERT = 1,
  	    DIFF_EQUAL = 0;

  	/**
    * Find the differences between two texts.  Simplifies the problem by stripping
    * any common prefix or suffix off the texts before diffing.
    * @param {string} text1 Old string to be diffed.
    * @param {string} text2 New string to be diffed.
    * @param {boolean=} optChecklines Optional speedup flag. If present and false,
    *     then don't run a line-level diff first to identify the changed areas.
    *     Defaults to true, which does a faster, slightly less optimal diff.
    * @return {!Array.<!DiffMatchPatch.Diff>} Array of diff tuples.
    */
  	DiffMatchPatch.prototype.DiffMain = function (text1, text2, optChecklines) {
  		var deadline, checklines, commonlength, commonprefix, commonsuffix, diffs;

  		// The diff must be complete in up to 1 second.
  		deadline = new Date().getTime() + 1000;

  		// Check for null inputs.
  		if (text1 === null || text2 === null) {
  			throw new Error("Null input. (DiffMain)");
  		}

  		// Check for equality (speedup).
  		if (text1 === text2) {
  			if (text1) {
  				return [[DIFF_EQUAL, text1]];
  			}
  			return [];
  		}

  		if (typeof optChecklines === "undefined") {
  			optChecklines = true;
  		}

  		checklines = optChecklines;

  		// Trim off common prefix (speedup).
  		commonlength = this.diffCommonPrefix(text1, text2);
  		commonprefix = text1.substring(0, commonlength);
  		text1 = text1.substring(commonlength);
  		text2 = text2.substring(commonlength);

  		// Trim off common suffix (speedup).
  		commonlength = this.diffCommonSuffix(text1, text2);
  		commonsuffix = text1.substring(text1.length - commonlength);
  		text1 = text1.substring(0, text1.length - commonlength);
  		text2 = text2.substring(0, text2.length - commonlength);

  		// Compute the diff on the middle block.
  		diffs = this.diffCompute(text1, text2, checklines, deadline);

  		// Restore the prefix and suffix.
  		if (commonprefix) {
  			diffs.unshift([DIFF_EQUAL, commonprefix]);
  		}
  		if (commonsuffix) {
  			diffs.push([DIFF_EQUAL, commonsuffix]);
  		}
  		this.diffCleanupMerge(diffs);
  		return diffs;
  	};

  	/**
    * Reduce the number of edits by eliminating operationally trivial equalities.
    * @param {!Array.<!DiffMatchPatch.Diff>} diffs Array of diff tuples.
    */
  	DiffMatchPatch.prototype.diffCleanupEfficiency = function (diffs) {
  		var changes, equalities, equalitiesLength, lastequality, pointer, preIns, preDel, postIns, postDel;
  		changes = false;
  		equalities = []; // Stack of indices where equalities are found.
  		equalitiesLength = 0; // Keeping our own length var is faster in JS.
  		/** @type {?string} */
  		lastequality = null;

  		// Always equal to diffs[equalities[equalitiesLength - 1]][1]
  		pointer = 0; // Index of current position.

  		// Is there an insertion operation before the last equality.
  		preIns = false;

  		// Is there a deletion operation before the last equality.
  		preDel = false;

  		// Is there an insertion operation after the last equality.
  		postIns = false;

  		// Is there a deletion operation after the last equality.
  		postDel = false;
  		while (pointer < diffs.length) {

  			// Equality found.
  			if (diffs[pointer][0] === DIFF_EQUAL) {
  				if (diffs[pointer][1].length < 4 && (postIns || postDel)) {

  					// Candidate found.
  					equalities[equalitiesLength++] = pointer;
  					preIns = postIns;
  					preDel = postDel;
  					lastequality = diffs[pointer][1];
  				} else {

  					// Not a candidate, and can never become one.
  					equalitiesLength = 0;
  					lastequality = null;
  				}
  				postIns = postDel = false;

  				// An insertion or deletion.
  			} else {

  				if (diffs[pointer][0] === DIFF_DELETE) {
  					postDel = true;
  				} else {
  					postIns = true;
  				}

  				/*
       * Five types to be split:
       * <ins>A</ins><del>B</del>XY<ins>C</ins><del>D</del>
       * <ins>A</ins>X<ins>C</ins><del>D</del>
       * <ins>A</ins><del>B</del>X<ins>C</ins>
       * <ins>A</del>X<ins>C</ins><del>D</del>
       * <ins>A</ins><del>B</del>X<del>C</del>
       */
  				if (lastequality && (preIns && preDel && postIns && postDel || lastequality.length < 2 && preIns + preDel + postIns + postDel === 3)) {

  					// Duplicate record.
  					diffs.splice(equalities[equalitiesLength - 1], 0, [DIFF_DELETE, lastequality]);

  					// Change second copy to insert.
  					diffs[equalities[equalitiesLength - 1] + 1][0] = DIFF_INSERT;
  					equalitiesLength--; // Throw away the equality we just deleted;
  					lastequality = null;
  					if (preIns && preDel) {

  						// No changes made which could affect previous entry, keep going.
  						postIns = postDel = true;
  						equalitiesLength = 0;
  					} else {
  						equalitiesLength--; // Throw away the previous equality.
  						pointer = equalitiesLength > 0 ? equalities[equalitiesLength - 1] : -1;
  						postIns = postDel = false;
  					}
  					changes = true;
  				}
  			}
  			pointer++;
  		}

  		if (changes) {
  			this.diffCleanupMerge(diffs);
  		}
  	};

  	/**
    * Convert a diff array into a pretty HTML report.
    * @param {!Array.<!DiffMatchPatch.Diff>} diffs Array of diff tuples.
    * @param {integer} string to be beautified.
    * @return {string} HTML representation.
    */
  	DiffMatchPatch.prototype.diffPrettyHtml = function (diffs) {
  		var op,
  		    data,
  		    x,
  		    html = [];
  		for (x = 0; x < diffs.length; x++) {
  			op = diffs[x][0]; // Operation (insert, delete, equal)
  			data = diffs[x][1]; // Text of change.
  			switch (op) {
  				case DIFF_INSERT:
  					html[x] = "<ins>" + escapeText(data) + "</ins>";
  					break;
  				case DIFF_DELETE:
  					html[x] = "<del>" + escapeText(data) + "</del>";
  					break;
  				case DIFF_EQUAL:
  					html[x] = "<span>" + escapeText(data) + "</span>";
  					break;
  			}
  		}
  		return html.join("");
  	};

  	/**
    * Determine the common prefix of two strings.
    * @param {string} text1 First string.
    * @param {string} text2 Second string.
    * @return {number} The number of characters common to the start of each
    *     string.
    */
  	DiffMatchPatch.prototype.diffCommonPrefix = function (text1, text2) {
  		var pointermid, pointermax, pointermin, pointerstart;

  		// Quick check for common null cases.
  		if (!text1 || !text2 || text1.charAt(0) !== text2.charAt(0)) {
  			return 0;
  		}

  		// Binary search.
  		// Performance analysis: https://neil.fraser.name/news/2007/10/09/
  		pointermin = 0;
  		pointermax = Math.min(text1.length, text2.length);
  		pointermid = pointermax;
  		pointerstart = 0;
  		while (pointermin < pointermid) {
  			if (text1.substring(pointerstart, pointermid) === text2.substring(pointerstart, pointermid)) {
  				pointermin = pointermid;
  				pointerstart = pointermin;
  			} else {
  				pointermax = pointermid;
  			}
  			pointermid = Math.floor((pointermax - pointermin) / 2 + pointermin);
  		}
  		return pointermid;
  	};

  	/**
    * Determine the common suffix of two strings.
    * @param {string} text1 First string.
    * @param {string} text2 Second string.
    * @return {number} The number of characters common to the end of each string.
    */
  	DiffMatchPatch.prototype.diffCommonSuffix = function (text1, text2) {
  		var pointermid, pointermax, pointermin, pointerend;

  		// Quick check for common null cases.
  		if (!text1 || !text2 || text1.charAt(text1.length - 1) !== text2.charAt(text2.length - 1)) {
  			return 0;
  		}

  		// Binary search.
  		// Performance analysis: https://neil.fraser.name/news/2007/10/09/
  		pointermin = 0;
  		pointermax = Math.min(text1.length, text2.length);
  		pointermid = pointermax;
  		pointerend = 0;
  		while (pointermin < pointermid) {
  			if (text1.substring(text1.length - pointermid, text1.length - pointerend) === text2.substring(text2.length - pointermid, text2.length - pointerend)) {
  				pointermin = pointermid;
  				pointerend = pointermin;
  			} else {
  				pointermax = pointermid;
  			}
  			pointermid = Math.floor((pointermax - pointermin) / 2 + pointermin);
  		}
  		return pointermid;
  	};

  	/**
    * Find the differences between two texts.  Assumes that the texts do not
    * have any common prefix or suffix.
    * @param {string} text1 Old string to be diffed.
    * @param {string} text2 New string to be diffed.
    * @param {boolean} checklines Speedup flag.  If false, then don't run a
    *     line-level diff first to identify the changed areas.
    *     If true, then run a faster, slightly less optimal diff.
    * @param {number} deadline Time when the diff should be complete by.
    * @return {!Array.<!DiffMatchPatch.Diff>} Array of diff tuples.
    * @private
    */
  	DiffMatchPatch.prototype.diffCompute = function (text1, text2, checklines, deadline) {
  		var diffs, longtext, shorttext, i, hm, text1A, text2A, text1B, text2B, midCommon, diffsA, diffsB;

  		if (!text1) {

  			// Just add some text (speedup).
  			return [[DIFF_INSERT, text2]];
  		}

  		if (!text2) {

  			// Just delete some text (speedup).
  			return [[DIFF_DELETE, text1]];
  		}

  		longtext = text1.length > text2.length ? text1 : text2;
  		shorttext = text1.length > text2.length ? text2 : text1;
  		i = longtext.indexOf(shorttext);
  		if (i !== -1) {

  			// Shorter text is inside the longer text (speedup).
  			diffs = [[DIFF_INSERT, longtext.substring(0, i)], [DIFF_EQUAL, shorttext], [DIFF_INSERT, longtext.substring(i + shorttext.length)]];

  			// Swap insertions for deletions if diff is reversed.
  			if (text1.length > text2.length) {
  				diffs[0][0] = diffs[2][0] = DIFF_DELETE;
  			}
  			return diffs;
  		}

  		if (shorttext.length === 1) {

  			// Single character string.
  			// After the previous speedup, the character can't be an equality.
  			return [[DIFF_DELETE, text1], [DIFF_INSERT, text2]];
  		}

  		// Check to see if the problem can be split in two.
  		hm = this.diffHalfMatch(text1, text2);
  		if (hm) {

  			// A half-match was found, sort out the return data.
  			text1A = hm[0];
  			text1B = hm[1];
  			text2A = hm[2];
  			text2B = hm[3];
  			midCommon = hm[4];

  			// Send both pairs off for separate processing.
  			diffsA = this.DiffMain(text1A, text2A, checklines, deadline);
  			diffsB = this.DiffMain(text1B, text2B, checklines, deadline);

  			// Merge the results.
  			return diffsA.concat([[DIFF_EQUAL, midCommon]], diffsB);
  		}

  		if (checklines && text1.length > 100 && text2.length > 100) {
  			return this.diffLineMode(text1, text2, deadline);
  		}

  		return this.diffBisect(text1, text2, deadline);
  	};

  	/**
    * Do the two texts share a substring which is at least half the length of the
    * longer text?
    * This speedup can produce non-minimal diffs.
    * @param {string} text1 First string.
    * @param {string} text2 Second string.
    * @return {Array.<string>} Five element Array, containing the prefix of
    *     text1, the suffix of text1, the prefix of text2, the suffix of
    *     text2 and the common middle.  Or null if there was no match.
    * @private
    */
  	DiffMatchPatch.prototype.diffHalfMatch = function (text1, text2) {
  		var longtext, shorttext, dmp, text1A, text2B, text2A, text1B, midCommon, hm1, hm2, hm;

  		longtext = text1.length > text2.length ? text1 : text2;
  		shorttext = text1.length > text2.length ? text2 : text1;
  		if (longtext.length < 4 || shorttext.length * 2 < longtext.length) {
  			return null; // Pointless.
  		}
  		dmp = this; // 'this' becomes 'window' in a closure.

  		/**
     * Does a substring of shorttext exist within longtext such that the substring
     * is at least half the length of longtext?
     * Closure, but does not reference any external variables.
     * @param {string} longtext Longer string.
     * @param {string} shorttext Shorter string.
     * @param {number} i Start index of quarter length substring within longtext.
     * @return {Array.<string>} Five element Array, containing the prefix of
     *     longtext, the suffix of longtext, the prefix of shorttext, the suffix
     *     of shorttext and the common middle.  Or null if there was no match.
     * @private
     */
  		function diffHalfMatchI(longtext, shorttext, i) {
  			var seed, j, bestCommon, prefixLength, suffixLength, bestLongtextA, bestLongtextB, bestShorttextA, bestShorttextB;

  			// Start with a 1/4 length substring at position i as a seed.
  			seed = longtext.substring(i, i + Math.floor(longtext.length / 4));
  			j = -1;
  			bestCommon = "";
  			while ((j = shorttext.indexOf(seed, j + 1)) !== -1) {
  				prefixLength = dmp.diffCommonPrefix(longtext.substring(i), shorttext.substring(j));
  				suffixLength = dmp.diffCommonSuffix(longtext.substring(0, i), shorttext.substring(0, j));
  				if (bestCommon.length < suffixLength + prefixLength) {
  					bestCommon = shorttext.substring(j - suffixLength, j) + shorttext.substring(j, j + prefixLength);
  					bestLongtextA = longtext.substring(0, i - suffixLength);
  					bestLongtextB = longtext.substring(i + prefixLength);
  					bestShorttextA = shorttext.substring(0, j - suffixLength);
  					bestShorttextB = shorttext.substring(j + prefixLength);
  				}
  			}
  			if (bestCommon.length * 2 >= longtext.length) {
  				return [bestLongtextA, bestLongtextB, bestShorttextA, bestShorttextB, bestCommon];
  			} else {
  				return null;
  			}
  		}

  		// First check if the second quarter is the seed for a half-match.
  		hm1 = diffHalfMatchI(longtext, shorttext, Math.ceil(longtext.length / 4));

  		// Check again based on the third quarter.
  		hm2 = diffHalfMatchI(longtext, shorttext, Math.ceil(longtext.length / 2));
  		if (!hm1 && !hm2) {
  			return null;
  		} else if (!hm2) {
  			hm = hm1;
  		} else if (!hm1) {
  			hm = hm2;
  		} else {

  			// Both matched.  Select the longest.
  			hm = hm1[4].length > hm2[4].length ? hm1 : hm2;
  		}

  		// A half-match was found, sort out the return data.
  		if (text1.length > text2.length) {
  			text1A = hm[0];
  			text1B = hm[1];
  			text2A = hm[2];
  			text2B = hm[3];
  		} else {
  			text2A = hm[0];
  			text2B = hm[1];
  			text1A = hm[2];
  			text1B = hm[3];
  		}
  		midCommon = hm[4];
  		return [text1A, text1B, text2A, text2B, midCommon];
  	};

  	/**
    * Do a quick line-level diff on both strings, then rediff the parts for
    * greater accuracy.
    * This speedup can produce non-minimal diffs.
    * @param {string} text1 Old string to be diffed.
    * @param {string} text2 New string to be diffed.
    * @param {number} deadline Time when the diff should be complete by.
    * @return {!Array.<!DiffMatchPatch.Diff>} Array of diff tuples.
    * @private
    */
  	DiffMatchPatch.prototype.diffLineMode = function (text1, text2, deadline) {
  		var a, diffs, linearray, pointer, countInsert, countDelete, textInsert, textDelete, j;

  		// Scan the text on a line-by-line basis first.
  		a = this.diffLinesToChars(text1, text2);
  		text1 = a.chars1;
  		text2 = a.chars2;
  		linearray = a.lineArray;

  		diffs = this.DiffMain(text1, text2, false, deadline);

  		// Convert the diff back to original text.
  		this.diffCharsToLines(diffs, linearray);

  		// Eliminate freak matches (e.g. blank lines)
  		this.diffCleanupSemantic(diffs);

  		// Rediff any replacement blocks, this time character-by-character.
  		// Add a dummy entry at the end.
  		diffs.push([DIFF_EQUAL, ""]);
  		pointer = 0;
  		countDelete = 0;
  		countInsert = 0;
  		textDelete = "";
  		textInsert = "";
  		while (pointer < diffs.length) {
  			switch (diffs[pointer][0]) {
  				case DIFF_INSERT:
  					countInsert++;
  					textInsert += diffs[pointer][1];
  					break;
  				case DIFF_DELETE:
  					countDelete++;
  					textDelete += diffs[pointer][1];
  					break;
  				case DIFF_EQUAL:

  					// Upon reaching an equality, check for prior redundancies.
  					if (countDelete >= 1 && countInsert >= 1) {

  						// Delete the offending records and add the merged ones.
  						diffs.splice(pointer - countDelete - countInsert, countDelete + countInsert);
  						pointer = pointer - countDelete - countInsert;
  						a = this.DiffMain(textDelete, textInsert, false, deadline);
  						for (j = a.length - 1; j >= 0; j--) {
  							diffs.splice(pointer, 0, a[j]);
  						}
  						pointer = pointer + a.length;
  					}
  					countInsert = 0;
  					countDelete = 0;
  					textDelete = "";
  					textInsert = "";
  					break;
  			}
  			pointer++;
  		}
  		diffs.pop(); // Remove the dummy entry at the end.

  		return diffs;
  	};

  	/**
    * Find the 'middle snake' of a diff, split the problem in two
    * and return the recursively constructed diff.
    * See Myers 1986 paper: An O(ND) Difference Algorithm and Its Variations.
    * @param {string} text1 Old string to be diffed.
    * @param {string} text2 New string to be diffed.
    * @param {number} deadline Time at which to bail if not yet complete.
    * @return {!Array.<!DiffMatchPatch.Diff>} Array of diff tuples.
    * @private
    */
  	DiffMatchPatch.prototype.diffBisect = function (text1, text2, deadline) {
  		var text1Length, text2Length, maxD, vOffset, vLength, v1, v2, x, delta, front, k1start, k1end, k2start, k2end, k2Offset, k1Offset, x1, x2, y1, y2, d, k1, k2;

  		// Cache the text lengths to prevent multiple calls.
  		text1Length = text1.length;
  		text2Length = text2.length;
  		maxD = Math.ceil((text1Length + text2Length) / 2);
  		vOffset = maxD;
  		vLength = 2 * maxD;
  		v1 = new Array(vLength);
  		v2 = new Array(vLength);

  		// Setting all elements to -1 is faster in Chrome & Firefox than mixing
  		// integers and undefined.
  		for (x = 0; x < vLength; x++) {
  			v1[x] = -1;
  			v2[x] = -1;
  		}
  		v1[vOffset + 1] = 0;
  		v2[vOffset + 1] = 0;
  		delta = text1Length - text2Length;

  		// If the total number of characters is odd, then the front path will collide
  		// with the reverse path.
  		front = delta % 2 !== 0;

  		// Offsets for start and end of k loop.
  		// Prevents mapping of space beyond the grid.
  		k1start = 0;
  		k1end = 0;
  		k2start = 0;
  		k2end = 0;
  		for (d = 0; d < maxD; d++) {

  			// Bail out if deadline is reached.
  			if (new Date().getTime() > deadline) {
  				break;
  			}

  			// Walk the front path one step.
  			for (k1 = -d + k1start; k1 <= d - k1end; k1 += 2) {
  				k1Offset = vOffset + k1;
  				if (k1 === -d || k1 !== d && v1[k1Offset - 1] < v1[k1Offset + 1]) {
  					x1 = v1[k1Offset + 1];
  				} else {
  					x1 = v1[k1Offset - 1] + 1;
  				}
  				y1 = x1 - k1;
  				while (x1 < text1Length && y1 < text2Length && text1.charAt(x1) === text2.charAt(y1)) {
  					x1++;
  					y1++;
  				}
  				v1[k1Offset] = x1;
  				if (x1 > text1Length) {

  					// Ran off the right of the graph.
  					k1end += 2;
  				} else if (y1 > text2Length) {

  					// Ran off the bottom of the graph.
  					k1start += 2;
  				} else if (front) {
  					k2Offset = vOffset + delta - k1;
  					if (k2Offset >= 0 && k2Offset < vLength && v2[k2Offset] !== -1) {

  						// Mirror x2 onto top-left coordinate system.
  						x2 = text1Length - v2[k2Offset];
  						if (x1 >= x2) {

  							// Overlap detected.
  							return this.diffBisectSplit(text1, text2, x1, y1, deadline);
  						}
  					}
  				}
  			}

  			// Walk the reverse path one step.
  			for (k2 = -d + k2start; k2 <= d - k2end; k2 += 2) {
  				k2Offset = vOffset + k2;
  				if (k2 === -d || k2 !== d && v2[k2Offset - 1] < v2[k2Offset + 1]) {
  					x2 = v2[k2Offset + 1];
  				} else {
  					x2 = v2[k2Offset - 1] + 1;
  				}
  				y2 = x2 - k2;
  				while (x2 < text1Length && y2 < text2Length && text1.charAt(text1Length - x2 - 1) === text2.charAt(text2Length - y2 - 1)) {
  					x2++;
  					y2++;
  				}
  				v2[k2Offset] = x2;
  				if (x2 > text1Length) {

  					// Ran off the left of the graph.
  					k2end += 2;
  				} else if (y2 > text2Length) {

  					// Ran off the top of the graph.
  					k2start += 2;
  				} else if (!front) {
  					k1Offset = vOffset + delta - k2;
  					if (k1Offset >= 0 && k1Offset < vLength && v1[k1Offset] !== -1) {
  						x1 = v1[k1Offset];
  						y1 = vOffset + x1 - k1Offset;

  						// Mirror x2 onto top-left coordinate system.
  						x2 = text1Length - x2;
  						if (x1 >= x2) {

  							// Overlap detected.
  							return this.diffBisectSplit(text1, text2, x1, y1, deadline);
  						}
  					}
  				}
  			}
  		}

  		// Diff took too long and hit the deadline or
  		// number of diffs equals number of characters, no commonality at all.
  		return [[DIFF_DELETE, text1], [DIFF_INSERT, text2]];
  	};

  	/**
    * Given the location of the 'middle snake', split the diff in two parts
    * and recurse.
    * @param {string} text1 Old string to be diffed.
    * @param {string} text2 New string to be diffed.
    * @param {number} x Index of split point in text1.
    * @param {number} y Index of split point in text2.
    * @param {number} deadline Time at which to bail if not yet complete.
    * @return {!Array.<!DiffMatchPatch.Diff>} Array of diff tuples.
    * @private
    */
  	DiffMatchPatch.prototype.diffBisectSplit = function (text1, text2, x, y, deadline) {
  		var text1a, text1b, text2a, text2b, diffs, diffsb;
  		text1a = text1.substring(0, x);
  		text2a = text2.substring(0, y);
  		text1b = text1.substring(x);
  		text2b = text2.substring(y);

  		// Compute both diffs serially.
  		diffs = this.DiffMain(text1a, text2a, false, deadline);
  		diffsb = this.DiffMain(text1b, text2b, false, deadline);

  		return diffs.concat(diffsb);
  	};

  	/**
    * Reduce the number of edits by eliminating semantically trivial equalities.
    * @param {!Array.<!DiffMatchPatch.Diff>} diffs Array of diff tuples.
    */
  	DiffMatchPatch.prototype.diffCleanupSemantic = function (diffs) {
  		var changes, equalities, equalitiesLength, lastequality, pointer, lengthInsertions2, lengthDeletions2, lengthInsertions1, lengthDeletions1, deletion, insertion, overlapLength1, overlapLength2;
  		changes = false;
  		equalities = []; // Stack of indices where equalities are found.
  		equalitiesLength = 0; // Keeping our own length var is faster in JS.
  		/** @type {?string} */
  		lastequality = null;

  		// Always equal to diffs[equalities[equalitiesLength - 1]][1]
  		pointer = 0; // Index of current position.

  		// Number of characters that changed prior to the equality.
  		lengthInsertions1 = 0;
  		lengthDeletions1 = 0;

  		// Number of characters that changed after the equality.
  		lengthInsertions2 = 0;
  		lengthDeletions2 = 0;
  		while (pointer < diffs.length) {
  			if (diffs[pointer][0] === DIFF_EQUAL) {
  				// Equality found.
  				equalities[equalitiesLength++] = pointer;
  				lengthInsertions1 = lengthInsertions2;
  				lengthDeletions1 = lengthDeletions2;
  				lengthInsertions2 = 0;
  				lengthDeletions2 = 0;
  				lastequality = diffs[pointer][1];
  			} else {
  				// An insertion or deletion.
  				if (diffs[pointer][0] === DIFF_INSERT) {
  					lengthInsertions2 += diffs[pointer][1].length;
  				} else {
  					lengthDeletions2 += diffs[pointer][1].length;
  				}

  				// Eliminate an equality that is smaller or equal to the edits on both
  				// sides of it.
  				if (lastequality && lastequality.length <= Math.max(lengthInsertions1, lengthDeletions1) && lastequality.length <= Math.max(lengthInsertions2, lengthDeletions2)) {

  					// Duplicate record.
  					diffs.splice(equalities[equalitiesLength - 1], 0, [DIFF_DELETE, lastequality]);

  					// Change second copy to insert.
  					diffs[equalities[equalitiesLength - 1] + 1][0] = DIFF_INSERT;

  					// Throw away the equality we just deleted.
  					equalitiesLength--;

  					// Throw away the previous equality (it needs to be reevaluated).
  					equalitiesLength--;
  					pointer = equalitiesLength > 0 ? equalities[equalitiesLength - 1] : -1;

  					// Reset the counters.
  					lengthInsertions1 = 0;
  					lengthDeletions1 = 0;
  					lengthInsertions2 = 0;
  					lengthDeletions2 = 0;
  					lastequality = null;
  					changes = true;
  				}
  			}
  			pointer++;
  		}

  		// Normalize the diff.
  		if (changes) {
  			this.diffCleanupMerge(diffs);
  		}

  		// Find any overlaps between deletions and insertions.
  		// e.g: <del>abcxxx</del><ins>xxxdef</ins>
  		//   -> <del>abc</del>xxx<ins>def</ins>
  		// e.g: <del>xxxabc</del><ins>defxxx</ins>
  		//   -> <ins>def</ins>xxx<del>abc</del>
  		// Only extract an overlap if it is as big as the edit ahead or behind it.
  		pointer = 1;
  		while (pointer < diffs.length) {
  			if (diffs[pointer - 1][0] === DIFF_DELETE && diffs[pointer][0] === DIFF_INSERT) {
  				deletion = diffs[pointer - 1][1];
  				insertion = diffs[pointer][1];
  				overlapLength1 = this.diffCommonOverlap(deletion, insertion);
  				overlapLength2 = this.diffCommonOverlap(insertion, deletion);
  				if (overlapLength1 >= overlapLength2) {
  					if (overlapLength1 >= deletion.length / 2 || overlapLength1 >= insertion.length / 2) {

  						// Overlap found.  Insert an equality and trim the surrounding edits.
  						diffs.splice(pointer, 0, [DIFF_EQUAL, insertion.substring(0, overlapLength1)]);
  						diffs[pointer - 1][1] = deletion.substring(0, deletion.length - overlapLength1);
  						diffs[pointer + 1][1] = insertion.substring(overlapLength1);
  						pointer++;
  					}
  				} else {
  					if (overlapLength2 >= deletion.length / 2 || overlapLength2 >= insertion.length / 2) {

  						// Reverse overlap found.
  						// Insert an equality and swap and trim the surrounding edits.
  						diffs.splice(pointer, 0, [DIFF_EQUAL, deletion.substring(0, overlapLength2)]);

  						diffs[pointer - 1][0] = DIFF_INSERT;
  						diffs[pointer - 1][1] = insertion.substring(0, insertion.length - overlapLength2);
  						diffs[pointer + 1][0] = DIFF_DELETE;
  						diffs[pointer + 1][1] = deletion.substring(overlapLength2);
  						pointer++;
  					}
  				}
  				pointer++;
  			}
  			pointer++;
  		}
  	};

  	/**
    * Determine if the suffix of one string is the prefix of another.
    * @param {string} text1 First string.
    * @param {string} text2 Second string.
    * @return {number} The number of characters common to the end of the first
    *     string and the start of the second string.
    * @private
    */
  	DiffMatchPatch.prototype.diffCommonOverlap = function (text1, text2) {
  		var text1Length, text2Length, textLength, best, length, pattern, found;

  		// Cache the text lengths to prevent multiple calls.
  		text1Length = text1.length;
  		text2Length = text2.length;

  		// Eliminate the null case.
  		if (text1Length === 0 || text2Length === 0) {
  			return 0;
  		}

  		// Truncate the longer string.
  		if (text1Length > text2Length) {
  			text1 = text1.substring(text1Length - text2Length);
  		} else if (text1Length < text2Length) {
  			text2 = text2.substring(0, text1Length);
  		}
  		textLength = Math.min(text1Length, text2Length);

  		// Quick check for the worst case.
  		if (text1 === text2) {
  			return textLength;
  		}

  		// Start by looking for a single character match
  		// and increase length until no match is found.
  		// Performance analysis: https://neil.fraser.name/news/2010/11/04/
  		best = 0;
  		length = 1;
  		while (true) {
  			pattern = text1.substring(textLength - length);
  			found = text2.indexOf(pattern);
  			if (found === -1) {
  				return best;
  			}
  			length += found;
  			if (found === 0 || text1.substring(textLength - length) === text2.substring(0, length)) {
  				best = length;
  				length++;
  			}
  		}
  	};

  	/**
    * Split two texts into an array of strings.  Reduce the texts to a string of
    * hashes where each Unicode character represents one line.
    * @param {string} text1 First string.
    * @param {string} text2 Second string.
    * @return {{chars1: string, chars2: string, lineArray: !Array.<string>}}
    *     An object containing the encoded text1, the encoded text2 and
    *     the array of unique strings.
    *     The zeroth element of the array of unique strings is intentionally blank.
    * @private
    */
  	DiffMatchPatch.prototype.diffLinesToChars = function (text1, text2) {
  		var lineArray, lineHash, chars1, chars2;
  		lineArray = []; // E.g. lineArray[4] === 'Hello\n'
  		lineHash = {}; // E.g. lineHash['Hello\n'] === 4

  		// '\x00' is a valid character, but various debuggers don't like it.
  		// So we'll insert a junk entry to avoid generating a null character.
  		lineArray[0] = "";

  		/**
     * Split a text into an array of strings.  Reduce the texts to a string of
     * hashes where each Unicode character represents one line.
     * Modifies linearray and linehash through being a closure.
     * @param {string} text String to encode.
     * @return {string} Encoded string.
     * @private
     */
  		function diffLinesToCharsMunge(text) {
  			var chars, lineStart, lineEnd, lineArrayLength, line;
  			chars = "";

  			// Walk the text, pulling out a substring for each line.
  			// text.split('\n') would would temporarily double our memory footprint.
  			// Modifying text would create many large strings to garbage collect.
  			lineStart = 0;
  			lineEnd = -1;

  			// Keeping our own length variable is faster than looking it up.
  			lineArrayLength = lineArray.length;
  			while (lineEnd < text.length - 1) {
  				lineEnd = text.indexOf("\n", lineStart);
  				if (lineEnd === -1) {
  					lineEnd = text.length - 1;
  				}
  				line = text.substring(lineStart, lineEnd + 1);
  				lineStart = lineEnd + 1;

  				var lineHashExists = lineHash.hasOwnProperty ? lineHash.hasOwnProperty(line) : lineHash[line] !== undefined;

  				if (lineHashExists) {
  					chars += String.fromCharCode(lineHash[line]);
  				} else {
  					chars += String.fromCharCode(lineArrayLength);
  					lineHash[line] = lineArrayLength;
  					lineArray[lineArrayLength++] = line;
  				}
  			}
  			return chars;
  		}

  		chars1 = diffLinesToCharsMunge(text1);
  		chars2 = diffLinesToCharsMunge(text2);
  		return {
  			chars1: chars1,
  			chars2: chars2,
  			lineArray: lineArray
  		};
  	};

  	/**
    * Rehydrate the text in a diff from a string of line hashes to real lines of
    * text.
    * @param {!Array.<!DiffMatchPatch.Diff>} diffs Array of diff tuples.
    * @param {!Array.<string>} lineArray Array of unique strings.
    * @private
    */
  	DiffMatchPatch.prototype.diffCharsToLines = function (diffs, lineArray) {
  		var x, chars, text, y;
  		for (x = 0; x < diffs.length; x++) {
  			chars = diffs[x][1];
  			text = [];
  			for (y = 0; y < chars.length; y++) {
  				text[y] = lineArray[chars.charCodeAt(y)];
  			}
  			diffs[x][1] = text.join("");
  		}
  	};

  	/**
    * Reorder and merge like edit sections.  Merge equalities.
    * Any edit section can move as long as it doesn't cross an equality.
    * @param {!Array.<!DiffMatchPatch.Diff>} diffs Array of diff tuples.
    */
  	DiffMatchPatch.prototype.diffCleanupMerge = function (diffs) {
  		var pointer, countDelete, countInsert, textInsert, textDelete, commonlength, changes, diffPointer, position;
  		diffs.push([DIFF_EQUAL, ""]); // Add a dummy entry at the end.
  		pointer = 0;
  		countDelete = 0;
  		countInsert = 0;
  		textDelete = "";
  		textInsert = "";

  		while (pointer < diffs.length) {
  			switch (diffs[pointer][0]) {
  				case DIFF_INSERT:
  					countInsert++;
  					textInsert += diffs[pointer][1];
  					pointer++;
  					break;
  				case DIFF_DELETE:
  					countDelete++;
  					textDelete += diffs[pointer][1];
  					pointer++;
  					break;
  				case DIFF_EQUAL:

  					// Upon reaching an equality, check for prior redundancies.
  					if (countDelete + countInsert > 1) {
  						if (countDelete !== 0 && countInsert !== 0) {

  							// Factor out any common prefixes.
  							commonlength = this.diffCommonPrefix(textInsert, textDelete);
  							if (commonlength !== 0) {
  								if (pointer - countDelete - countInsert > 0 && diffs[pointer - countDelete - countInsert - 1][0] === DIFF_EQUAL) {
  									diffs[pointer - countDelete - countInsert - 1][1] += textInsert.substring(0, commonlength);
  								} else {
  									diffs.splice(0, 0, [DIFF_EQUAL, textInsert.substring(0, commonlength)]);
  									pointer++;
  								}
  								textInsert = textInsert.substring(commonlength);
  								textDelete = textDelete.substring(commonlength);
  							}

  							// Factor out any common suffixies.
  							commonlength = this.diffCommonSuffix(textInsert, textDelete);
  							if (commonlength !== 0) {
  								diffs[pointer][1] = textInsert.substring(textInsert.length - commonlength) + diffs[pointer][1];
  								textInsert = textInsert.substring(0, textInsert.length - commonlength);
  								textDelete = textDelete.substring(0, textDelete.length - commonlength);
  							}
  						}

  						// Delete the offending records and add the merged ones.
  						if (countDelete === 0) {
  							diffs.splice(pointer - countInsert, countDelete + countInsert, [DIFF_INSERT, textInsert]);
  						} else if (countInsert === 0) {
  							diffs.splice(pointer - countDelete, countDelete + countInsert, [DIFF_DELETE, textDelete]);
  						} else {
  							diffs.splice(pointer - countDelete - countInsert, countDelete + countInsert, [DIFF_DELETE, textDelete], [DIFF_INSERT, textInsert]);
  						}
  						pointer = pointer - countDelete - countInsert + (countDelete ? 1 : 0) + (countInsert ? 1 : 0) + 1;
  					} else if (pointer !== 0 && diffs[pointer - 1][0] === DIFF_EQUAL) {

  						// Merge this equality with the previous one.
  						diffs[pointer - 1][1] += diffs[pointer][1];
  						diffs.splice(pointer, 1);
  					} else {
  						pointer++;
  					}
  					countInsert = 0;
  					countDelete = 0;
  					textDelete = "";
  					textInsert = "";
  					break;
  			}
  		}
  		if (diffs[diffs.length - 1][1] === "") {
  			diffs.pop(); // Remove the dummy entry at the end.
  		}

  		// Second pass: look for single edits surrounded on both sides by equalities
  		// which can be shifted sideways to eliminate an equality.
  		// e.g: A<ins>BA</ins>C -> <ins>AB</ins>AC
  		changes = false;
  		pointer = 1;

  		// Intentionally ignore the first and last element (don't need checking).
  		while (pointer < diffs.length - 1) {
  			if (diffs[pointer - 1][0] === DIFF_EQUAL && diffs[pointer + 1][0] === DIFF_EQUAL) {

  				diffPointer = diffs[pointer][1];
  				position = diffPointer.substring(diffPointer.length - diffs[pointer - 1][1].length);

  				// This is a single edit surrounded by equalities.
  				if (position === diffs[pointer - 1][1]) {

  					// Shift the edit over the previous equality.
  					diffs[pointer][1] = diffs[pointer - 1][1] + diffs[pointer][1].substring(0, diffs[pointer][1].length - diffs[pointer - 1][1].length);
  					diffs[pointer + 1][1] = diffs[pointer - 1][1] + diffs[pointer + 1][1];
  					diffs.splice(pointer - 1, 1);
  					changes = true;
  				} else if (diffPointer.substring(0, diffs[pointer + 1][1].length) === diffs[pointer + 1][1]) {

  					// Shift the edit over the next equality.
  					diffs[pointer - 1][1] += diffs[pointer + 1][1];
  					diffs[pointer][1] = diffs[pointer][1].substring(diffs[pointer + 1][1].length) + diffs[pointer + 1][1];
  					diffs.splice(pointer + 1, 1);
  					changes = true;
  				}
  			}
  			pointer++;
  		}

  		// If shifts were made, the diff needs reordering and another shift sweep.
  		if (changes) {
  			this.diffCleanupMerge(diffs);
  		}
  	};

  	return function (o, n) {
  		var diff, output, text;
  		diff = new DiffMatchPatch();
  		output = diff.DiffMain(o, n);
  		diff.diffCleanupEfficiency(output);
  		text = diff.diffPrettyHtml(output);

  		return text;
  	};
  }();

}((function() { return this; }())));
}
/**
 * @version 4.1.0.47200 R.local
 * @author ELMA
 * @copyright Copyright © 2006-2022 ELMA
 * @compiler Bridge.NET 17.8.0
 */
Bridge.assembly("EleWise.ELMA.TestFramework", function ($asm, globals) {
    "use strict";

    (function (root, factory) {
        if (typeof define === 'function' && define.amd) {
            define("EleWise_ELMA_TestFramework", ["EleWise_ELMA_Core", "EleWise_ELMA_Core_Abstractions_Metadata", "EleWise_ELMA_IoC"], factory);
        } else if (typeof module === 'object' && module.exports) {
            module.exports = factory(require("EleWise_ELMA_Core"), require("EleWise_ELMA_Core_Abstractions_Metadata"), require("EleWise_ELMA_IoC"));
        } else {
            root["EleWise_ELMA_TestFramework"] = factory(root["EleWise_ELMA_Core"], root["EleWise_ELMA_Core_Abstractions_Metadata"], root["EleWise_ELMA_IoC"]);
        }
    }(this, function (EleWise_ELMA_Core, EleWise_ELMA_Core_Abstractions_Metadata, EleWise_ELMA_IoC) {
        var EleWise_ELMA_TestFramework = { };
Bridge.define("EleWise.ELMA.TestFramework.API.IComponentTest", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "TestComponentCreatorService", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestComponentCreatorService, g: {
                                        ab: true, a: 2, n: "get_TestComponentCreatorService", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestComponentCreatorService, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService"
                                    }, s: {
                                        ab: true, a: 2, n: "set_TestComponentCreatorService", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestComponentCreatorService], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService"
                            }, {
                                a: 1, backing: true, n: "<TestComponentCreatorService>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestComponentCreatorService, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.definei("EleWise.ELMA.TestFramework.API.IBaseReactComponentTestModel$3", EleWise_ELMA_TestFramework, function(TContext, TController, TInputs)
{
    return {
            $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2, m: [{
                                        ab: true, a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                ab: true, a: 2, n: "get_Context", t: 8, rt: TContext, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Context\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Context\""
                                    }, {
                                        ab: true, a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                ab: true, a: 2, n: "get_Controller", t: 8, rt: TController, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Controller\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Controller\""
                                    }, {
                                        ab: true, a: 2, n: "Inputs", t: 16, rt: TInputs, g: {
                                                ab: true, a: 2, n: "get_Inputs", t: 8, rt: TInputs, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Inputs\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Inputs\""
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Context\""
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Controller\""
                                    }, {
                                        a: 1, backing: true, n: "<Inputs>k__BackingField", t: 4, rt: TInputs, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$Inputs\""
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
        }
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IBDDTest", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ExtensionPointAttribute.ctor], m: [{
                                ab: true, a: 2, n: "Given", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "setup", pt: Function, ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$Given", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                            }, {
                                ab: true, a: 2, n: "RunScenario", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }, {
                                ab: true, a: 2, n: "Then", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "assertion", pt: Function, ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$Then", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                            }, {
                                ab: true, a: 2, n: "When", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "action", pt: Function, ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$When", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.definei("EleWise.ELMA.TestFramework.API.IBaseViewItemComponentTestModel$4", EleWise_ELMA_TestFramework, function(TViewItem, TInputs, TContext, TController)
{
    return {
            $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2, m: [{
                                        ab: true, a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                ab: true, a: 2, n: "get_Context", t: 8, rt: TContext, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                    }, {
                                        ab: true, a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                ab: true, a: 2, n: "get_Controller", t: 8, rt: TController, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                    }, {
                                        ab: true, a: 2, n: "Inputs", t: 16, rt: TInputs, g: {
                                                ab: true, a: 2, n: "get_Inputs", t: 8, rt: TInputs, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Inputs\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Inputs\""
                                    }, {
                                        ab: true, a: 2, n: "ViewItem", t: 16, rt: TViewItem, g: {
                                                ab: true, a: 2, n: "get_ViewItem", t: 8, rt: TViewItem, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$ViewItem\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$ViewItem\""
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                    }, {
                                        a: 1, backing: true, n: "<Inputs>k__BackingField", t: 4, rt: TInputs, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Inputs\""
                                    }, {
                                        a: 1, backing: true, n: "<ViewItem>k__BackingField", t: 4, rt: TViewItem, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$\" + Bridge.getTypeAlias(TViewItem) + \"$\" + Bridge.getTypeAlias(TInputs) + \"$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$ViewItem\""
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
        }
});
Bridge.definei("EleWise.ELMA.TestFramework.API.IComponentTestModel$1", EleWise_ELMA_TestFramework, function(TController)
{
    return {
            $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2, m: [{
                                        ab: true, a: 2, n: "Context", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, g: {
                                                ab: true, a: 2, n: "get_Context", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                    }, {
                                        ab: true, a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                ab: true, a: 2, n: "get_Controller", t: 8, rt: TController, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
        }
});
Bridge.definei("EleWise.ELMA.TestFramework.API.IComponentTestModel$2", EleWise_ELMA_TestFramework, function(TContext, TController)
{
    return {
            $kind: "interface", $metadata: function()
                {
                    return {
                            att: 161, a: 2, m: [{
                                        ab: true, a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                ab: true, a: 2, n: "get_Context", t: 8, rt: TContext, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                    }, {
                                        ab: true, a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                ab: true, a: 2, n: "get_Controller", t: 8, rt: TController, fg: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                            }, fn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Context\""
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "\"EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$\" + Bridge.getTypeAlias(TContext) + \"$\" + Bridge.getTypeAlias(TController) + \"$Controller\""
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Assert", {
    $metadata: function()
    {
        return {
                att: 1048833, a: 2, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "DeepEqual", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "expected", pt: System.Object, ps: 1
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 2
                                    }], sn: "DeepEqual", rt: System.Void, p: [System.Object, System.Object, System.String]
                        }, {
                            a: 2, n: "Equal", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "expected", pt: System.Object, ps: 1
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 2
                                    }], sn: "Equal", rt: System.Void, p: [System.Object, System.Object, System.String]
                        }, {
                            a: 2, n: "False", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 1
                                    }], sn: "False", rt: System.Void, p: [System.Object, System.String]
                        }, {
                            a: 2, n: "NotDeepEqual", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "expected", pt: System.Object, ps: 1
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 2
                                    }], sn: "NotDeepEqual", rt: System.Void, p: [System.Object, System.Object, System.String]
                        }, {
                            a: 2, n: "NotEqual", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "expected", pt: System.Object, ps: 1
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 2
                                    }], sn: "NotEqual", rt: System.Void, p: [System.Object, System.Object, System.String]
                        }, {
                            a: 2, n: "NotNull", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 1
                                    }], sn: "NotNull", rt: System.Void, p: [System.Object, System.String]
                        }, {
                            a: 2, n: "Null", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 1
                                    }], sn: "Null", rt: System.Void, p: [System.Object, System.String]
                        }, {
                            a: 2, n: "Throws", is: true, t: 8, pi: [{
                                        n: "action", pt: Function, ps: 0
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 1
                                    }], sn: "Throws$2", rt: System.Void, p: [Function, System.String]
                        }, {
                            a: 2, n: "Throws", is: true, t: 8, pi: [{
                                        n: "action", pt: Function, ps: 0
                                    }, {
                                        n: "expected", pt: Function, ps: 1
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 2
                                    }], sn: "Throws", rt: System.Void, p: [Function, Function, System.String]
                        }, {
                            a: 2, n: "Throws", is: true, t: 8, pi: [{
                                        n: "action", pt: Function, ps: 0
                                    }, {
                                        n: "expected", pt: System.Object, ps: 1
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 2
                                    }], sn: "Throws$1", rt: System.Void, p: [Function, System.Object, System.String]
                        }, {
                            a: 2, n: "True", is: true, t: 8, pi: [{
                                        n: "actual", pt: System.Object, ps: 0
                                    }, {
                                        n: "message", dv: null, o: true, pt: System.String, ps: 1
                                    }], sn: "True", rt: System.Void, p: [System.Object, System.String]
                        }, {
                            a: 1, n: "assert", is: true, t: 16, rt: Function, g: {
                                    a: 1, n: "get_assert", t: 8, rt: Function, fg: "assert", is: true
                                }, fn: "assert"
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {
            props: {assert: {get: function()
                    {
                        
                        return EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.Assert
                    }}}, methods: {
                    Equal: function(actual, expected, message)
                    {
                        if (message === void 0)
                        {
                            message = null
                        }
                        
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().strictEqual(Bridge.unbox(actual), Bridge.unbox(expected), message)
                    }, NotEqual: function(actual, expected, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().notStrictEqual(Bridge.unbox(actual), Bridge.unbox(expected), message)
                        }, DeepEqual: function(actual, expected, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().deepEqual(Bridge.unbox(actual), Bridge.unbox(expected), message)
                        }, NotDeepEqual: function(actual, expected, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().notDeepEqual(Bridge.unbox(actual), Bridge.unbox(expected), message)
                        }, True: function(actual, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.Equal(actual, Bridge.box(true, System.Boolean, System.Boolean.toString), message)
                        }, False: function(actual, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.Equal(actual, Bridge.box(false, System.Boolean, System.Boolean.toString), message)
                        }, Throws$2: function(action, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().throws(action, message)
                        }, Throws$1: function(action, expected, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().throws(action, Bridge.unbox(expected), message)
                        }, Throws: function(action, expected, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().throws(action, expected, message)
                        }, Null: function(actual, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().equal(Bridge.unbox(actual), null, message)
                        }, NotNull: function(actual, message)
                        {
                            if (message === void 0)
                            {
                                message = null
                            }
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Assert.assert().notEqual(Bridge.unbox(actual), null, message)
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IBDDRunner", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "RunScenario", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDRunner$RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }, {
                                ab: true, a: 2, n: "RunScenario", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "modelCreator", pt: Function, ps: 1
                                        }, {
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 2
                                        }], tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDRunner$RunScenario$1", rt: System.Void, p: [System.String, Function, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IExecutableStep", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Execute", t: 8, pi: [{
                                            n: "context", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IExecutableStep$Execute", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IScenario", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Execute", t: 8, pi: [{
                                            n: "сontext", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Execute", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext]
                            }, {
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Name"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IScenarioBuilder", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Build", t: 8, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$Build", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario
                            }, {
                                ab: true, a: 2, n: "WithName", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithName", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioBuilder, p: [System.String]
                            }, {
                                ab: true, a: 2, n: "WithSteps", t: 8, pi: [{
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithSteps", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioBuilder, p: [System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "CurrentScenario", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, g: {
                                        ab: true, a: 2, n: "get_CurrentScenario", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario"
                                    }, s: {
                                        ab: true, a: 2, n: "set_CurrentScenario", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario"
                            }, {
                                ab: true, a: 2, n: "CurrentStep", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, g: {
                                        ab: true, a: 2, n: "get_CurrentStep", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentStep"
                                    }, s: {
                                        ab: true, a: 2, n: "set_CurrentStep", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentStep"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentStep"
                            }, {
                                ab: true, a: 2, n: "Model", t: 16, rt: System.Object, g: {
                                        ab: true, a: 2, n: "get_Model", t: 8, rt: System.Object, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Model", t: 8, p: [System.Object], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model"
                            }, {
                                ab: true, a: 2, n: "TestContext", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, g: {
                                        ab: true, a: 2, n: "get_TestContext", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$TestContext"
                                    }, s: {
                                        ab: true, a: 2, n: "set_TestContext", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$TestContext"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$TestContext"
                            }, {
                                a: 1, backing: true, n: "<CurrentScenario>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario"
                            }, {
                                a: 1, backing: true, n: "<CurrentStep>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentStep"
                            }, {
                                a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: System.Object, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model"
                            }, {
                                a: 1, backing: true, n: "<TestContext>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$TestContext"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.IStep", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 161, a: 2, m: [{
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name"
                            }, {
                                ab: true, a: 2, n: "Type", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, g: {
                                        ab: true, a: 2, n: "get_Type", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                            }
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name"
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.StepType", {
    $kind: "enum", $metadata: function()
        {
            return {
                    att: 257, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "GIVEN", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "GIVEN", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }, {
                                a: 2, n: "MOCK", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "MOCK", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }, {
                                a: 2, n: "STEP", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "STEP", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }, {
                                a: 2, n: "THEN", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "THEN", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }, {
                                a: 2, n: "WHEN", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "WHEN", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {fields: {
                STEP: 0, GIVEN: 1, WHEN: 2, THEN: 3, MOCK: 4
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ComponentTestFixture", {
    $metadata: function()
    {
        return {
                att: 1048832, a: 4, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Header", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f"), g: {
                                    a: 2, n: "get_Header", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f"), fg: "Header"
                                }, s: {
                                    a: 2, n: "set_Header", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f")], rt: System.Void, fs: "Header"
                                }, fn: "Header"
                        }, {
                            a: 2, n: "TestFixture", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, g: {
                                    a: 2, n: "get_TestFixture", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, fg: "TestFixture"
                                }, s: {
                                    a: 2, n: "set_TestFixture", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture], rt: System.Void, fs: "TestFixture"
                                }, fn: "TestFixture"
                        }, {
                            a: 1, backing: true, n: "<Header>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f"), sn: "Header"
                        }, {
                            a: 1, backing: true, n: "<TestFixture>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, sn: "TestFixture"
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Header: null, TestFixture: null
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ComponentTestFixtureTree", {
    $metadata: function()
    {
        return {
                att: 1048832, a: 4, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "ComponentCount", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_ComponentCount", t: 8, rt: System.Int32, fg: "ComponentCount", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_ComponentCount", t: 8, p: [System.Int32], rt: System.Void, fs: "ComponentCount"
                                }, fn: "ComponentCount"
                        }, {
                            a: 2, n: "TestComponentCount", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_TestComponentCount", t: 8, rt: System.Int32, fg: "TestComponentCount", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_TestComponentCount", t: 8, p: [System.Int32], rt: System.Void, fs: "TestComponentCount"
                                }, fn: "TestComponentCount"
                        }, {
                            a: 2, n: "TestModules", t: 16, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture), g: {
                                    a: 2, n: "get_TestModules", t: 8, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture), fg: "TestModules"
                                }, s: {
                                    a: 2, n: "set_TestModules", t: 8, p: [System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture)], rt: System.Void, fs: "TestModules"
                                }, fn: "TestModules"
                        }, {
                            a: 2, n: "TotalTestsCount", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_TotalTestsCount", t: 8, rt: System.Int32, fg: "TotalTestsCount", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_TotalTestsCount", t: 8, p: [System.Int32], rt: System.Void, fs: "TotalTestsCount"
                                }, fn: "TotalTestsCount"
                        }, {
                            a: 1, backing: true, n: "<ComponentCount>k__BackingField", t: 4, rt: System.Int32, sn: "ComponentCount", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<TestComponentCount>k__BackingField", t: 4, rt: System.Int32, sn: "TestComponentCount", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<TestModules>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture), sn: "TestModules"
                        }, {
                            a: 1, backing: true, n: "<TotalTestsCount>k__BackingField", t: 4, rt: System.Int32, sn: "TotalTestsCount", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            ComponentCount: 0, TestComponentCount: 0, TotalTestsCount: 0, TestModules: null
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ITestAssembly", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Assembly", t: 16, rt: System.Reflection.Assembly, g: {
                                        ab: true, a: 2, n: "get_Assembly", t: 8, rt: System.Reflection.Assembly, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Assembly"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Assembly"
                            }, {
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Name"
                            }, {
                                ab: true, a: 2, n: "TestFixtures", t: 16, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), g: {
                                        ab: true, a: 2, n: "get_TestFixtures", t: 8, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$TestFixtures"
                                    }, s: {
                                        ab: true, a: 2, n: "set_TestFixtures", t: 8, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture)], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$TestFixtures"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$TestFixtures"
                            }, {
                                a: 1, backing: true, n: "<Assembly>k__BackingField", t: 4, rt: System.Reflection.Assembly, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Assembly"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Name"
                            }, {
                                a: 1, backing: true, n: "<TestFixtures>k__BackingField", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$TestFixtures"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ITestAssemblyBuilder", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Build", t: 8, pi: [{
                                            n: "assembly", pt: System.Reflection.Assembly, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssemblyBuilder$Build", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly, p: [System.Reflection.Assembly]
                            }, {
                                ab: true, a: 2, n: "Build", t: 8, pi: [{
                                            n: "assemblies", pt: System.Array.type(System.Reflection.Assembly), ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssemblyBuilder$Build$1", rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly), p: [System.Array.type(System.Reflection.Assembly)]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ITestContext", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "PopResult", t: 8, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$PopResult", rt: System.Void
                            }, {
                                ab: true, a: 2, n: "SetResult", t: 8, pi: [{
                                            n: "value", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$SetResult", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult]
                            }, {
                                ab: true, a: 2, n: "Assert", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_Assert", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Assert"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Assert", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Assert"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Assert"
                            }, {
                                ab: true, a: 2, n: "CurrentResult", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, g: {
                                        ab: true, a: 2, n: "get_CurrentResult", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentResult"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentResult"
                            }, {
                                ab: true, a: 2, n: "CurrentTest", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, g: {
                                        ab: true, a: 2, n: "get_CurrentTest", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTest"
                                    }, s: {
                                        ab: true, a: 2, n: "set_CurrentTest", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTest"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTest"
                            }, {
                                ab: true, a: 2, n: "CurrentTestFixture", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, g: {
                                        ab: true, a: 2, n: "get_CurrentTestFixture", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTestFixture"
                                    }, s: {
                                        ab: true, a: 2, n: "set_CurrentTestFixture", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTestFixture"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTestFixture"
                            }, {
                                ab: true, a: 2, n: "Notifier", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, g: {
                                        ab: true, a: 2, n: "get_Notifier", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Notifier"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Notifier", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Notifier"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Notifier"
                            }, {
                                ab: true, a: 2, n: "ScenarioCount", t: 16, rt: System.Int32, g: {
                                        ab: true, a: 2, n: "get_ScenarioCount", t: 8, rt: System.Int32, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$ScenarioCount", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        ab: true, a: 2, n: "set_ScenarioCount", t: 8, p: [System.Int32], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$ScenarioCount"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$ScenarioCount"
                            }, {
                                ab: true, a: 2, n: "TestFactory", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, g: {
                                        ab: true, a: 2, n: "get_TestFactory", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$TestFactory"
                                    }, s: {
                                        ab: true, a: 2, n: "set_TestFactory", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$TestFactory"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$TestFactory"
                            }, {
                                a: 1, backing: true, n: "<Assert>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Assert"
                            }, {
                                a: 1, backing: true, n: "<CurrentResult>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentResult"
                            }, {
                                a: 1, backing: true, n: "<CurrentTest>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTest"
                            }, {
                                a: 1, backing: true, n: "<CurrentTestFixture>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTestFixture"
                            }, {
                                a: 1, backing: true, n: "<Notifier>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Notifier"
                            }, {
                                a: 1, backing: true, n: "<ScenarioCount>k__BackingField", t: 4, rt: System.Int32, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$ScenarioCount", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<TestFactory>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$TestFactory"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ITestFixture", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Instance", t: 16, rt: System.Object, g: {
                                        ab: true, a: 2, n: "get_Instance", t: 8, rt: System.Object, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Instance", t: 8, p: [System.Object], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance"
                            }, {
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name"
                            }, {
                                ab: true, a: 2, n: "OneTimeSetUp", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OneTimeSetUp", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$OneTimeSetUp"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OneTimeSetUp", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$OneTimeSetUp"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$OneTimeSetUp"
                            }, {
                                ab: true, a: 2, n: "Result", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, g: {
                                        ab: true, a: 2, n: "get_Result", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Result"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Result", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Result"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Result"
                            }, {
                                ab: true, a: 2, n: "SetUp", t: 16, rt: System.Reflection.MethodInfo, g: {
                                        ab: true, a: 2, n: "get_SetUp", t: 8, rt: System.Reflection.MethodInfo, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SetUp"
                                    }, s: {
                                        ab: true, a: 2, n: "set_SetUp", t: 8, p: [System.Reflection.MethodInfo], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SetUp"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SetUp"
                            }, {
                                ab: true, a: 2, n: "Skip", t: 16, rt: System.Boolean, g: {
                                        ab: true, a: 2, n: "get_Skip", t: 8, rt: System.Boolean, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip"
                            }, {
                                ab: true, a: 2, n: "SkipReason", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_SkipReason", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SkipReason"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SkipReason"
                            }, {
                                ab: true, a: 2, n: "TearDown", t: 16, rt: System.Reflection.MethodInfo, g: {
                                        ab: true, a: 2, n: "get_TearDown", t: 8, rt: System.Reflection.MethodInfo, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$TearDown"
                                    }, s: {
                                        ab: true, a: 2, n: "set_TearDown", t: 8, p: [System.Reflection.MethodInfo], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$TearDown"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$TearDown"
                            }, {
                                ab: true, a: 2, n: "Tests", t: 16, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod), g: {
                                        ab: true, a: 2, n: "get_Tests", t: 8, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod), fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Tests"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Tests"
                            }, {
                                ab: true, a: 2, n: "Type", t: 16, rt: System.Type, g: {
                                        ab: true, a: 2, n: "get_Type", t: 8, rt: System.Type, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Type"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Type"
                            }, {
                                a: 1, backing: true, n: "<Instance>k__BackingField", t: 4, rt: System.Object, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name"
                            }, {
                                a: 1, backing: true, n: "<OneTimeSetUp>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$OneTimeSetUp"
                            }, {
                                a: 1, backing: true, n: "<Result>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Result"
                            }, {
                                a: 1, backing: true, n: "<SetUp>k__BackingField", t: 4, rt: System.Reflection.MethodInfo, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SetUp"
                            }, {
                                a: 1, backing: true, n: "<Skip>k__BackingField", t: 4, rt: System.Boolean, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, backing: true, n: "<SkipReason>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SkipReason"
                            }, {
                                a: 1, backing: true, n: "<TearDown>k__BackingField", t: 4, rt: System.Reflection.MethodInfo, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$TearDown"
                            }, {
                                a: 1, backing: true, n: "<Tests>k__BackingField", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod), sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Tests"
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: System.Type, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Type"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ITestMethod", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "ExpectedCount", t: 16, rt: System.Nullable$1(System.Int32), g: {
                                        ab: true, a: 2, n: "get_ExpectedCount", t: 8, rt: System.Nullable$1(System.Int32), fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32, System.Nullable.toString, System.Nullable.getHashCode)
                                            }
                                    }, s: {
                                        ab: true, a: 2, n: "set_ExpectedCount", t: 8, p: [System.Nullable$1(System.Int32)], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount"
                            }, {
                                ab: true, a: 2, n: "Fixture", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, g: {
                                        ab: true, a: 2, n: "get_Fixture", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Fixture"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Fixture"
                            }, {
                                ab: true, a: 2, n: "FullName", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_FullName", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$FullName"
                                    }, s: {
                                        ab: true, a: 2, n: "set_FullName", t: 8, p: [System.String], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$FullName"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$FullName"
                            }, {
                                ab: true, a: 2, n: "Method", t: 16, rt: System.Reflection.MethodInfo, g: {
                                        ab: true, a: 2, n: "get_Method", t: 8, rt: System.Reflection.MethodInfo, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Method"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Method"
                            }, {
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name"
                            }, {
                                ab: true, a: 2, n: "Skip", t: 16, rt: System.Boolean, g: {
                                        ab: true, a: 2, n: "get_Skip", t: 8, rt: System.Boolean, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Skip", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Skip"
                            }, {
                                ab: true, a: 2, n: "SkipReason", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_SkipReason", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$SkipReason"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$SkipReason"
                            }, {
                                a: 1, backing: true, n: "<ExpectedCount>k__BackingField", t: 4, rt: System.Nullable$1(System.Int32), sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32, System.Nullable.toString, System.Nullable.getHashCode)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Fixture>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Fixture"
                            }, {
                                a: 1, backing: true, n: "<FullName>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$FullName"
                            }, {
                                a: 1, backing: true, n: "<Method>k__BackingField", t: 4, rt: System.Reflection.MethodInfo, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Method"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name"
                            }, {
                                a: 1, backing: true, n: "<Skip>k__BackingField", t: 4, rt: System.Boolean, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Skip", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, backing: true, n: "<SkipReason>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$SkipReason"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Core.ITestRunner", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceContractAttribute], m: [{
                                ab: true, a: 2, n: "Run", t: 8, pi: [{
                                            n: "testAssembly", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly]
                            }, {
                                ab: true, a: 2, n: "Run", t: 8, pi: [{
                                            n: "test", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$2", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod]
                            }, {
                                ab: true, a: 2, n: "Run", t: 8, pi: [{
                                            n: "testAssemblies", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly), ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$3", rt: System.Void, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly)]
                            }, {
                                ab: true, a: 2, n: "Run", t: 8, pi: [{
                                            n: "testFixtures", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$4", rt: System.Void, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture)]
                            }, {
                                ab: true, a: 2, n: "Run", t: 8, pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }, {
                                            n: "testNotifier", dv: null, o: true, pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, ps: 1
                                        }, {
                                            n: "setup", dv: null, o: true, pt: Function, ps: 2
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$1", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, Function]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Helpers.Promise", {
    inherits: [Bridge.IPromise], $metadata: function()
        {
            return {
                    nested: [Function, Function, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Handler, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which], att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 1, n: "Complete", t: 8, pi: [{
                                            n: "which", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which, ps: 0
                                        }, {
                                            n: "args", ip: true, pt: System.Array.type(System.Object), ps: 1
                                        }], sn: "Complete", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which, System.Array.type(System.Object)]
                            }, {
                                a: 2, n: "Progress", t: 8, pi: [{
                                            n: "args", ip: true, pt: System.Array.type(System.Object), ps: 0
                                        }], sn: "Progress", rt: System.Void, p: [System.Array.type(System.Object)]
                            }, {
                                a: 2, n: "Promisify", is: true, t: 8, pi: [{
                                            n: "asyncFunc", pt: Function, ps: 0
                                        }], sn: "Promisify", rt: Function, p: [Function]
                            }, {
                                a: 2, n: "Reject", t: 8, pi: [{
                                            n: "args", ip: true, pt: System.Array.type(System.Object), ps: 0
                                        }], sn: "Reject", rt: System.Void, p: [System.Array.type(System.Object)]
                            }, {
                                a: 2, n: "Resolve", t: 8, pi: [{
                                            n: "args", ip: true, pt: System.Array.type(System.Object), ps: 0
                                        }], sn: "Resolve", rt: System.Void, p: [System.Array.type(System.Object)]
                            }, {
                                a: 2, n: "Then", t: 8, pi: [{
                                            n: "fulfilledHandler", pt: Function, ps: 0
                                        }, {
                                            n: "errorHandler", dv: null, o: true, pt: Function, ps: 1
                                        }, {
                                            n: "progressHandler", dv: null, o: true, pt: Function, ps: 2
                                        }], sn: "then", rt: System.Void, p: [Function, Function, Function]
                            }, {
                                a: 1, n: "doThen", t: 4, rt: Function, sn: "doThen"
                            }, {
                                a: 1, n: "thens", t: 4, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Handler), sn: "thens"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {methods: {Promisify: function(asyncFunc)
                {
                    
                    return function()
                        {
                            
                            var promise = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise;
                            
                            (function()
                            {
                                var $step = 0,
                                    $task1,
                                    $jumpFromFinally,
                                    $tcs = new System.Threading.Tasks.TaskCompletionSource,
                                    $returnValue,
                                    ex,
                                    $async_e,
                                    $async_e1,
                                    $asyncBody = Bridge.fn.bind(this, function()
                                    {
                                        try
                                        {
                                            for (; ; )
                                            {
                                                $step = System.Array.min([1, 2, 3, 4], $step);
                                                switch ($step)
                                                {
                                                    case 1:
                                                        {
                                                            
                                                            $task1 = asyncFunc();
                                                            $step = 2;
                                                            if ($task1.isCompleted())
                                                                continue;
                                                            $task1.continue($asyncBody);
                                                            return
                                                        }
                                                    case 2:
                                                        {
                                                            $task1.getAwaitedResult();
                                                            
                                                            promise.Resolve();
                                                            $step = 4;
                                                            continue
                                                        }
                                                    case 3:
                                                        {
                                                            
                                                            promise.Reject([ex]);
                                                            $async_e = null;
                                                            $step = 4;
                                                            continue
                                                        }
                                                    case 4:
                                                        {
                                                            $tcs.setResult(null);
                                                            return
                                                        }
                                                    default:
                                                        {
                                                            $tcs.setResult(null);
                                                            return
                                                        }
                                                }
                                            }
                                        }
                                        catch($async_e1)
                                        {
                                            $async_e = System.Exception.create($async_e1);
                                            if ($step >= 1 && $step <= 2)
                                            {
                                                ex = $async_e;
                                                $step = 3;
                                                if (mobx._getGlobalState().allowStateChanges)
                                                {
                                                    $asyncBody = mobx.action($asyncBody)
                                                }
                                                $asyncBody();
                                                return
                                            }
                                            $tcs.setException($async_e)
                                        }
                                    }, arguments);
                                if (mobx._getGlobalState().allowStateChanges)
                                {
                                    $asyncBody = mobx.action($asyncBody)
                                }
                                $asyncBody();
                                return $tcs.task
                            })();
                            
                            return promise
                        }
                }}}, fields: {
            doThen: null, thens: null
        }, alias: ["then", "Bridge$IPromise$then"], ctors: {ctor: function()
            {
                this.$initialize();
                
                this.thens = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Handler)).ctor;
                
                this.doThen = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.f1))
            }}, methods: {
            then: function(fulfilledHandler, errorHandler, progressHandler)
            {
                if (errorHandler === void 0)
                {
                    errorHandler = null
                }
                if (progressHandler === void 0)
                {
                    progressHandler = null
                }
                
                this.doThen(fulfilledHandler, errorHandler, progressHandler)
            }, Resolve: function(args)
                {
                    if (args === void 0)
                    {
                        args = []
                    }
                    
                    this.Complete(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which.Resolve, args)
                }, Reject: function(args)
                {
                    if (args === void 0)
                    {
                        args = []
                    }
                    
                    this.Complete(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which.Reject, args)
                }, Progress: function(args)
                {
                    if (args === void 0)
                    {
                        args = []
                    }
                    
                    var i = 0;
                    
                    while (i < this.thens.Count)
                    {
                        
                        var aThen = this.thens.getItem(i);
                        
                        if (!Bridge.staticEquals(aThen.Progress, null))
                        {
                            
                            aThen.Progress(args)
                        }
                        
                        i = (i + 1) | 0
                    }
                }, Complete: function(which, args)
                {
                    if (args === void 0)
                    {
                        args = []
                    }
                    
                    if (which === EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which.Resolve)
                    {
                        
                        this.doThen = Bridge.fn.bind(this, function(f, e, p)
                        {
                            
                            this.Resolve(args)
                        })
                    }
                    else
                    {
                        
                        this.doThen = Bridge.fn.bind(this, function(f, e, p)
                        {
                            
                            this.Reject(args)
                        })
                    }
                    
                    var i = 0;
                    
                    while (i < this.thens.Count)
                    {
                        
                        var aThen = this.thens.getItem(i);
                        
                        if (which === EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which.Resolve)
                        {
                            
                            if (!Bridge.staticEquals(aThen.Filled, null))
                            {
                                
                                aThen.Filled.apply(null, args)
                            }
                        }
                        else
                        {
                            
                            if (!Bridge.staticEquals(aThen.Error, null))
                            {
                                
                                aThen.Error.apply(null, args)
                            }
                        }
                        
                        if (!Bridge.staticEquals(aThen.Progress, null))
                        {
                            
                            aThen.Progress([Bridge.box(100, System.Int32)])
                        }
                        
                        i = (i + 1) | 0
                    }
                    
                    this.thens.clear()
                }
        }
});
Bridge.ns("EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise, {f1: function(f, e, p)
    {
        var $t;
        
        this.thens.add(($t = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Handler, $t.Filled = f, $t.Error = e, $t.Progress = p, $t))
    }});
Bridge.define("EleWise.ELMA.TestFramework.Helpers.Promise.Handler", {
    $kind: "nested class", $metadata: function()
        {
            return {
                    td: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise, att: 1048579, a: 1, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Error", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Error", t: 8, rt: Function, fg: "Error"
                                    }, s: {
                                        a: 2, n: "set_Error", t: 8, p: [Function], rt: System.Void, fs: "Error"
                                    }, fn: "Error"
                            }, {
                                a: 2, n: "Filled", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Filled", t: 8, rt: Function, fg: "Filled"
                                    }, s: {
                                        a: 2, n: "set_Filled", t: 8, p: [Function], rt: System.Void, fs: "Filled"
                                    }, fn: "Filled"
                            }, {
                                a: 2, n: "Progress", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Progress", t: 8, rt: Function, fg: "Progress"
                                    }, s: {
                                        a: 2, n: "set_Progress", t: 8, p: [Function], rt: System.Void, fs: "Progress"
                                    }, fn: "Progress"
                            }, {
                                a: 1, backing: true, n: "<Error>k__BackingField", t: 4, rt: Function, sn: "Error"
                            }, {
                                a: 1, backing: true, n: "<Filled>k__BackingField", t: 4, rt: Function, sn: "Filled"
                            }, {
                                a: 1, backing: true, n: "<Progress>k__BackingField", t: 4, rt: Function, sn: "Progress"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Filled: null, Error: null, Progress: null
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Helpers.Promise.Which", {
    $kind: "nested enum", $metadata: function()
        {
            return {
                    td: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise, att: 259, a: 1, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Reject", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which, sn: "Reject", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which))
                                    }
                            }, {
                                a: 2, n: "Resolve", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which, sn: "Resolve", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Which))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {fields: {
                Resolve: 0, Reject: 1
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Helpers.QUnitHelper", {
    $metadata: function()
    {
        return {
                nested: [System.Object], att: 1048960, a: 4, s: true, m: [{
                            a: 4, n: "Load", is: true, t: 8, tpc: 0, def: function()
                                {
                                    return qunitLoader()
                                }, rt: System.Void
                        }, {
                            a: 2, n: "Module", is: true, t: 8, pi: [{
                                        n: "name", pt: System.String, ps: 0
                                    }, {
                                        n: "hooks", pt: System.Object, ps: 1
                                    }], tpc: 0, def: function(name, hooks)
                                {
                                    return QUnit.module(name, hooks)
                                }, rt: System.Void, p: [System.String, System.Object]
                        }, {
                            a: 2, n: "Module", is: true, t: 8, pi: [{
                                        n: "name", pt: System.String, ps: 0
                                    }, {
                                        n: "callback", pt: Function, ps: 1
                                    }], tpc: 0, def: function(name, callback)
                                {
                                    return QUnit.module(name, callback)
                                }, rt: System.Void, p: [System.String, Function]
                        }, {
                            a: 2, n: "Module", is: true, t: 8, pi: [{
                                        n: "name", pt: System.String, ps: 0
                                    }, {
                                        n: "hooks", pt: System.Object, ps: 1
                                    }, {
                                        n: "callback", pt: Function, ps: 2
                                    }], tpc: 0, def: function(name, hooks, callback)
                                {
                                    return QUnit.module(name, hooks, callback)
                                }, rt: System.Void, p: [System.String, System.Object, Function]
                        }, {
                            a: 2, n: "SkipModule", is: true, t: 8, pi: [{
                                        n: "name", pt: System.String, ps: 0
                                    }], tpc: 0, def: function(name)
                                {
                                    return QUnit.module.skip(name)
                                }, rt: System.Void, p: [System.String]
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.IgnoreAttribute", {
    inherits: [System.Attribute], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.String], pi: [{
                                            n: "reason", pt: System.String, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Reason", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Reason", t: 8, rt: System.String, fg: "Reason"
                                    }, s: {
                                        a: 1, n: "set_Reason", t: 8, p: [System.String], rt: System.Void, fs: "Reason"
                                    }, fn: "Reason"
                            }, {
                                a: 1, backing: true, n: "<Reason>k__BackingField", t: 4, rt: System.String, sn: "Reason"
                            }], ni: true
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {Reason: null}, ctors: {ctor: function(reason)
            {
                this.$initialize();
                System.Attribute.ctor.call(this);
                
                this.Reason = reason
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.ITestController", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceContractAttribute], m: [{
                                ab: true, a: 2, n: "LoadComponentTests", t: 8, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$LoadComponentTests", rt: System.Threading.Tasks.Task$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixtureTree)
                            }, {
                                ab: true, a: 2, n: "RunComponentTests", t: 8, pi: [{
                                            n: "testNotifier", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$RunComponentTests", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier]
                            }, {
                                ab: true, a: 2, n: "RunComponentTests", t: 8, pi: [{
                                            n: "componentUid", pt: System.Guid, ps: 0
                                        }, {
                                            n: "testNotifier", dv: null, o: true, pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$RunComponentTests$1", rt: System.Void, p: [System.Guid, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier]
                            }, {
                                ab: true, a: 2, n: "RunTests", t: 8, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$RunTests", rt: System.Void
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Mocking.IMock", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "WasCalled", t: 8, pi: [{
                                            n: "count", dv: 0, o: true, pt: System.Int32, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Mocking$IMock$WasCalled", rt: System.Boolean, p: [System.Int32], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Mocking$IMock$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Mocking$IMock$Name"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Mocking$IMock$Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.IScenarioInfo", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioInfo$Name"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioInfo$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioInfo$Name"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioInfo$Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.IScenarioProgressNotifier", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "ScenarioFinished", t: 8, pi: [{
                                            n: "scenario", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IScenarioResult, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$ScenarioFinished", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IScenarioResult]
                            }, {
                                ab: true, a: 2, n: "ScenarioStarted", t: 8, pi: [{
                                            n: "scenario", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IScenarioInfo, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$ScenarioStarted", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IScenarioInfo]
                            }, {
                                ab: true, a: 2, n: "StepFinished", t: 8, pi: [{
                                            n: "step", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$StepFinished", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult]
                            }, {
                                ab: true, a: 2, n: "StepStarted", t: 8, pi: [{
                                            n: "step", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IStepInfo, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$StepStarted", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IStepInfo]
                            }, {
                                ab: true, a: 2, n: "OnScenarioEnd", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnScenarioEnd", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioEnd"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnScenarioEnd", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioEnd"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioEnd"
                            }, {
                                ab: true, a: 2, n: "OnScenarioStart", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnScenarioStart", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioStart"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnScenarioStart", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioStart"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioStart"
                            }, {
                                ab: true, a: 2, n: "OnStepEnd", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnStepEnd", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepEnd"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnStepEnd", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepEnd"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepEnd"
                            }, {
                                ab: true, a: 2, n: "OnStepStart", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnStepStart", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepStart"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnStepStart", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepStart"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepStart"
                            }, {
                                a: 1, backing: true, n: "<OnScenarioEnd>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioEnd"
                            }, {
                                a: 1, backing: true, n: "<OnScenarioStart>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnScenarioStart"
                            }, {
                                a: 1, backing: true, n: "<OnStepEnd>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepEnd"
                            }, {
                                a: 1, backing: true, n: "<OnStepStart>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$OnStepStart"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.IStepInfo", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Name"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Name"
                            }, {
                                ab: true, a: 2, n: "Number", t: 16, rt: System.Int32, g: {
                                        ab: true, a: 2, n: "get_Number", t: 8, rt: System.Int32, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Number", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        ab: true, a: 2, n: "set_Number", t: 8, p: [System.Int32], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Number"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Number"
                            }, {
                                ab: true, a: 2, n: "Total", t: 16, rt: System.Int32, g: {
                                        ab: true, a: 2, n: "get_Total", t: 8, rt: System.Int32, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Total", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        ab: true, a: 2, n: "set_Total", t: 8, p: [System.Int32], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Total"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Total"
                            }, {
                                ab: true, a: 2, n: "Type", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, g: {
                                        ab: true, a: 2, n: "get_Type", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Type", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                            }
                                    }, s: {
                                        ab: true, a: 2, n: "set_Type", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Type"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Type"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Name"
                            }, {
                                a: 1, backing: true, n: "<Number>k__BackingField", t: 4, rt: System.Int32, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Number", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Total>k__BackingField", t: 4, rt: System.Int32, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Total", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Type", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.ITestNotifier", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceContractAttribute], m: [{
                                ab: true, a: 2, n: "NotifyEnd", t: 8, pi: [{
                                            n: "result", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyEnd", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult]
                            }, {
                                ab: true, a: 2, n: "NotifyFixtureDone", t: 8, pi: [{
                                            n: "result", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyFixtureDone", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult]
                            }, {
                                ab: true, a: 2, n: "NotifyFixtureStart", t: 8, pi: [{
                                            n: "info", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestFixtureInfo, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyFixtureStart", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestFixtureInfo]
                            }, {
                                ab: true, a: 2, n: "NotifyStart", t: 8, pi: [{
                                            n: "info", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestSuiteInfo, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyStart", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestSuiteInfo]
                            }, {
                                ab: true, a: 2, n: "NotifyTestEnd", t: 8, pi: [{
                                            n: "result", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestResult, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyTestEnd", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestResult]
                            }, {
                                ab: true, a: 2, n: "NotifyTestStart", t: 8, pi: [{
                                            n: "info", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestInfo, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyTestStart", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestInfo]
                            }, {
                                ab: true, a: 2, n: "OnEnd", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnEnd", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnEnd"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnEnd", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnEnd"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnEnd"
                            }, {
                                ab: true, a: 2, n: "OnFixtureEnd", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnFixtureEnd", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureEnd"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnFixtureEnd", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureEnd"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureEnd"
                            }, {
                                ab: true, a: 2, n: "OnFixtureStart", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnFixtureStart", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureStart"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnFixtureStart", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureStart"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureStart"
                            }, {
                                ab: true, a: 2, n: "OnStart", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnStart", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnStart"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnStart", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnStart"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnStart"
                            }, {
                                ab: true, a: 2, n: "OnTestEnd", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnTestEnd", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestEnd"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnTestEnd", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestEnd"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestEnd"
                            }, {
                                ab: true, a: 2, n: "OnTestStart", t: 16, rt: Function, g: {
                                        ab: true, a: 2, n: "get_OnTestStart", t: 8, rt: Function, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestStart"
                                    }, s: {
                                        ab: true, a: 2, n: "set_OnTestStart", t: 8, p: [Function], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestStart"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestStart"
                            }, {
                                a: 1, backing: true, n: "<OnEnd>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnEnd"
                            }, {
                                a: 1, backing: true, n: "<OnFixtureEnd>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureEnd"
                            }, {
                                a: 1, backing: true, n: "<OnFixtureStart>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnFixtureStart"
                            }, {
                                a: 1, backing: true, n: "<OnStart>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnStart"
                            }, {
                                a: 1, backing: true, n: "<OnTestEnd>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestEnd"
                            }, {
                                a: 1, backing: true, n: "<OnTestStart>k__BackingField", t: 4, rt: Function, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$OnTestStart"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.TestFixtureInfo", {
    $metadata: function()
    {
        return {
                att: 1048832, a: 4, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Name", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                }, s: {
                                    a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                }, fn: "Name"
                        }, {
                            a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {Name: null}
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.TestInfo", {
    $metadata: function()
    {
        return {
                att: 1048832, a: 4, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Module", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Module", t: 8, rt: System.String, fg: "Module"
                                }, s: {
                                    a: 2, n: "set_Module", t: 8, p: [System.String], rt: System.Void, fs: "Module"
                                }, fn: "Module"
                        }, {
                            a: 2, n: "Name", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                }, s: {
                                    a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                }, fn: "Name"
                        }, {
                            a: 1, backing: true, n: "<Module>k__BackingField", t: 4, rt: System.String, sn: "Module"
                        }, {
                            a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Name: null, Module: null
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.TestSuiteInfo", {
    $metadata: function()
    {
        return {
                att: 1048832, a: 4, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "TestCount", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_TestCount", t: 8, rt: System.Int32, fg: "TestCount", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_TestCount", t: 8, p: [System.Int32], rt: System.Void, fs: "TestCount"
                                }, fn: "TestCount"
                        }, {
                            a: 1, backing: true, n: "<TestCount>k__BackingField", t: 4, rt: System.Int32, sn: "TestCount", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {TestCount: 0}
});
Bridge.define("EleWise.ELMA.TestFramework.Results.AssertResult", {
    $metadata: function()
    {
        return {
                att: 1048832, a: 4, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "Actual", t: 16, rt: System.Object, g: {
                                    a: 2, n: "get_Actual", t: 8, rt: System.Object, fg: "Actual"
                                }, s: {
                                    a: 2, n: "set_Actual", t: 8, p: [System.Object], rt: System.Void, fs: "Actual"
                                }, fn: "Actual"
                        }, {
                            a: 2, n: "Expected", t: 16, rt: System.Object, g: {
                                    a: 2, n: "get_Expected", t: 8, rt: System.Object, fg: "Expected"
                                }, s: {
                                    a: 2, n: "set_Expected", t: 8, p: [System.Object], rt: System.Void, fs: "Expected"
                                }, fn: "Expected"
                        }, {
                            a: 2, n: "Id", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Id", t: 8, rt: System.String, fg: "Id"
                                }, s: {
                                    a: 2, n: "set_Id", t: 8, p: [System.String], rt: System.Void, fs: "Id"
                                }, fn: "Id"
                        }, {
                            a: 2, n: "Message", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Message", t: 8, rt: System.String, fg: "Message"
                                }, s: {
                                    a: 2, n: "set_Message", t: 8, p: [System.String], rt: System.Void, fs: "Message"
                                }, fn: "Message"
                        }, {
                            a: 2, n: "Module", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Module", t: 8, rt: System.String, fg: "Module"
                                }, s: {
                                    a: 2, n: "set_Module", t: 8, p: [System.String], rt: System.Void, fs: "Module"
                                }, fn: "Module"
                        }, {
                            a: 2, n: "Negative", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_Negative", t: 8, rt: System.Boolean, fg: "Negative", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_Negative", t: 8, p: [System.Boolean], rt: System.Void, fs: "Negative"
                                }, fn: "Negative"
                        }, {
                            a: 2, n: "Passed", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_Passed", t: 8, rt: System.Boolean, fg: "Passed", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_Passed", t: 8, p: [System.Boolean], rt: System.Void, fs: "Passed"
                                }, fn: "Passed"
                        }, {
                            a: 2, n: "Source", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Source", t: 8, rt: System.String, fg: "Source"
                                }, s: {
                                    a: 2, n: "set_Source", t: 8, p: [System.String], rt: System.Void, fs: "Source"
                                }, fn: "Source"
                        }, {
                            a: 1, backing: true, n: "<Actual>k__BackingField", t: 4, rt: System.Object, sn: "Actual"
                        }, {
                            a: 1, backing: true, n: "<Expected>k__BackingField", t: 4, rt: System.Object, sn: "Expected"
                        }, {
                            a: 1, backing: true, n: "<Id>k__BackingField", t: 4, rt: System.String, sn: "Id"
                        }, {
                            a: 1, backing: true, n: "<Message>k__BackingField", t: 4, rt: System.String, sn: "Message"
                        }, {
                            a: 1, backing: true, n: "<Module>k__BackingField", t: 4, rt: System.String, sn: "Module"
                        }, {
                            a: 1, backing: true, n: "<Negative>k__BackingField", t: 4, rt: System.Boolean, sn: "Negative", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, backing: true, n: "<Passed>k__BackingField", t: 4, rt: System.Boolean, sn: "Passed", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, backing: true, n: "<Source>k__BackingField", t: 4, rt: System.String, sn: "Source"
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Passed: false, Actual: null, Expected: null, Negative: false, Message: null, Source: null, Module: null, Id: null
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Results.IScenarioResult", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Steps", t: 16, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult), g: {
                                        ab: true, a: 2, n: "get_Steps", t: 8, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult), fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IScenarioResult$Steps"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Steps", t: 8, p: [System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult)], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IScenarioResult$Steps"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IScenarioResult$Steps"
                            }, {
                                a: 1, backing: true, n: "<Steps>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult), sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IScenarioResult$Steps"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Results.IStepResult", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        ab: true, a: 2, n: "get_Name", t: 8, rt: System.String, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Name"
                                    }, s: {
                                        ab: true, a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Name"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Name"
                            }, {
                                ab: true, a: 2, n: "Step", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, g: {
                                        ab: true, a: 2, n: "get_Step", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, fg: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Step"
                                    }, fn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Step"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Name"
                            }, {
                                a: 1, backing: true, n: "<Step>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Step"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Results.TestSuiteResult", {
    $metadata: function()
    {
        return {
                att: 1048576, a: 4, m: [{
                            a: 2, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 4, n: "AddAssertResult", t: 8, pi: [{
                                        n: "result", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult, ps: 0
                                    }], sn: "AddAssertResult", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult]
                        }, {
                            a: 4, n: "AddChildResult", t: 8, pi: [{
                                        n: "result", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, ps: 0
                                    }], sn: "AddChildResult", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult]
                        }, {
                            a: 2, n: "Asserts", t: 16, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult), g: {
                                    a: 2, n: "get_Asserts", t: 8, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult), fg: "Asserts"
                                }, s: {
                                    a: 2, n: "set_Asserts", t: 8, p: [System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult)], rt: System.Void, fs: "Asserts"
                                }, fn: "Asserts"
                        }, {
                            a: 2, n: "Children", t: 16, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult), g: {
                                    a: 2, n: "get_Children", t: 8, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult), fg: "Children"
                                }, s: {
                                    a: 2, n: "set_Children", t: 8, p: [System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult)], rt: System.Void, fs: "Children"
                                }, fn: "Children"
                        }, {
                            a: 2, n: "Duration", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_Duration", t: 8, rt: System.Int32, fg: "Duration", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_Duration", t: 8, p: [System.Int32], rt: System.Void, fs: "Duration"
                                }, fn: "Duration"
                        }, {
                            a: 2, n: "Exception", t: 16, rt: System.Exception, g: {
                                    a: 2, n: "get_Exception", t: 8, rt: System.Exception, fg: "Exception"
                                }, s: {
                                    a: 2, n: "set_Exception", t: 8, p: [System.Exception], rt: System.Void, fs: "Exception"
                                }, fn: "Exception"
                        }, {
                            a: 2, n: "Failed", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_Failed", t: 8, rt: System.Int32, fg: "Failed", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_Failed", t: 8, p: [System.Int32], rt: System.Void, fs: "Failed"
                                }, fn: "Failed"
                        }, {
                            a: 2, n: "FailedIds", t: 16, rt: System.Collections.Generic.ICollection$1(System.String), g: {
                                    a: 2, n: "get_FailedIds", t: 8, rt: System.Collections.Generic.ICollection$1(System.String), fg: "FailedIds"
                                }, s: {
                                    a: 2, n: "set_FailedIds", t: 8, p: [System.Collections.Generic.ICollection$1(System.String)], rt: System.Void, fs: "FailedIds"
                                }, fn: "FailedIds"
                        }, {
                            a: 2, n: "FullName", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_FullName", t: 8, rt: System.String, fg: "FullName"
                                }, s: {
                                    a: 2, n: "set_FullName", t: 8, p: [System.String], rt: System.Void, fs: "FullName"
                                }, fn: "FullName"
                        }, {
                            a: 2, n: "Id", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Id", t: 8, rt: System.String, fg: "Id"
                                }, s: {
                                    a: 2, n: "set_Id", t: 8, p: [System.String], rt: System.Void, fs: "Id"
                                }, fn: "Id"
                        }, {
                            a: 2, n: "Name", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                }, s: {
                                    a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                }, fn: "Name"
                        }, {
                            a: 2, n: "Parent", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, g: {
                                    a: 2, n: "get_Parent", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, fg: "Parent"
                                }, s: {
                                    a: 2, n: "set_Parent", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult], rt: System.Void, fs: "Parent"
                                }, fn: "Parent"
                        }, {
                            a: 2, n: "Passed", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_Passed", t: 8, rt: System.Int32, fg: "Passed", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 4, n: "set_Passed", t: 8, p: [System.Int32], rt: System.Void, fs: "Passed"
                                }, fn: "Passed"
                        }, {
                            a: 2, n: "ScenarioCount", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_ScenarioCount", t: 8, rt: System.Int32, fg: "ScenarioCount", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_ScenarioCount", t: 8, p: [System.Int32], rt: System.Void, fs: "ScenarioCount"
                                }, fn: "ScenarioCount"
                        }, {
                            a: 2, n: "SkipReason", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_SkipReason", t: 8, rt: System.String, fg: "SkipReason"
                                }, s: {
                                    a: 2, n: "set_SkipReason", t: 8, p: [System.String], rt: System.Void, fs: "SkipReason"
                                }, fn: "SkipReason"
                        }, {
                            a: 2, n: "Skipped", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_Skipped", t: 8, rt: System.Int32, fg: "Skipped", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_Skipped", t: 8, p: [System.Int32], rt: System.Void, fs: "Skipped"
                                }, fn: "Skipped"
                        }, {
                            a: 2, n: "Status", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, g: {
                                    a: 2, n: "get_Status", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, fg: "Status", box: function($v)
                                        {
                                            return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus))
                                        }
                                }, s: {
                                    a: 2, n: "set_Status", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus], rt: System.Void, fs: "Status"
                                }, fn: "Status"
                        }, {
                            a: 2, n: "Total", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_Total", t: 8, rt: System.Int32, fg: "Total", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_Total", t: 8, p: [System.Int32], rt: System.Void, fs: "Total"
                                }, fn: "Total"
                        }, {
                            a: 1, backing: true, n: "<Asserts>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult), sn: "Asserts"
                        }, {
                            a: 1, backing: true, n: "<Children>k__BackingField", t: 4, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult), sn: "Children"
                        }, {
                            a: 1, backing: true, n: "<Duration>k__BackingField", t: 4, rt: System.Int32, sn: "Duration", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<Exception>k__BackingField", t: 4, rt: System.Exception, sn: "Exception"
                        }, {
                            a: 1, backing: true, n: "<Failed>k__BackingField", t: 4, rt: System.Int32, sn: "Failed", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<FailedIds>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(System.String), sn: "FailedIds"
                        }, {
                            a: 1, backing: true, n: "<FullName>k__BackingField", t: 4, rt: System.String, sn: "FullName"
                        }, {
                            a: 1, backing: true, n: "<Id>k__BackingField", t: 4, rt: System.String, sn: "Id"
                        }, {
                            a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                        }, {
                            a: 1, backing: true, n: "<Parent>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, sn: "Parent"
                        }, {
                            a: 1, backing: true, n: "<Passed>k__BackingField", t: 4, rt: System.Int32, sn: "Passed", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<ScenarioCount>k__BackingField", t: 4, rt: System.Int32, sn: "ScenarioCount", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<SkipReason>k__BackingField", t: 4, rt: System.String, sn: "SkipReason"
                        }, {
                            a: 1, backing: true, n: "<Skipped>k__BackingField", t: 4, rt: System.Int32, sn: "Skipped", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }, {
                            a: 1, backing: true, n: "<Status>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, sn: "Status", box: function($v)
                                {
                                    return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus))
                                }
                        }, {
                            a: 1, backing: true, n: "<Total>k__BackingField", t: 4, rt: System.Int32, sn: "Total", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Asserts: null, Children: null, ScenarioCount: 0, Duration: 0, Total: 0, Passed: 0, Failed: 0, Skipped: 0, Parent: null, Exception: null, Name: null, FullName: null, Id: null, FailedIds: null, Status: 0, SkipReason: null
        }, ctors: {ctor: function()
            {
                this.$initialize();
                
                this.Asserts = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult)).ctor;
                
                this.Children = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult)).ctor;
                
                this.FailedIds = new(System.Collections.Generic.List$1(System.String)).ctor
            }}, methods: {
            AddChildResult: function(result)
            {
                
                result.Parent = this;
                
                this.Children.add(result);
                
                this.Total = (this.Total + result.Total) | 0;
                
                this.Passed = (this.Passed + result.Passed) | 0;
                
                this.Failed = (this.Failed + result.Failed) | 0;
                
                this.Skipped = (this.Skipped + result.Skipped) | 0
            }, AddAssertResult: function(result)
                {
                    
                    result.Id = System.String.format("{0}_assert{1}", this.Id, Bridge.box(System.Array.getCount(this.Asserts, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult), System.Int32));
                    
                    System.Array.add(this.Asserts, result, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult);
                    
                    this.Total = (this.Total + 1) | 0;
                    
                    if (result.Passed)
                    {
                        
                        this.Passed = (this.Passed + 1) | 0
                    }
                    else
                    {
                        
                        this.Failed = (this.Failed + 1) | 0
                    }
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Results.TestStatus", {
    $kind: "enum", $metadata: function()
        {
            return {
                    att: 256, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Failed", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, sn: "Failed", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus))
                                    }
                            }, {
                                a: 2, n: "Passed", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, sn: "Passed", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus))
                                    }
                            }, {
                                a: 2, n: "Pending", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, sn: "Pending", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus))
                                    }
                            }, {
                                a: 2, n: "Skipped", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, sn: "Skipped", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {fields: {
                Pending: 0, Passed: 1, Failed: 2, Skipped: 3
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Services.ITestComponentCreatorService", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceContractAttribute], m: [{
                                ab: true, a: 2, n: "CreateBaseReactComponent", t: 8, pi: [{
                                            n: "inputsType", pt: System.Type, ps: 0
                                        }, {
                                            n: "contextType", pt: System.Type, ps: 1
                                        }, {
                                            n: "controllerType", pt: System.Type, ps: 2
                                        }], tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateBaseReactComponent", rt: System.Object, p: [System.Type, System.Type, System.Type]
                            }, {
                                ab: true, a: 2, n: "CreateBaseReactComponent", t: 8, pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }, {
                                            n: "inputsType", pt: System.Type, ps: 1
                                        }, {
                                            n: "contextType", pt: System.Type, ps: 2
                                        }, {
                                            n: "controllerType", pt: System.Type, ps: 3
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateBaseReactComponent$1", rt: System.Object, p: [System.Type, System.Type, System.Type, System.Type]
                            }, {
                                ab: true, a: 2, n: "CreateBaseViewItemComponent", t: 8, pi: [{
                                            n: "viewItemType", pt: System.Type, ps: 0
                                        }, {
                                            n: "contextType", pt: System.Type, ps: 1
                                        }, {
                                            n: "controllerType", pt: System.Type, ps: 2
                                        }], tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateBaseViewItemComponent", rt: System.Object, p: [System.Type, System.Type, System.Type]
                            }, {
                                ab: true, a: 2, n: "CreateBaseViewItemComponent", t: 8, pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }, {
                                            n: "viewItemType", pt: System.Type, ps: 1
                                        }, {
                                            n: "contextType", pt: System.Type, ps: 2
                                        }, {
                                            n: "controllerType", pt: System.Type, ps: 3
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateBaseViewItemComponent$1", rt: System.Object, p: [System.Type, System.Type, System.Type, System.Type]
                            }, {
                                ab: true, a: 2, n: "CreateModel", t: 8, pi: [{
                                            n: "componentUid", pt: System.String, ps: 0
                                        }], tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateModel", rt: System.Object, p: [System.String]
                            }, {
                                ab: true, a: 2, n: "CreateModel", t: 8, pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }, {
                                            n: "componentUid", pt: System.String, ps: 1
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateModel$1", rt: System.Object, p: [System.Type, System.String]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.Services.ITestFactory", {
    $kind: "interface", $metadata: function()
        {
            return {
                    att: 160, a: 4, m: [{
                                ab: true, a: 2, n: "CreateTest", t: 8, tpc: 1, tprm: ["T"], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestFactory$CreateTest", rt: System.Object
                            }, {
                                ab: true, a: 2, n: "CreateTest", t: 8, pi: [{
                                            n: "t", pt: System.Type, ps: 0
                                        }], sn: "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestFactory$CreateTest$1", rt: System.Object, p: [System.Type]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.SetUpAttribute", {
    inherits: [System.Attribute], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.TearDownAttribute", {
    inherits: [System.Attribute], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework"
});
Bridge.define("EleWise.ELMA.TestFramework.TestAttribute", {
    inherits: [System.Attribute], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "ExpectedCount", t: 16, rt: System.Int32, g: {
                                        a: 2, n: "get_ExpectedCount", t: 8, rt: System.Int32, fg: "ExpectedCount", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        a: 2, n: "set_ExpectedCount", t: 8, p: [System.Int32], rt: System.Void, fs: "ExpectedCount"
                                    }, fn: "ExpectedCount"
                            }, {
                                a: 4, n: "IsExpectedCountSet", t: 16, rt: System.Boolean, g: {
                                        a: 4, n: "get_IsExpectedCountSet", t: 8, rt: System.Boolean, fg: "IsExpectedCountSet", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, fn: "IsExpectedCountSet"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, s: {
                                        a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 1, n: "expectedCount", t: 4, rt: System.Nullable$1(System.Int32), sn: "expectedCount", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32, System.Nullable.toString, System.Nullable.getHashCode)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            expectedCount: null, Name: null
        }, props: {
            ExpectedCount: {
                get: function()
                {
                    
                    return System.Nullable.getValueOrDefault(this.expectedCount, 0)
                }, set: function(value)
                    {
                        
                        this.expectedCount = value
                    }
            }, IsExpectedCountSet: {get: function()
                    {
                        
                        return this.expectedCount != null
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.TestConfig", {
    $metadata: function()
    {
        return {
                att: 1048577, a: 2, m: [{
                            a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                        }, {
                            a: 2, n: "AlterTitle", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_AlterTitle", t: 8, rt: System.Boolean, fg: "AlterTitle", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_AlterTitle", t: 8, p: [System.Boolean], rt: System.Void, fs: "AlterTitle"
                                }, fn: "AlterTitle"
                        }, {
                            a: 2, n: "ScrollTop", t: 16, rt: System.Boolean, g: {
                                    a: 2, n: "get_ScrollTop", t: 8, rt: System.Boolean, fg: "ScrollTop", box: function($v)
                                        {
                                            return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                        }
                                }, s: {
                                    a: 2, n: "set_ScrollTop", t: 8, p: [System.Boolean], rt: System.Void, fs: "ScrollTop"
                                }, fn: "ScrollTop"
                        }, {
                            a: 2, n: "TestAssemblyNamePattern", t: 16, rt: System.String, g: {
                                    a: 2, n: "get_TestAssemblyNamePattern", t: 8, rt: System.String, fg: "TestAssemblyNamePattern"
                                }, s: {
                                    a: 2, n: "set_TestAssemblyNamePattern", t: 8, p: [System.String], rt: System.Void, fs: "TestAssemblyNamePattern"
                                }, fn: "TestAssemblyNamePattern"
                        }, {
                            a: 2, n: "TestTimeout", t: 16, rt: System.Int32, g: {
                                    a: 2, n: "get_TestTimeout", t: 8, rt: System.Int32, fg: "TestTimeout", box: function($v)
                                        {
                                            return Bridge.box($v, System.Int32)
                                        }
                                }, s: {
                                    a: 2, n: "set_TestTimeout", t: 8, p: [System.Int32], rt: System.Void, fs: "TestTimeout"
                                }, fn: "TestTimeout"
                        }, {
                            a: 2, n: "AutoRun", t: 4, rt: System.Boolean, sn: "AutoRun", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 2, n: "HidePassed", t: 4, rt: System.Boolean, sn: "HidePassed", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 2, n: "Reorder", t: 4, rt: System.Boolean, sn: "Reorder", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, n: "__Property__Initializer__AlterTitle", t: 4, rt: System.Boolean, sn: "__Property__Initializer__AlterTitle", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, n: "__Property__Initializer__ScrollTop", t: 4, rt: System.Boolean, sn: "__Property__Initializer__ScrollTop", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, n: "__Property__Initializer__TestAssemblyNamePattern", t: 4, rt: System.String, sn: "__Property__Initializer__TestAssemblyNamePattern"
                        }, {
                            a: 1, backing: true, n: "<AlterTitle>k__BackingField", t: 4, rt: System.Boolean, sn: "AlterTitle", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, backing: true, n: "<ScrollTop>k__BackingField", t: 4, rt: System.Boolean, sn: "ScrollTop", box: function($v)
                                {
                                    return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                }
                        }, {
                            a: 1, backing: true, n: "<TestAssemblyNamePattern>k__BackingField", t: 4, rt: System.String, sn: "TestAssemblyNamePattern"
                        }, {
                            a: 1, backing: true, n: "<TestTimeout>k__BackingField", t: 4, rt: System.Int32, sn: "TestTimeout", box: function($v)
                                {
                                    return Bridge.box($v, System.Int32)
                                }
                        }]
            }
    }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            AutoRun: false, HidePassed: false, TestTimeout: 0, AlterTitle: false, ScrollTop: false, Reorder: false, TestAssemblyNamePattern: null
        }, ctors: {init: function()
            {
                this.AutoRun = false;
                this.HidePassed = false;
                this.AlterTitle = false;
                this.ScrollTop = false;
                this.Reorder = false;
                this.TestAssemblyNamePattern = ".Tests"
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.TestFixtureAttribute", {
    inherits: [System.Attribute], $metadata: function()
        {
            return {
                    att: 1048833, a: 2, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, s: {
                                        a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {Name: null}
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.Test", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IBDDTest], $metadata: function()
        {
            return {
                    att: 1048577, a: 2, at: [Bridge.apply(new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAttribute, {CreateInstancePerResolve: true})], m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Given", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "setup", pt: Function, ps: 1
                                        }], sn: "Given", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                            }, {
                                v: true, a: 2, n: "RunScenario", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                        }], sn: "RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }, {
                                a: 2, n: "Then", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "assertion", pt: Function, ps: 1
                                        }], sn: "Then", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                            }, {
                                a: 2, n: "When", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "action", pt: Function, ps: 1
                                        }], sn: "When", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", alias: ["RunScenario", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$RunScenario", "Given", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$Given", "When", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$When", "Then", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$Then"], methods: {
            RunScenario: function(name, steps)
            {
                if (steps === void 0)
                {
                    steps = []
                }
                
                var bddRunner = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.BDDRunner;
                
                bddRunner.RunScenario(name, steps)
            }, Given: function(name, setup)
                {
                    
                    return new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Step(setup, name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.GIVEN)
                }, When: function(name, action)
                {
                    
                    return new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Step(action, name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.WHEN)
                }, Then: function(name, assertion)
                {
                    
                    return new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Step(assertion, name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.THEN)
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.API.BaseReactComponentTestModel$3", EleWise_ELMA_TestFramework, function(TContext, TController, TInputs)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseReactComponentTestModel$3(TContext, TController, TInputs)], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs], pi: [{
                                                    n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 0
                                                }, {
                                                    n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 1
                                                }, {
                                                    n: "inputs", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 2
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                a: 2, n: "get_Context", t: 8, rt: TContext, fg: "Context"
                                            }, s: {
                                                a: 1, n: "set_Context", t: 8, p: [TContext], rt: System.Void, fs: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                a: 2, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, s: {
                                                a: 1, n: "set_Controller", t: 8, p: [TController], rt: System.Void, fs: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        a: 2, n: "Inputs", t: 16, rt: TInputs, g: {
                                                a: 2, n: "get_Inputs", t: 8, rt: TInputs, fg: "Inputs"
                                            }, s: {
                                                a: 1, n: "set_Inputs", t: 8, p: [TInputs], rt: System.Void, fs: "Inputs"
                                            }, fn: "Inputs"
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "Context"
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "Controller"
                                    }, {
                                        a: 1, backing: true, n: "<Inputs>k__BackingField", t: 4, rt: TInputs, sn: "Inputs"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    Context: Bridge.getDefaultValue(TContext), Controller: Bridge.getDefaultValue(TController), Inputs: Bridge.getDefaultValue(TInputs)
                }, alias: ["Context", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Context", "Controller", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller", "Inputs", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Inputs"], ctors: {ctor: function(context, controller, inputs)
                    {
                        this.$initialize();
                        
                        this.Context = Bridge.cast(Bridge.unbox(context, TContext), TContext);
                        
                        this.Controller = Bridge.cast(Bridge.unbox(controller, TController), TController);
                        
                        this.Inputs = Bridge.cast(Bridge.unbox(inputs, TInputs), TInputs)
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.API.BaseViewItemComponentTestModel$4", EleWise_ELMA_TestFramework, function(TViewItem, TInputs, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseViewItemComponentTestModel$4(TViewItem, TInputs, TContext, TController)], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController], pi: [{
                                                    n: "viewItem", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.Views.IViewItem, ps: 0
                                                }, {
                                                    n: "inputs", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IInputs, ps: 1
                                                }, {
                                                    n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 2
                                                }, {
                                                    n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 3
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                a: 2, n: "get_Context", t: 8, rt: TContext, fg: "Context"
                                            }, s: {
                                                a: 1, n: "set_Context", t: 8, p: [TContext], rt: System.Void, fs: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                a: 2, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, s: {
                                                a: 1, n: "set_Controller", t: 8, p: [TController], rt: System.Void, fs: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        a: 2, n: "Inputs", t: 16, rt: TInputs, g: {
                                                a: 2, n: "get_Inputs", t: 8, rt: TInputs, fg: "Inputs"
                                            }, s: {
                                                a: 1, n: "set_Inputs", t: 8, p: [TInputs], rt: System.Void, fs: "Inputs"
                                            }, fn: "Inputs"
                                    }, {
                                        a: 2, n: "ViewItem", t: 16, rt: TViewItem, g: {
                                                a: 2, n: "get_ViewItem", t: 8, rt: TViewItem, fg: "ViewItem"
                                            }, s: {
                                                a: 1, n: "set_ViewItem", t: 8, p: [TViewItem], rt: System.Void, fs: "ViewItem"
                                            }, fn: "ViewItem"
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "Context"
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "Controller"
                                    }, {
                                        a: 1, backing: true, n: "<Inputs>k__BackingField", t: 4, rt: TInputs, sn: "Inputs"
                                    }, {
                                        a: 1, backing: true, n: "<ViewItem>k__BackingField", t: 4, rt: TViewItem, sn: "ViewItem"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    ViewItem: Bridge.getDefaultValue(TViewItem), Context: Bridge.getDefaultValue(TContext), Controller: Bridge.getDefaultValue(TController), Inputs: Bridge.getDefaultValue(TInputs)
                }, alias: ["ViewItem", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$ViewItem", "Context", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context", "Controller", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller", "Inputs", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Inputs"], ctors: {ctor: function(viewItem, inputs, context, controller)
                    {
                        this.$initialize();
                        
                        this.ViewItem = Bridge.cast(Bridge.unbox(viewItem, TViewItem), TViewItem);
                        
                        this.Inputs = Bridge.cast(Bridge.unbox(inputs, TInputs), TInputs);
                        
                        this.Context = Bridge.cast(Bridge.unbox(context, TContext), TContext);
                        
                        this.Controller = Bridge.cast(Bridge.unbox(controller, TController), TController)
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.API.ComponentTestModel$1", EleWise_ELMA_TestFramework, function(TController)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController], pi: [{
                                                    n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 0
                                                }, {
                                                    n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 1
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Context", t: 16, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, g: {
                                                a: 2, n: "get_Context", t: 8, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, fg: "Context"
                                            }, s: {
                                                a: 1, n: "set_Context", t: 8, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext], rt: System.Void, fs: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                a: 2, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, s: {
                                                a: 1, n: "set_Controller", t: 8, p: [TController], rt: System.Void, fs: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, sn: "Context"
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "Controller"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    Context: null, Controller: Bridge.getDefaultValue(TController)
                }, alias: ["Context", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context", "Controller", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Controller"], ctors: {ctor: function(context, controller)
                    {
                        this.$initialize();
                        
                        this.Context = context;
                        
                        this.Controller = Bridge.cast(Bridge.unbox(controller, TController), TController)
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.API.ComponentTestModel$2", EleWise_ELMA_TestFramework, function(TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)], $metadata: function()
                {
                    return {
                            att: 1048577, a: 2, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController], pi: [{
                                                    n: "context", pt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext, ps: 0
                                                }, {
                                                    n: "controller", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IController, ps: 1
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Context", t: 16, rt: TContext, g: {
                                                a: 2, n: "get_Context", t: 8, rt: TContext, fg: "Context"
                                            }, s: {
                                                a: 1, n: "set_Context", t: 8, p: [TContext], rt: System.Void, fs: "Context"
                                            }, fn: "Context"
                                    }, {
                                        a: 2, n: "Controller", t: 16, rt: TController, g: {
                                                a: 2, n: "get_Controller", t: 8, rt: TController, fg: "Controller"
                                            }, s: {
                                                a: 1, n: "set_Controller", t: 8, p: [TController], rt: System.Void, fs: "Controller"
                                            }, fn: "Controller"
                                    }, {
                                        a: 1, backing: true, n: "<Context>k__BackingField", t: 4, rt: TContext, sn: "Context"
                                    }, {
                                        a: 1, backing: true, n: "<Controller>k__BackingField", t: 4, rt: TController, sn: "Controller"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    Context: Bridge.getDefaultValue(TContext), Controller: Bridge.getDefaultValue(TController)
                }, alias: ["Context", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context", "Controller", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], ctors: {ctor: function(context, controller)
                    {
                        this.$initialize();
                        
                        this.Context = Bridge.cast(Bridge.unbox(context, TContext), TContext);
                        
                        this.Controller = Bridge.cast(Bridge.unbox(controller, TController), TController)
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.BDDRunner", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IBDDRunner], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 1, n: "ConfigureScenario", t: 8, sn: "ConfigureScenario", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioBuilder
                            }, {
                                a: 1, n: "CreateContext", t: 8, sn: "CreateContext", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext
                            }, {
                                a: 2, n: "RunScenario", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                        }], sn: "RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }, {
                                a: 2, n: "RunScenario", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "modelCreator", pt: Function, ps: 1
                                        }, {
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 2
                                        }], tpc: 1, tprm: ["T"], sn: "RunScenario$1", rt: System.Void, p: [System.String, Function, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", alias: ["RunScenario", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDRunner$RunScenario", "RunScenario$1", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDRunner$RunScenario$1"], methods: {
            RunScenario: function(name, steps)
            {
                var $t,
                    $t1;
                if (steps === void 0)
                {
                    steps = []
                }
                
                var scenario = this.ConfigureScenario().EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithName(name).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithSteps(steps).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$Build();
                
                var context = this.CreateContext();
                
                context.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario = scenario;
                
                scenario.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Execute(context);
                ($t = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current).ScenarioCount = ($t.ScenarioCount + 1) | 0;
                
                var result = ($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.ScenarioResult(scenario), $t1.Id = System.String.format("Scenario_{0}", [Bridge.box(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.ScenarioCount, System.Int32)]), $t1);
                
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.SetResult(result);
                
                try
                {
                    
                    scenario.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Execute(context)
                }
                catch(ex)
                {
                    ex = System.Exception.create(ex);
                    
                    var exception = new System.Exception(SR.T("\u0412 \u043f\u0440\u043e\u0446\u0435\u0441\u0441\u0435 \u0432\u044b\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044f \u0441\u0446\u0435\u043d\u0430\u0440\u0438\u044f \u0432\u043e\u0437\u043d\u0438\u043a\u043b\u0430 \u043e\u0448\u0438\u0431\u043a\u0430"), ex);
                    
                    result.Failed = 1;
                    
                    result.Exception = exception;
                    
                    throw exception;
                }
                finally
                {
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.PopResult()
                }
            }, RunScenario$1: function(T, name, modelCreator, steps)
                {
                    var $t,
                        $t1;
                    if (steps === void 0)
                    {
                        steps = []
                    }
                    
                    var scenario = this.ConfigureScenario().EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithName(name).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithSteps(steps).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$Build();
                    
                    var context = this.CreateContext();
                    
                    context.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario = scenario;
                    ($t = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current).ScenarioCount = ($t.ScenarioCount + 1) | 0;
                    
                    var result = ($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.ScenarioResult(scenario), $t1.Id = System.String.format("Scenario_{0}", [Bridge.box(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.ScenarioCount, System.Int32)]), $t1);
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.SetResult(result);
                    
                    try
                    {
                        
                        context.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model = modelCreator();
                        
                        scenario.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Execute(context)
                    }
                    catch(ex)
                    {
                        ex = System.Exception.create(ex);
                        
                        var exception = new System.Exception(SR.T("\u0412 \u043f\u0440\u043e\u0446\u0435\u0441\u0441\u0435 \u0432\u044b\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u044f \u0441\u0446\u0435\u043d\u0430\u0440\u0438\u044f \u0432\u043e\u0437\u043d\u0438\u043a\u043b\u0430 \u043e\u0448\u0438\u0431\u043a\u0430"), ex);
                        
                        result.Failed = 1;
                        
                        result.Exception = exception;
                        
                        throw exception;
                    }
                    finally
                    {
                        
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.PopResult()
                    }
                }, ConfigureScenario: function()
                {
                    
                    return new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioBuilder
                }, CreateContext: function()
                {
                    
                    var context = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext;
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext.Current = context;
                    
                    return context
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.Scenario", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)], pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "steps", pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Execute", t: 8, pi: [{
                                            n: "context", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext, ps: 0
                                        }], sn: "Execute", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext]
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 1, n: "steps", t: 4, rt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), sn: "steps", ro: true
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            steps: null, Name: null
        }, alias: ["Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Name", "Execute", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Execute"], ctors: {ctor: function(name, steps)
            {
                this.$initialize();
                
                this.Name = name;
                
                this.steps = steps
            }}, methods: {Execute: function(context)
            {
                var $t;
                
                var notifier = Bridge.as(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.Notifier, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IScenarioProgressNotifier);
                
                notifier != null ? notifier.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$ScenarioStarted(($t = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ScenarioInfo, $t.Name = this.Name, $t)) : null;
                
                var total = this.steps.length;
                
                for (var i = 0; i < total; i = (i + 1) | 0)
                {
                    
                    var step = {v: this.steps[System.Array.index(i, this.steps)]};
                    
                    context.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentStep = step.v;
                    
                    var executableStep;
                    
                    if (((executableStep = Bridge.as(step.v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IExecutableStep))) != null)
                    {
                        
                        var result = {v: ($t = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.StepResult(step.v), $t.Id = System.String.format("{0}_{1}", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.CurrentResult.Id, Bridge.box(i, System.Int32)), $t)};
                        
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.SetResult(result.v);
                        
                        notifier != null ? notifier.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$StepStarted(($t = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.StepInfo, $t.Name = step.v.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name, $t.Type = step.v.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type, $t.Number = ((i + 1) | 0), $t.Total = total, $t)) : null;
                        
                        try
                        {
                            
                            executableStep.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IExecutableStep$Execute(context)
                        }
                        catch(ex)
                        {
                            ex = System.Exception.create(ex);
                            
                            var exception = new System.Exception(SR.T("\u0412\u044b\u043f\u043e\u043b\u043d\u0435\u043d\u0438\u0435 \u0448\u0430\u0433\u0430 \u0437\u0430\u0432\u0435\u0440\u0448\u0438\u043b\u043e\u0441\u044c \u0441 \u043e\u0448\u0438\u0431\u043a\u043e\u0439"), ex);
                            
                            result.v.Failed = 1;
                            
                            result.v.Exception = exception;
                            
                            throw exception;
                        }
                        finally
                        {
                            
                            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.PopResult();
                            
                            notifier != null ? notifier.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$StepFinished(result.v) : null
                        }
                    }
                    else
                    {
                        
                        throw new System.Exception(SR.T("\u041d\u0435\u0432\u043e\u0437\u043c\u043e\u0436\u043d\u043e \u0432\u044b\u043f\u043e\u043b\u043d\u0438\u0442\u044c \u0448\u0430\u0433 \u0441\u0446\u0435\u043d\u0430\u0440\u0438\u044f: \u0448\u0430\u0433 {0} \u043d\u0435 \u044f\u0432\u043b\u044f\u0435\u0442\u0441\u044f {1}", step.v.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IExecutableStep));
                    }
                }
                
                notifier != null ? notifier.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioProgressNotifier$ScenarioFinished(new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.ScenarioResult(this)) : null
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.ScenarioBuilder", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioBuilder], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Build", t: 8, sn: "Build", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario
                            }, {
                                a: 2, n: "WithName", t: 8, pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }], sn: "WithName", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioBuilder, p: [System.String]
                            }, {
                                a: 2, n: "WithSteps", t: 8, pi: [{
                                            n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 0
                                        }], sn: "WithSteps", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioBuilder, p: [System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                            }, {
                                a: 1, n: "name", t: 4, rt: System.String, sn: "name"
                            }, {
                                a: 1, n: "steps", t: 4, rt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), sn: "steps"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            name: null, steps: null
        }, alias: ["WithName", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithName", "WithSteps", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$WithSteps", "Build", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioBuilder$Build"], methods: {
            WithName: function(name)
            {
                
                this.name = name;
                
                return this
            }, WithSteps: function(steps)
                {
                    if (steps === void 0)
                    {
                        steps = []
                    }
                    
                    this.steps = steps;
                    
                    return this
                }, Build: function()
                {
                    
                    var scenario = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Scenario(this.name, this.steps);
                    
                    return scenario
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Current", is: true, t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext, g: {
                                        a: 2, n: "get_Current", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext, fg: "Current", is: true
                                    }, s: {
                                        a: 2, n: "set_Current", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext], rt: System.Void, fs: "Current", is: true
                                    }, fn: "Current"
                            }, {
                                a: 2, n: "CurrentScenario", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, g: {
                                        a: 2, n: "get_CurrentScenario", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, fg: "CurrentScenario"
                                    }, s: {
                                        a: 2, n: "set_CurrentScenario", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario], rt: System.Void, fs: "CurrentScenario"
                                    }, fn: "CurrentScenario"
                            }, {
                                a: 2, n: "CurrentStep", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, g: {
                                        a: 2, n: "get_CurrentStep", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, fg: "CurrentStep"
                                    }, s: {
                                        a: 2, n: "set_CurrentStep", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep], rt: System.Void, fs: "CurrentStep"
                                    }, fn: "CurrentStep"
                            }, {
                                a: 2, n: "Model", t: 16, rt: System.Object, g: {
                                        a: 2, n: "get_Model", t: 8, rt: System.Object, fg: "Model"
                                    }, s: {
                                        a: 2, n: "set_Model", t: 8, p: [System.Object], rt: System.Void, fs: "Model"
                                    }, fn: "Model"
                            }, {
                                a: 2, n: "TestContext", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, g: {
                                        a: 2, n: "get_TestContext", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, fg: "TestContext"
                                    }, s: {
                                        a: 2, n: "set_TestContext", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext], rt: System.Void, fs: "TestContext"
                                    }, fn: "TestContext"
                            }, {
                                a: 1, backing: true, n: "<Current>k__BackingField", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.ScenarioExecutionContext, sn: "Current"
                            }, {
                                a: 1, backing: true, n: "<CurrentScenario>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, sn: "CurrentScenario"
                            }, {
                                a: 1, backing: true, n: "<CurrentStep>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, sn: "CurrentStep"
                            }, {
                                a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: System.Object, sn: "Model"
                            }, {
                                a: 1, backing: true, n: "<TestContext>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, sn: "TestContext"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {fields: {Current: null}}, fields: {
            TestContext: null, CurrentScenario: null, CurrentStep: null, Model: null
        }, alias: ["TestContext", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$TestContext", "CurrentScenario", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentScenario", "CurrentStep", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$CurrentStep", "Model", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model"]
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.Step", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IExecutableStep], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [Function, System.String, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType], pi: [{
                                            n: "action", pt: Function, ps: 0
                                        }, {
                                            n: "name", pt: System.String, ps: 1
                                        }, {
                                            n: "stepType", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, ps: 2
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Execute", t: 8, pi: [{
                                            n: "context", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext, ps: 0
                                        }], sn: "Execute", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext]
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 2, n: "Type", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, g: {
                                        a: 2, n: "get_Type", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, fg: "Type", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                            }
                                    }, fn: "Type"
                            }, {
                                a: 1, n: "action", t: 4, rt: Function, sn: "action", ro: true
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "Type", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            action: null, Name: null, Type: 0
        }, alias: ["Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name", "Type", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type", "Execute", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IExecutableStep$Execute"], ctors: {ctor: function(action, name, stepType)
            {
                this.$initialize();
                
                this.action = action;
                
                this.Name = name;
                
                this.Type = stepType
            }}, methods: {Execute: function(context)
            {
                
                this.action()
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1", EleWise_ELMA_TestFramework, function(T)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IExecutableStep], $metadata: function()
                {
                    return {
                            att: 1048576, a: 4, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [Function, System.String, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType], pi: [{
                                                    n: "action", pt: Function, ps: 0
                                                }, {
                                                    n: "name", pt: System.String, ps: 1
                                                }, {
                                                    n: "stepType", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, ps: 2
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Execute", t: 8, pi: [{
                                                    n: "context", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext, ps: 0
                                                }], sn: "Execute", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenarioExecutionContext]
                                    }, {
                                        a: 2, n: "Name", t: 16, rt: System.String, g: {
                                                a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                            }, fn: "Name"
                                    }, {
                                        a: 2, n: "Type", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, g: {
                                                a: 2, n: "get_Type", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, fg: "Type", box: function($v)
                                                    {
                                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                                    }
                                            }, fn: "Type"
                                    }, {
                                        a: 1, n: "action", t: 4, rt: Function, sn: "action", ro: true
                                    }, {
                                        a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                                    }, {
                                        a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "Type", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                            }
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    action: null, Name: null, Type: 0
                }, alias: ["Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name", "Type", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type", "Execute", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IExecutableStep$Execute"], ctors: {ctor: function(action, name, stepType)
                    {
                        this.$initialize();
                        
                        this.action = action;
                        
                        this.Name = name;
                        
                        this.Type = stepType
                    }}, methods: {Execute: function(context)
                    {
                        
                        this.action(Bridge.cast(Bridge.unbox(context.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenarioExecutionContext$Model, T), T))
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Core.TestAssembly", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.Reflection.Assembly], pi: [{
                                            n: "assembly", pt: System.Reflection.Assembly, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Assembly", t: 16, rt: System.Reflection.Assembly, g: {
                                        a: 2, n: "get_Assembly", t: 8, rt: System.Reflection.Assembly, fg: "Assembly"
                                    }, fn: "Assembly"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 2, n: "TestFixtures", t: 16, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), g: {
                                        a: 2, n: "get_TestFixtures", t: 8, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), fg: "TestFixtures"
                                    }, s: {
                                        a: 2, n: "set_TestFixtures", t: 8, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture)], rt: System.Void, fs: "TestFixtures"
                                    }, fn: "TestFixtures"
                            }, {
                                a: 1, backing: true, n: "<Assembly>k__BackingField", t: 4, rt: System.Reflection.Assembly, sn: "Assembly"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }, {
                                a: 1, backing: true, n: "<TestFixtures>k__BackingField", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), sn: "TestFixtures"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Assembly: null, Name: null, TestFixtures: null
        }, alias: ["Assembly", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Assembly", "Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$Name", "TestFixtures", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$TestFixtures"], ctors: {ctor: function(assembly)
            {
                this.$initialize();
                
                this.Assembly = assembly;
                
                this.Name = assembly.name;
                
                this.TestFixtures = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture)).ctor
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Core.TestAssemblyBuilder", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssemblyBuilder], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Build", t: 8, pi: [{
                                            n: "assembly", pt: System.Reflection.Assembly, ps: 0
                                        }], sn: "Build", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly, p: [System.Reflection.Assembly]
                            }, {
                                a: 2, n: "Build", t: 8, pi: [{
                                            n: "assemblies", pt: System.Array.type(System.Reflection.Assembly), ps: 0
                                        }], sn: "Build$1", rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly), p: [System.Array.type(System.Reflection.Assembly)]
                            }, {
                                a: 1, n: "Build", t: 8, pi: [{
                                            n: "types", pt: System.Array.type(System.Type), ps: 0
                                        }], sn: "Build$2", rt: System.Collections.Generic.IList$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), p: [System.Array.type(System.Type)]
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", alias: ["Build$1", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssemblyBuilder$Build$1", "Build", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssemblyBuilder$Build"], methods: {
            Build$1: function(assemblies)
            {
                var $t;
                
                EleWise_ELMA_Core.EleWise.ELMA.Core.Diagnostics.Contract.ArgumentNotNull(assemblies, "assemblies");
                
                var testAssemblies = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly)).ctor;
                
                $t = Bridge.getEnumerator(assemblies);
                try
                {
                    while ($t.moveNext())
                    {
                        var assembly = $t.Current;
                        
                        var componentAssemblyAttribute = EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAssemblyAttribute).GetAttribute(assembly);
                        
                        if (componentAssemblyAttribute == null)
                        {
                            
                            continue
                        }
                        
                        if (System.String.endsWith(assembly.name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestController.FrameworkConfig.TestAssemblyNamePattern))
                        {
                            
                            var testAssembly = this.Build(assembly);
                            
                            testAssemblies.add(testAssembly)
                        }
                    }
                }
                finally
                {
                    if (Bridge.is($t, System.IDisposable))
                    {
                        $t.System$IDisposable$Dispose()
                    }
                }
                
                return testAssemblies
            }, Build: function(assembly)
                {
                    
                    EleWise_ELMA_Core.EleWise.ELMA.Core.Diagnostics.Contract.ArgumentNotNull(assembly, "assembly");
                    
                    var testAssembly = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestAssembly(assembly);
                    
                    var types = Bridge.Reflection.getAssemblyTypes(assembly);
                    
                    testAssembly.TestFixtures = this.Build$2(types);
                    
                    return testAssembly
                }, Build$2: function(types)
                {
                    var $t;
                    
                    var fixtures = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture)).ctor;
                    
                    $t = Bridge.getEnumerator(types);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var type = $t.Current;
                            
                            var attr = EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestFixtureAttribute).GetAttribute$2(type, false);
                            
                            if (attr != null)
                            {
                                
                                var fixture = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestFixture.$ctor1(type, attr.Name);
                                
                                fixtures.add(fixture)
                            }
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    return fixtures
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Core.TestContext", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestContext], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "PopResult", t: 8, sn: "PopResult", rt: System.Void
                            }, {
                                a: 2, n: "SetResult", t: 8, pi: [{
                                            n: "value", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, ps: 0
                                        }], sn: "SetResult", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult]
                            }, {
                                a: 2, n: "Assert", t: 16, rt: Function, g: {
                                        a: 2, n: "get_Assert", t: 8, rt: Function, fg: "Assert"
                                    }, s: {
                                        a: 2, n: "set_Assert", t: 8, p: [Function], rt: System.Void, fs: "Assert"
                                    }, fn: "Assert"
                            }, {
                                a: 2, n: "AssertCounter", t: 16, rt: System.Int32, g: {
                                        a: 2, n: "get_AssertCounter", t: 8, rt: System.Int32, fg: "AssertCounter", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        a: 2, n: "set_AssertCounter", t: 8, p: [System.Int32], rt: System.Void, fs: "AssertCounter"
                                    }, fn: "AssertCounter"
                            }, {
                                a: 2, n: "Current", is: true, t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, g: {
                                        a: 2, n: "get_Current", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, fg: "Current", is: true
                                    }, s: {
                                        a: 2, n: "set_Current", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext], rt: System.Void, fs: "Current", is: true
                                    }, fn: "Current"
                            }, {
                                a: 2, n: "CurrentResult", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, g: {
                                        a: 2, n: "get_CurrentResult", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, fg: "CurrentResult"
                                    }, s: {
                                        a: 1, n: "set_CurrentResult", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult], rt: System.Void, fs: "CurrentResult"
                                    }, fn: "CurrentResult"
                            }, {
                                a: 2, n: "CurrentTest", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, g: {
                                        a: 2, n: "get_CurrentTest", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, fg: "CurrentTest"
                                    }, s: {
                                        a: 2, n: "set_CurrentTest", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod], rt: System.Void, fs: "CurrentTest"
                                    }, fn: "CurrentTest"
                            }, {
                                a: 2, n: "CurrentTestFixture", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, g: {
                                        a: 2, n: "get_CurrentTestFixture", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, fg: "CurrentTestFixture"
                                    }, s: {
                                        a: 2, n: "set_CurrentTestFixture", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture], rt: System.Void, fs: "CurrentTestFixture"
                                    }, fn: "CurrentTestFixture"
                            }, {
                                a: 2, n: "Notifier", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, g: {
                                        a: 2, n: "get_Notifier", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, fg: "Notifier"
                                    }, s: {
                                        a: 2, n: "set_Notifier", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier], rt: System.Void, fs: "Notifier"
                                    }, fn: "Notifier"
                            }, {
                                a: 2, n: "ScenarioCount", t: 16, rt: System.Int32, g: {
                                        a: 2, n: "get_ScenarioCount", t: 8, rt: System.Int32, fg: "ScenarioCount", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        a: 2, n: "set_ScenarioCount", t: 8, p: [System.Int32], rt: System.Void, fs: "ScenarioCount"
                                    }, fn: "ScenarioCount"
                            }, {
                                a: 2, n: "TestFactory", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, g: {
                                        a: 2, n: "get_TestFactory", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, fg: "TestFactory"
                                    }, s: {
                                        a: 2, n: "set_TestFactory", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory], rt: System.Void, fs: "TestFactory"
                                    }, fn: "TestFactory"
                            }, {
                                a: 1, backing: true, n: "<Assert>k__BackingField", t: 4, rt: Function, sn: "Assert"
                            }, {
                                a: 1, backing: true, n: "<AssertCounter>k__BackingField", t: 4, rt: System.Int32, sn: "AssertCounter", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Current>k__BackingField", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, sn: "Current"
                            }, {
                                a: 1, backing: true, n: "<CurrentResult>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, sn: "CurrentResult"
                            }, {
                                a: 1, backing: true, n: "<CurrentTest>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, sn: "CurrentTest"
                            }, {
                                a: 1, backing: true, n: "<CurrentTestFixture>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, sn: "CurrentTestFixture"
                            }, {
                                a: 1, backing: true, n: "<Notifier>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, sn: "Notifier"
                            }, {
                                a: 1, backing: true, n: "<ScenarioCount>k__BackingField", t: 4, rt: System.Int32, sn: "ScenarioCount", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<TestFactory>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, sn: "TestFactory"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {fields: {Current: null}}, fields: {
            Assert: null, Notifier: null, TestFactory: null, CurrentResult: null, CurrentTest: null, CurrentTestFixture: null, AssertCounter: 0, ScenarioCount: 0
        }, alias: ["Assert", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Assert", "Notifier", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$Notifier", "TestFactory", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$TestFactory", "CurrentResult", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentResult", "CurrentTest", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTest", "CurrentTestFixture", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$CurrentTestFixture", "ScenarioCount", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$ScenarioCount", "SetResult", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$SetResult", "PopResult", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestContext$PopResult"], methods: {
            SetResult: function(value)
            {
                
                if (this.CurrentResult != null)
                {
                    
                    value.Parent = this.CurrentResult
                }
                
                this.CurrentResult = value
            }, PopResult: function()
                {
                    
                    var current = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.CurrentResult;
                    
                    var parent = current.Parent;
                    
                    if (parent != null)
                    {
                        
                        parent.AddChildResult(current);
                        
                        if (current.Failed > 0)
                        {
                            
                            System.Array.add(parent.FailedIds, current.Id, System.String);
                            
                            EleWise_ELMA_Core.System.Collections.Generic.ICollectionExtensions.AddRange(System.String, parent.FailedIds, current.FailedIds)
                        }
                    }
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.CurrentResult = parent
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Core.TestFixture", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.Type], pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: ".ctor", t: 1, p: [System.Type, System.String], pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }, {
                                            n: "name", pt: System.String, ps: 1
                                        }], sn: "$ctor1"
                            }, {
                                a: 1, n: "Initialize", t: 8, sn: "Initialize", rt: System.Void
                            }, {
                                a: 2, n: "Instance", t: 16, rt: System.Object, g: {
                                        a: 2, n: "get_Instance", t: 8, rt: System.Object, fg: "Instance"
                                    }, s: {
                                        a: 2, n: "set_Instance", t: 8, p: [System.Object], rt: System.Void, fs: "Instance"
                                    }, fn: "Instance"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 2, n: "OneTimeSetUp", t: 16, rt: Function, g: {
                                        a: 2, n: "get_OneTimeSetUp", t: 8, rt: Function, fg: "OneTimeSetUp"
                                    }, s: {
                                        a: 2, n: "set_OneTimeSetUp", t: 8, p: [Function], rt: System.Void, fs: "OneTimeSetUp"
                                    }, fn: "OneTimeSetUp"
                            }, {
                                a: 2, n: "Result", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, g: {
                                        a: 2, n: "get_Result", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, fg: "Result"
                                    }, s: {
                                        a: 2, n: "set_Result", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult], rt: System.Void, fs: "Result"
                                    }, fn: "Result"
                            }, {
                                a: 2, n: "SetUp", t: 16, rt: System.Reflection.MethodInfo, g: {
                                        a: 2, n: "get_SetUp", t: 8, rt: System.Reflection.MethodInfo, fg: "SetUp"
                                    }, s: {
                                        a: 2, n: "set_SetUp", t: 8, p: [System.Reflection.MethodInfo], rt: System.Void, fs: "SetUp"
                                    }, fn: "SetUp"
                            }, {
                                a: 2, n: "Skip", t: 16, rt: System.Boolean, g: {
                                        a: 2, n: "get_Skip", t: 8, rt: System.Boolean, fg: "Skip", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, s: {
                                        a: 1, n: "set_Skip", t: 8, p: [System.Boolean], rt: System.Void, fs: "Skip"
                                    }, fn: "Skip"
                            }, {
                                a: 2, n: "SkipReason", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_SkipReason", t: 8, rt: System.String, fg: "SkipReason"
                                    }, s: {
                                        a: 1, n: "set_SkipReason", t: 8, p: [System.String], rt: System.Void, fs: "SkipReason"
                                    }, fn: "SkipReason"
                            }, {
                                a: 2, n: "TearDown", t: 16, rt: System.Reflection.MethodInfo, g: {
                                        a: 2, n: "get_TearDown", t: 8, rt: System.Reflection.MethodInfo, fg: "TearDown"
                                    }, s: {
                                        a: 2, n: "set_TearDown", t: 8, p: [System.Reflection.MethodInfo], rt: System.Void, fs: "TearDown"
                                    }, fn: "TearDown"
                            }, {
                                a: 2, n: "Tests", t: 16, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod), g: {
                                        a: 2, n: "get_Tests", t: 8, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod), fg: "Tests"
                                    }, s: {
                                        a: 1, n: "set_Tests", t: 8, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod)], rt: System.Void, fs: "Tests"
                                    }, fn: "Tests"
                            }, {
                                a: 2, n: "Type", t: 16, rt: System.Type, g: {
                                        a: 2, n: "get_Type", t: 8, rt: System.Type, fg: "Type"
                                    }, fn: "Type"
                            }, {
                                a: 1, backing: true, n: "<Instance>k__BackingField", t: 4, rt: System.Object, sn: "Instance"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }, {
                                a: 1, backing: true, n: "<OneTimeSetUp>k__BackingField", t: 4, rt: Function, sn: "OneTimeSetUp"
                            }, {
                                a: 1, backing: true, n: "<Result>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult, sn: "Result"
                            }, {
                                a: 1, backing: true, n: "<SetUp>k__BackingField", t: 4, rt: System.Reflection.MethodInfo, sn: "SetUp"
                            }, {
                                a: 1, backing: true, n: "<Skip>k__BackingField", t: 4, rt: System.Boolean, sn: "Skip", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, backing: true, n: "<SkipReason>k__BackingField", t: 4, rt: System.String, sn: "SkipReason"
                            }, {
                                a: 1, backing: true, n: "<TearDown>k__BackingField", t: 4, rt: System.Reflection.MethodInfo, sn: "TearDown"
                            }, {
                                a: 1, backing: true, n: "<Tests>k__BackingField", t: 4, rt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod), sn: "Tests"
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: System.Type, sn: "Type"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Type: null, Name: null, Tests: null, Instance: null, SetUp: null, TearDown: null, OneTimeSetUp: null, Result: null, Skip: false, SkipReason: null
        }, alias: ["Type", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Type", "Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name", "Tests", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Tests", "Instance", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance", "SetUp", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SetUp", "TearDown", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$TearDown", "OneTimeSetUp", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$OneTimeSetUp", "Result", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Result", "Skip", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip", "SkipReason", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SkipReason"], ctors: {
            ctor: function(type)
            {
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestFixture.$ctor1.call(this, type, Bridge.Reflection.getTypeName(type))
            }, $ctor1: function(type, name)
                {
                    var $t;
                    this.$initialize();
                    
                    this.Type = type;
                    
                    this.Name = ($t = name, $t != null ? $t : Bridge.Reflection.getTypeName(type));
                    
                    this.Initialize()
                }
        }, methods: {Initialize: function()
            {
                var $t;
                
                var ignoreAttribute = EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.IgnoreAttribute).GetAttribute$2(this.Type, false);
                
                if (ignoreAttribute != null)
                {
                    
                    this.Skip = true;
                    
                    this.SkipReason = ignoreAttribute.Reason
                }
                
                var testMethods = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod)).ctor;
                
                var methods = Bridge.Reflection.getMembers(this.Type, 8, 22);
                
                $t = Bridge.getEnumerator(methods);
                try
                {
                    while ($t.moveNext())
                    {
                        var method = $t.Current;
                        
                        if (EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.SetUpAttribute).GetAttribute$1(method, false) != null)
                        {
                            
                            this.SetUp = method
                        }
                        
                        if (EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TearDownAttribute).GetAttribute$1(method, false) != null)
                        {
                            
                            this.TearDown = method
                        }
                        
                        var testAttribute = EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestAttribute).GetAttribute$1(method, false);
                        
                        if (testAttribute != null)
                        {
                            
                            var test = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestMethod.$ctor2(this, method, testAttribute.Name, testAttribute.IsExpectedCountSet ? Bridge.cast(testAttribute.ExpectedCount, System.Int32, true) : null);
                            
                            var testIgnoreAttribute = EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.AttributeHelper$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.IgnoreAttribute).GetAttribute$1(method, false);
                            
                            if (testIgnoreAttribute != null)
                            {
                                
                                test.Skip = true;
                                
                                test.SkipReason = testIgnoreAttribute.Reason
                            }
                            
                            testMethods.add(test)
                        }
                    }
                }
                finally
                {
                    if (Bridge.is($t, System.IDisposable))
                    {
                        $t.System$IDisposable$Dispose()
                    }
                }
                
                this.Tests = testMethods
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Core.TestMethod", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, System.Reflection.MethodInfo], pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }, {
                                            n: "method", pt: System.Reflection.MethodInfo, ps: 1
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, System.Reflection.MethodInfo, System.String], pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }, {
                                            n: "method", pt: System.Reflection.MethodInfo, ps: 1
                                        }, {
                                            n: "name", pt: System.String, ps: 2
                                        }], sn: "$ctor1"
                            }, {
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, System.Reflection.MethodInfo, System.String, System.Nullable$1(System.Int32)], pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }, {
                                            n: "method", pt: System.Reflection.MethodInfo, ps: 1
                                        }, {
                                            n: "name", pt: System.String, ps: 2
                                        }, {
                                            n: "expectedCount", pt: System.Nullable$1(System.Int32), ps: 3
                                        }], sn: "$ctor2"
                            }, {
                                a: 2, n: "ExpectedCount", t: 16, rt: System.Nullable$1(System.Int32), g: {
                                        a: 2, n: "get_ExpectedCount", t: 8, rt: System.Nullable$1(System.Int32), fg: "ExpectedCount", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32, System.Nullable.toString, System.Nullable.getHashCode)
                                            }
                                    }, s: {
                                        a: 2, n: "set_ExpectedCount", t: 8, p: [System.Nullable$1(System.Int32)], rt: System.Void, fs: "ExpectedCount"
                                    }, fn: "ExpectedCount"
                            }, {
                                a: 2, n: "Fixture", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, g: {
                                        a: 2, n: "get_Fixture", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, fg: "Fixture"
                                    }, s: {
                                        a: 1, n: "set_Fixture", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture], rt: System.Void, fs: "Fixture"
                                    }, fn: "Fixture"
                            }, {
                                a: 2, n: "FullName", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_FullName", t: 8, rt: System.String, fg: "FullName"
                                    }, s: {
                                        a: 2, n: "set_FullName", t: 8, p: [System.String], rt: System.Void, fs: "FullName"
                                    }, fn: "FullName"
                            }, {
                                a: 2, n: "Method", t: 16, rt: System.Reflection.MethodInfo, g: {
                                        a: 2, n: "get_Method", t: 8, rt: System.Reflection.MethodInfo, fg: "Method"
                                    }, fn: "Method"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, s: {
                                        a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 2, n: "Skip", t: 16, rt: System.Boolean, g: {
                                        a: 2, n: "get_Skip", t: 8, rt: System.Boolean, fg: "Skip", box: function($v)
                                            {
                                                return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                            }
                                    }, s: {
                                        a: 2, n: "set_Skip", t: 8, p: [System.Boolean], rt: System.Void, fs: "Skip"
                                    }, fn: "Skip"
                            }, {
                                a: 2, n: "SkipReason", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_SkipReason", t: 8, rt: System.String, fg: "SkipReason"
                                    }, s: {
                                        a: 2, n: "set_SkipReason", t: 8, p: [System.String], rt: System.Void, fs: "SkipReason"
                                    }, fn: "SkipReason"
                            }, {
                                a: 1, backing: true, n: "<ExpectedCount>k__BackingField", t: 4, rt: System.Nullable$1(System.Int32), sn: "ExpectedCount", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32, System.Nullable.toString, System.Nullable.getHashCode)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Fixture>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, sn: "Fixture"
                            }, {
                                a: 1, backing: true, n: "<FullName>k__BackingField", t: 4, rt: System.String, sn: "FullName"
                            }, {
                                a: 1, backing: true, n: "<Method>k__BackingField", t: 4, rt: System.Reflection.MethodInfo, sn: "Method"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }, {
                                a: 1, backing: true, n: "<Skip>k__BackingField", t: 4, rt: System.Boolean, sn: "Skip", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, backing: true, n: "<SkipReason>k__BackingField", t: 4, rt: System.String, sn: "SkipReason"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Method: null, Name: null, FullName: null, ExpectedCount: null, Fixture: null, Skip: false, SkipReason: null
        }, alias: ["Method", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Method", "Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name", "FullName", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$FullName", "ExpectedCount", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount", "Fixture", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Fixture", "Skip", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Skip", "SkipReason", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$SkipReason"], ctors: {
            ctor: function(testFixture, method)
            {
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestMethod.$ctor1.call(this, testFixture, method, method.n)
            }, $ctor1: function(testFixture, method, name)
                {
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestMethod.$ctor2.call(this, testFixture, method, method.n, null)
                }, $ctor2: function(testFixture, method, name, expectedCount)
                {
                    var $t;
                    this.$initialize();
                    
                    this.Fixture = testFixture;
                    
                    this.Name = ($t = name, $t != null ? $t : method.n);
                    
                    this.Method = method;
                    
                    this.FullName = method.sn;
                    
                    if (System.Nullable.hasValue(expectedCount))
                    {
                        
                        this.ExpectedCount = System.Nullable.getValue(expectedCount)
                    }
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Core.TestRunner", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestRunner], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceAttribute], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory], pi: [{
                                            n: "testFactory", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 1, n: "CreateHooks", t: 8, pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }, {
                                            n: "setup", pt: Function, ps: 1
                                        }], sn: "CreateHooks", rt: System.Object, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, Function]
                            }, {
                                a: 1, n: "InitializeTestExecutionContext", t: 8, sn: "InitializeTestExecutionContext", rt: System.Void
                            }, {
                                a: 1, n: "RegisterQUnitEventHandlers", t: 8, sn: "RegisterQUnitEventHandlers", rt: System.Void
                            }, {
                                a: 2, n: "Run", t: 8, pi: [{
                                            n: "testAssembly", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly, ps: 0
                                        }], sn: "Run", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly]
                            }, {
                                a: 2, n: "Run", t: 8, pi: [{
                                            n: "test", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, ps: 0
                                        }], sn: "Run$2", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod]
                            }, {
                                a: 2, n: "Run", t: 8, pi: [{
                                            n: "testAssemblies", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly), ps: 0
                                        }], sn: "Run$3", rt: System.Void, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly)]
                            }, {
                                a: 2, n: "Run", t: 8, pi: [{
                                            n: "testFixtures", pt: System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture), ps: 0
                                        }], sn: "Run$4", rt: System.Void, p: [System.Collections.Generic.IEnumerable$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture)]
                            }, {
                                a: 2, n: "Run", t: 8, pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }, {
                                            n: "testNotifier", dv: null, o: true, pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, ps: 1
                                        }, {
                                            n: "setup", dv: null, o: true, pt: Function, ps: 2
                                        }], sn: "Run$1", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, Function]
                            }, {
                                a: 1, n: "SetTestFixture", t: 8, pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }], sn: "SetTestFixture", rt: System.Void, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture]
                            }, {
                                a: 1, n: "StartQUnit", t: 8, sn: "StartQUnit", rt: System.Void
                            }, {
                                a: 1, n: "context", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext, sn: "context"
                            }, {
                                a: 1, n: "hasStarted", t: 4, rt: System.Boolean, sn: "hasStarted", box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 1, n: "testFactory", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, sn: "testFactory", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            testFactory: null, hasStarted: false, context: null
        }, alias: ["Run$3", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$3", "Run", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run", "Run$4", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$4", "Run$1", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$1", "Run$2", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$2"], ctors: {ctor: function(testFactory)
            {
                this.$initialize();
                
                this.testFactory = testFactory
            }}, methods: {
            Run$3: function(testAssemblies)
            {
                var $t;
                
                $t = Bridge.getEnumerator(testAssemblies, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssembly);
                try
                {
                    while ($t.moveNext())
                    {
                        var testAssemblie = $t.Current;
                        
                        this.Run(testAssemblie)
                    }
                }
                finally
                {
                    if (Bridge.is($t, System.IDisposable))
                    {
                        $t.System$IDisposable$Dispose()
                    }
                }
            }, Run: function(testAssembly)
                {
                    
                    this.Run$4(testAssembly.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssembly$TestFixtures)
                }, Run$4: function(testFixtures)
                {
                    var $t;
                    
                    $t = Bridge.getEnumerator(testFixtures, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var testSuite = $t.Current;
                            
                            this.Run$1(testSuite)
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                }, Run$1: function(testFixture, testNotifier, setup)
                {
                    if (testNotifier === void 0)
                    {
                        testNotifier = null
                    }
                    if (setup === void 0)
                    {
                        setup = null
                    }
                    
                    var hooks = this.CreateHooks(testFixture, setup);
                    
                    this.StartQUnit();
                    
                    this.context.Notifier = testNotifier;
                    
                    if (testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip)
                    {
                        
                        var result = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult(testFixture);
                        
                        this.context.CurrentResult.AddChildResult(result);
                        
                        QUnit.module.skip(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name);
                        
                        return
                    }
                    
                    QUnit.module(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name, hooks, Bridge.fn.bind(this, function()
                    {
                        var $t;
                        
                        testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance = this.testFactory.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestFactory$CreateTest$1(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Type);
                        
                        $t = Bridge.getEnumerator(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Tests, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod);
                        try
                        {
                            while ($t.moveNext())
                            {
                                var test = $t.Current;
                                
                                if (test != null)
                                {
                                    
                                    this.Run$2(test)
                                }
                            }
                        }
                        finally
                        {
                            if (Bridge.is($t, System.IDisposable))
                            {
                                $t.System$IDisposable$Dispose()
                            }
                        }
                    }))
                }, Run$2: function(test)
                {
                    
                    if (test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Skip)
                    {
                        
                        QUnit.skip(test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name);
                        
                        return
                    }
                    
                    QUnit.test(test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name, Bridge.fn.bind(this, function(assert)
                    {
                        
                        this.context.CurrentTest = test;
                        
                        var result = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestResult(test);
                        
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.SetResult(result);
                        
                        this.context.Assert = function()
                        {
                            return assert
                        };
                        
                        if (System.Nullable.hasValue(test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount))
                        {
                            
                            assert.expect(System.Nullable.getValue(test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$ExpectedCount))
                        }
                        
                        var done = assert.async();
                        
                        Bridge.Reflection.midel(test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Method, Bridge.unbox(test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Fixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance))(null);
                        
                        done()
                    }))
                }, StartQUnit: function()
                {
                    
                    if (!this.hasStarted)
                    {
                        
                        this.hasStarted = true;
                        
                        qunitLoader();
                        
                        QUnit.start();
                        
                        this.RegisterQUnitEventHandlers();
                        
                        this.InitializeTestExecutionContext()
                    }
                }, CreateHooks: function(testFixture, setup)
                {
                    
                    var hooks = {
                            beforeEach: function()
                            {
                                var $t;
                                
                                ($t = testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SetUp) != null ? Bridge.Reflection.midel($t, Bridge.unbox(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance))(null) : null
                            }, afterEach: function()
                                {
                                    var $t;
                                    
                                    ($t = testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$TearDown) != null ? Bridge.Reflection.midel($t, Bridge.unbox(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance))(null) : null
                                }
                        };
                    
                    if (!Bridge.staticEquals(setup, null))
                    {
                        
                        hooks.before = Bridge.fn.bind(this, function()
                        {
                            
                            this.SetTestFixture(testFixture);
                            
                            var promise = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise;
                            
                            return EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Helpers.Promise.Promisify(setup)()
                        })
                    }
                    else
                    {
                        
                        hooks.before = Bridge.fn.bind(this, function()
                        {
                            
                            this.SetTestFixture(testFixture)
                        })
                    }
                    
                    return hooks
                }, SetTestFixture: function(testFixture)
                {
                    
                    this.context.CurrentTestFixture = testFixture;
                    
                    var result = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult(testFixture);
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.SetResult(result)
                }, InitializeTestExecutionContext: function()
                {
                    
                    var context = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext;
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current = context;
                    
                    EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.SetResult(new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult);
                    
                    this.context = context
                }, RegisterQUnitEventHandlers: function()
                {
                    
                    var PopResult = null;
                    
                    QUnit.begin(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner.f1));
                    
                    QUnit.moduleStart(Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner.f2));
                    
                    PopResult = Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner.f3);
                    
                    QUnit.moduleDone(Bridge.fn.bind(this, function(info)
                    {
                        var $t;
                        
                        var result = Bridge.as(this.context.CurrentResult, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestFixtureResult);
                        
                        result.Duration = info.runtime;
                        
                        ($t = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.Notifier) != null ? $t.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyFixtureDone(result) : null;
                        
                        PopResult()
                    }));
                    
                    QUnit.testStart(Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner.f4)));
                    
                    QUnit.testDone(Bridge.fn.bind(this, function(info)
                    {
                        var $t;
                        
                        var result;
                        
                        if (((result = Bridge.as(this.context.CurrentResult, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestResult))) != null)
                        {
                            
                            result.Duration = info.runtime;
                            
                            ($t = this.context.Notifier) != null ? $t.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyTestEnd(result) : null;
                            
                            PopResult()
                        }
                    }));
                    
                    QUnit.log(Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner.f5)));
                    
                    QUnit.done(Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner.f6)))
                }
        }
});
Bridge.ns("EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestRunner, {
    f1: function(info)
    {
        var $t,
            $t1;
        
        ($t = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.Notifier) != null ? $t.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyStart(($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestSuiteInfo, $t1.TestCount = info.totalTests, $t1)) : null
    }, f2: function(info)
        {
            var $t,
                $t1;
            
            ($t = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.Notifier) != null ? $t.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyFixtureStart(($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestFixtureInfo, $t1.Name = info.name, $t1)) : null
        }, f3: function()
        {
            
            EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current.PopResult()
        }, f4: function(info)
        {
            var $t,
                $t1;
            
            this.context.AssertCounter = 0;
            
            ($t = this.context.Notifier) != null ? $t.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyTestStart(($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.TestInfo, $t1.Name = info.name, $t1.Module = info.module, $t1)) : null
        }, f5: function(info)
        {
            var $t;
            
            this.context.CurrentResult.AddAssertResult(($t = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.AssertResult, $t.Id = System.String.format("{0}_assert{1}", info.testId, Bridge.box(this.context.AssertCounter, System.Int32)), $t.Passed = info.result, $t.Actual = info.actual, $t.Expected = info.expected, $t.Message = info.message != null ? info.message : (info.result ? SR.T("\u041e\u043a") : SR.T("\u041f\u0440\u043e\u0432\u0430\u043b\u0435\u043d\u043e")), $t.Negative = System.Nullable.getValue(Bridge.cast(Bridge.unbox(info.negative, System.Boolean), System.Boolean)), $t.Module = info.module, $t.Source = info.source, $t));
            ($t = this.context).AssertCounter = ($t.AssertCounter + 1) | 0
        }, f6: function(info)
        {
            
            this.hasStarted = false;
            
            if (this.context != null)
            {
                
                var result = this.context.CurrentResult;
                
                result.Duration = info.runtime;
                
                result.ScenarioCount = this.context.ScenarioCount;
                
                var notifier = this.context.Notifier;
                
                notifier != null ? notifier.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$ITestNotifier$NotifyEnd(result) : null;
                
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestContext.Current = null
            }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Mocking.Mock", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.IMock], $metadata: function()
        {
            return {
                    att: 1048705, a: 2, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.String], pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 3, n: "IncrementCallCounter", t: 8, sn: "IncrementCallCounter", rt: System.Void
                            }, {
                                a: 2, n: "WasCalled", t: 8, pi: [{
                                            n: "count", dv: 0, o: true, pt: System.Int32, ps: 0
                                        }], sn: "WasCalled", rt: System.Boolean, p: [System.Int32], box: function($v)
                                    {
                                        return Bridge.box($v, System.Boolean, System.Boolean.toString)
                                    }
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 1, n: "callCounter", t: 4, rt: System.Int32, sn: "callCounter", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            callCounter: 0, Name: null
        }, alias: ["Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Mocking$IMock$Name", "WasCalled", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Mocking$IMock$WasCalled"], ctors: {
            init: function()
            {
                this.callCounter = 0
            }, ctor: function(name)
                {
                    this.$initialize();
                    
                    this.Name = name
                }
        }, methods: {
            WasCalled: function(count)
            {
                if (count === void 0)
                {
                    count = 0
                }
                
                return count === this.callCounter
            }, IncrementCallCounter: function()
                {
                    
                    this.callCounter = (this.callCounter + 1) | 0
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.ScenarioInfo", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IScenarioInfo], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, s: {
                                        a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {Name: null}, alias: ["Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IScenarioInfo$Name"]
});
Bridge.define("EleWise.ELMA.TestFramework.Notification.StepInfo", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.IStepInfo], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                            }, {
                                a: 2, n: "Name", t: 16, rt: System.String, g: {
                                        a: 2, n: "get_Name", t: 8, rt: System.String, fg: "Name"
                                    }, s: {
                                        a: 2, n: "set_Name", t: 8, p: [System.String], rt: System.Void, fs: "Name"
                                    }, fn: "Name"
                            }, {
                                a: 2, n: "Number", t: 16, rt: System.Int32, g: {
                                        a: 2, n: "get_Number", t: 8, rt: System.Int32, fg: "Number", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        a: 2, n: "set_Number", t: 8, p: [System.Int32], rt: System.Void, fs: "Number"
                                    }, fn: "Number"
                            }, {
                                a: 2, n: "Total", t: 16, rt: System.Int32, g: {
                                        a: 2, n: "get_Total", t: 8, rt: System.Int32, fg: "Total", box: function($v)
                                            {
                                                return Bridge.box($v, System.Int32)
                                            }
                                    }, s: {
                                        a: 2, n: "set_Total", t: 8, p: [System.Int32], rt: System.Void, fs: "Total"
                                    }, fn: "Total"
                            }, {
                                a: 2, n: "Type", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, g: {
                                        a: 2, n: "get_Type", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, fg: "Type", box: function($v)
                                            {
                                                return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                            }
                                    }, s: {
                                        a: 2, n: "set_Type", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType], rt: System.Void, fs: "Type"
                                    }, fn: "Type"
                            }, {
                                a: 1, backing: true, n: "<Name>k__BackingField", t: 4, rt: System.String, sn: "Name"
                            }, {
                                a: 1, backing: true, n: "<Number>k__BackingField", t: 4, rt: System.Int32, sn: "Number", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Total>k__BackingField", t: 4, rt: System.Int32, sn: "Total", box: function($v)
                                    {
                                        return Bridge.box($v, System.Int32)
                                    }
                            }, {
                                a: 1, backing: true, n: "<Type>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, sn: "Type", box: function($v)
                                    {
                                        return Bridge.box($v, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))
                                    }
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Name: null, Number: 0, Total: 0, Type: 0
        }, alias: ["Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Name", "Number", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Number", "Total", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Total", "Type", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Notification$IStepInfo$Type"]
});
Bridge.define("EleWise.ELMA.TestFramework.Results.ScenarioResult", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IScenarioResult], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario], pi: [{
                                            n: "scenario", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Scenario", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, g: {
                                        a: 2, n: "get_Scenario", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, fg: "Scenario"
                                    }, s: {
                                        a: 2, n: "set_Scenario", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario], rt: System.Void, fs: "Scenario"
                                    }, fn: "Scenario"
                            }, {
                                a: 2, n: "Steps", t: 16, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult), g: {
                                        a: 2, n: "get_Steps", t: 8, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult), fg: "Steps"
                                    }, s: {
                                        a: 2, n: "set_Steps", t: 8, p: [System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult)], rt: System.Void, fs: "Steps"
                                    }, fn: "Steps"
                            }, {
                                a: 1, backing: true, n: "<Scenario>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IScenario, sn: "Scenario"
                            }, {
                                a: 1, backing: true, n: "<Steps>k__BackingField", t: 4, rt: System.Collections.Generic.ICollection$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult), sn: "Steps"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            Scenario: null, Steps: null
        }, alias: ["Steps", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IScenarioResult$Steps"], ctors: {ctor: function(scenario)
            {
                this.$initialize();
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult.ctor.call(this);
                
                this.Scenario = scenario;
                
                this.Steps = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult)).ctor;
                
                this.Name = this.Scenario.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IScenario$Name
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Results.StepResult", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.IStepResult], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep], pi: [{
                                            n: "step", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Step", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, g: {
                                        a: 2, n: "get_Step", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, fg: "Step"
                                    }, s: {
                                        a: 1, n: "set_Step", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep], rt: System.Void, fs: "Step"
                                    }, fn: "Step"
                            }, {
                                a: 1, backing: true, n: "<Step>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, sn: "Step"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {Step: null}, alias: ["Step", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Step", "Name", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Results$IStepResult$Name"], ctors: {ctor: function(step)
            {
                this.$initialize();
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult.ctor.call(this);
                
                this.Step = step;
                
                this.Name = System.String.format("{0}: {1}", System.Enum.getName(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, Bridge.box(this.Step.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Type, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType, System.Enum.toStringFn(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType))), this.Step.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IStep$Name)
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Results.TestFixtureResult", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture], pi: [{
                                            n: "testFixture", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "TestFixture", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, g: {
                                        a: 2, n: "get_TestFixture", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, fg: "TestFixture"
                                    }, fn: "TestFixture"
                            }, {
                                a: 1, backing: true, n: "<TestFixture>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestFixture, sn: "TestFixture"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {TestFixture: null}, ctors: {ctor: function(testFixture)
            {
                var $t,
                    $t1,
                    $t2;
                this.$initialize();
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult.ctor.call(this);
                
                this.TestFixture = testFixture;
                
                this.Name = testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Name;
                
                this.Id = Bridge.Reflection.getTypeFullName(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Type);
                
                if (testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip)
                {
                    
                    this.Status = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus.Skipped;
                    
                    this.SkipReason = testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SkipReason
                }
                
                $t = Bridge.getEnumerator(testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Tests, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod);
                try
                {
                    while ($t.moveNext())
                    {
                        var test = $t.Current;
                        
                        if (this.TestFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Skip || test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Skip)
                        {
                            
                            this.Skipped = (this.Skipped + 1) | 0;
                            
                            this.AddChildResult(($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestResult(test), $t1.Status = EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestStatus.Skipped, $t1.SkipReason = ($t2 = test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$SkipReason, $t2 != null ? $t2 : testFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$SkipReason), $t1))
                        }
                    }
                }
                finally
                {
                    if (Bridge.is($t, System.IDisposable))
                    {
                        $t.System$IDisposable$Dispose()
                    }
                }
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Results.TestResult", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod], pi: [{
                                            n: "test", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, ps: 0
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Test", t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, g: {
                                        a: 2, n: "get_Test", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, fg: "Test"
                                    }, fn: "Test"
                            }, {
                                a: 1, backing: true, n: "<Test>k__BackingField", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod, sn: "Test"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {Test: null}, ctors: {ctor: function(test)
            {
                this.$initialize();
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Results.TestSuiteResult.ctor.call(this);
                
                this.Test = test;
                
                this.Name = test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$Name;
                
                this.Id = test.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestMethod$FullName
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Services.TestFactory", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.IContainer, EleWise_ELMA_Core.EleWise.ELMA.Core.Logging.ILogger], pi: [{
                                            n: "container", pt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.IContainer, ps: 0
                                        }, {
                                            n: "logger", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Logging.ILogger, ps: 1
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "CreateTest", t: 8, tpc: 1, tprm: ["T"], sn: "CreateTest", rt: System.Object
                            }, {
                                a: 2, n: "CreateTest", t: 8, pi: [{
                                            n: "type", pt: System.Type, ps: 0
                                        }], sn: "CreateTest$1", rt: System.Object, p: [System.Type]
                            }, {
                                a: 1, n: "container", t: 4, rt: EleWise_ELMA_IoC.EleWise.ELMA.Ioc.Abstract.IContainer, sn: "container", ro: true
                            }, {
                                a: 1, n: "logger", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Logging.ILogger, sn: "logger", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
            container: null, logger: null
        }, alias: ["CreateTest", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestFactory$CreateTest", "CreateTest$1", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestFactory$CreateTest$1"], ctors: {ctor: function(container, logger)
            {
                this.$initialize();
                
                this.container = container;
                
                this.logger = logger
            }}, methods: {
            CreateTest: function(T)
            {
                
                return Bridge.cast(Bridge.unbox(this.CreateTest$1(T), T), T)
            }, CreateTest$1: function(type)
                {
                    
                    if (type == null)
                    {
                        
                        throw new System.ArgumentNullException.$ctor1("type");
                    }
                    
                    if (!EleWise_ELMA_Core.EleWise.ELMA.Helpers.ReflectionHelper.IsInheritOrSame$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IBDDTest, type))
                    {
                        
                        var message = SR.T("\u041f\u0435\u0440\u0435\u0434\u0430\u043d\u043d\u044b\u0439 \u0442\u0438\u043f {0} \u043d\u0435 \u044f\u0432\u043b\u044f\u0435\u0442\u0441\u044f {1}", Bridge.Reflection.getTypeName(type), "IBDDTest");
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Core.Logging.LoggingExtensions.Error(this.logger, message);
                        
                        throw new System.Exception(message);
                    }
                    
                    var exMessage = SR.T("\u041d\u0435\u0432\u043e\u0437\u043c\u043e\u0436\u043d\u043e \u0441\u043e\u0437\u0434\u0430\u0442\u044c \u044d\u043a\u0437\u0435\u043c\u043f\u043b\u044f\u0440 \u0438\u043d\u0442\u0435\u0440\u0444\u0435\u0439\u0441\u0430 \u0434\u043b\u044f \u0442\u0438\u043f\u0430 {0}: {1}", Bridge.Reflection.getTypeName(type), type);
                    
                    try
                    {
                        
                        var test = null;
                        
                        if (Bridge.Reflection.isClass(type))
                        {
                            
                            test = this.container.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve$1(type)
                        }
                        else
                        {
                            
                            var genericType = System.Collections.Generic.IEnumerable$1.apply(null, System.Array.init([type], System.Type));
                            
                            var enumerable = Bridge.cast(this.container.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve$1(genericType), System.Collections.IEnumerable);
                            
                            var enumerator = Bridge.getEnumerator(enumerable);
                            
                            if (enumerator.System$Collections$IEnumerator$moveNext())
                            {
                                
                                test = enumerator.System$Collections$IEnumerator$Current
                            }
                        }
                        
                        if (test == null)
                        {
                            
                            EleWise_ELMA_Core.EleWise.ELMA.Core.Logging.LoggingExtensions.Error(this.logger, exMessage);
                            
                            throw new System.Exception(exMessage);
                        }
                        
                        var componentTest;
                        
                        if (((componentTest = Bridge.as(test, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest))) != null)
                        {
                            
                            componentTest.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService = this.container.EleWise_ELMA_IoC$EleWise$ELMA$Ioc$Abstract$IScopeContext$Resolve(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestComponentCreatorService)
                        }
                        
                        return test
                    }
                    catch(e)
                    {
                        e = System.Exception.create(e);
                        
                        EleWise_ELMA_Core.EleWise.ELMA.Core.Logging.LoggingExtensions.Error$1(this.logger, exMessage, e);
                        
                        throw new System.Exception(exMessage, e);
                    }
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.TestController", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.ITestController], $metadata: function()
        {
            return {
                    att: 1048832, a: 4, at: [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ServiceAttribute], m: [{
                                a: 2, n: ".ctor", t: 1, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestRunner, EleWise_ELMA_Core.EleWise.ELMA.Core.Model.Managers.ICurrentPageService, EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptLoaderService, EleWise_ELMA_Core.EleWise.ELMA.Core.Services.INotificationService, EleWise_ELMA_Core.EleWise.ELMA.UI.Managers.ComponentMetadataItemManager, EleWise_ELMA_Core.EleWise.ELMA.Services.FindComponentService, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory], pi: [{
                                            n: "testRunner", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestRunner, ps: 0
                                        }, {
                                            n: "currentPageService", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.Managers.ICurrentPageService, ps: 1
                                        }, {
                                            n: "scriptLoaderService", pt: EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptLoaderService, ps: 2
                                        }, {
                                            n: "notificationService", pt: EleWise_ELMA_Core.EleWise.ELMA.Core.Services.INotificationService, ps: 3
                                        }, {
                                            n: "ComponentMetadataItemManager", pt: EleWise_ELMA_Core.EleWise.ELMA.UI.Managers.ComponentMetadataItemManager, ps: 4
                                        }, {
                                            n: "findComponentService", pt: EleWise_ELMA_Core.EleWise.ELMA.Services.FindComponentService, ps: 5
                                        }, {
                                            n: "testFactory", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, ps: 6
                                        }], sn: "ctor"
                            }, {
                                a: 1, n: "GetType", t: 8, pi: [{
                                            n: "componentHeader", pt: EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f"), ps: 0
                                        }], sn: "GetType", rt: System.Threading.Tasks.Task$1(System.Type), p: [EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f")]
                            }, {
                                a: 2, n: "LoadComponentTests", t: 8, sn: "LoadComponentTests", rt: System.Threading.Tasks.Task$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixtureTree)
                            }, {
                                a: 2, n: "RunComponentTests", t: 8, pi: [{
                                            n: "testNotifier", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, ps: 0
                                        }], sn: "RunComponentTests", rt: System.Threading.Tasks.Task, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier]
                            }, {
                                a: 2, n: "RunComponentTests", t: 8, pi: [{
                                            n: "componentUid", pt: System.Guid, ps: 0
                                        }, {
                                            n: "notifier", pt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier, ps: 1
                                        }], sn: "RunComponentTests$1", rt: System.Void, p: [System.Guid, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Notification.ITestNotifier]
                            }, {
                                a: 2, n: "RunTests", t: 8, sn: "RunTests", rt: System.Void
                            }, {
                                a: 2, n: "FrameworkConfig", is: true, t: 16, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestConfig, g: {
                                        a: 2, n: "get_FrameworkConfig", t: 8, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestConfig, fg: "FrameworkConfig", is: true
                                    }, s: {
                                        a: 1, n: "set_FrameworkConfig", t: 8, p: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestConfig], rt: System.Void, fs: "FrameworkConfig", is: true
                                    }, fn: "FrameworkConfig"
                            }, {
                                a: 2, n: "LoadedTests", t: 16, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture), g: {
                                        a: 2, n: "get_LoadedTests", t: 8, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture), fg: "LoadedTests"
                                    }, s: {
                                        a: 1, n: "set_LoadedTests", t: 8, p: [System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture)], rt: System.Void, fs: "LoadedTests"
                                    }, fn: "LoadedTests"
                            }, {
                                a: 1, n: "ComponentMetadataItemManager", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.UI.Managers.ComponentMetadataItemManager, sn: "ComponentMetadataItemManager", ro: true
                            }, {
                                a: 1, n: "ComponentTestsKey", is: true, t: 4, rt: System.String, sn: "ComponentTestsKey"
                            }, {
                                a: 1, n: "currentPageService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Model.Managers.ICurrentPageService, sn: "currentPageService", ro: true
                            }, {
                                a: 1, n: "findComponentService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Services.FindComponentService, sn: "findComponentService", ro: true
                            }, {
                                a: 1, n: "notificationService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Core.Services.INotificationService, sn: "notificationService", ro: true
                            }, {
                                a: 1, n: "scriptLoaderService", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Scripts.IScriptLoaderService, sn: "scriptLoaderService", ro: true
                            }, {
                                a: 1, n: "testBuilder", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestAssemblyBuilder, sn: "testBuilder", ro: true
                            }, {
                                a: 1, n: "testFactory", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Services.ITestFactory, sn: "testFactory", ro: true
                            }, {
                                a: 1, n: "testRunner", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestRunner, sn: "testRunner", ro: true
                            }, {
                                a: 1, backing: true, n: "<FrameworkConfig>k__BackingField", is: true, t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestConfig, sn: "FrameworkConfig"
                            }, {
                                a: 1, backing: true, n: "<LoadedTests>k__BackingField", t: 4, rt: System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture), sn: "LoadedTests"
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", statics: {
            fields: {
                ComponentTestsKey: null, FrameworkConfig: null
            }, ctors: {init: function()
                    {
                        this.ComponentTestsKey = "ComponentTests"
                    }}
        }, fields: {
            testRunner: null, currentPageService: null, scriptLoaderService: null, testBuilder: null, ComponentMetadataItemManager: null, findComponentService: null, notificationService: null, testFactory: null, LoadedTests: null
        }, alias: ["RunComponentTests$1", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$RunComponentTests$1", "LoadComponentTests", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$LoadComponentTests", "RunComponentTests", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$RunComponentTests", "RunTests", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$ITestController$RunTests"], ctors: {ctor: function(testRunner, currentPageService, scriptLoaderService, notificationService, ComponentMetadataItemManager, findComponentService, testFactory)
            {
                this.$initialize();
                
                this.currentPageService = currentPageService;
                
                this.testRunner = testRunner;
                
                this.scriptLoaderService = scriptLoaderService;
                
                this.notificationService = notificationService;
                
                this.ComponentMetadataItemManager = ComponentMetadataItemManager;
                
                this.findComponentService = findComponentService;
                
                this.testFactory = testFactory;
                
                this.testBuilder = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestAssemblyBuilder;
                
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestController.FrameworkConfig = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestConfig
            }}, methods: {
            RunComponentTests$1: function(componentUid, notifier)
            {
                
                var pageModel = this.currentPageService.EleWise_ELMA_Core$EleWise$ELMA$Core$Model$Managers$ICurrentPageService$CurrentPageViewModel;
                
                var assemblyName = pageModel.ClientScriptModule.AssemblyName$cf23fd70ffa340a887b3ad45436c7f90;
                
                var moduleObject = this.scriptLoaderService.EleWise_ELMA_Core$EleWise$ELMA$Scripts$IScriptLoaderService$LoadModule(assemblyName);
                
                if (moduleObject == null)
                {
                    
                    return
                }
                
                var metadata = Bridge.as(pageModel.Metadata, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("cedf4565-7e30-485b-9aeb-27bbdb389816"));
                
                if (metadata == null)
                {
                    
                    return
                }
                
                var $namespace = EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.MetadataHelper.GetTypeFromModule(metadata, moduleObject);
                
                if ($namespace == null)
                {
                    
                    return
                }
                
                var type = $namespace[EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestController.ComponentTestsKey];
                
                if (type == null)
                {
                    
                    return
                }
                
                var testFixture = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestFixture.ctor(type);
                
                if (!System.Linq.Enumerable.from(testFixture.Tests, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod).any())
                {
                    
                    this.notificationService.EleWise_ELMA_Core$EleWise$ELMA$Core$Services$INotificationService$Warning(SR.T("\u0417\u0430\u043f\u0443\u0441\u043a \u0442\u0435\u0441\u0442\u043e\u0432"), SR.T("\u041d\u0435 \u043d\u0430\u0439\u0434\u0435\u043d\u044b \u0442\u0435\u0441\u0442\u044b \u0434\u043b\u044f \u0437\u0430\u043f\u0443\u0441\u043a\u0430"), true);
                    
                    return
                }
                
                this.testRunner.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$1(testFixture, notifier, void 0)
            }, RunComponentTests: function(testNotifier)
                {
                    var $t;
                    
                    if (this.LoadedTests == null)
                    {
                        
                        throw new System.InvalidOperationException.$ctor1(SR.T("\u0422\u0435\u0441\u0442\u044b \u043a\u043e\u043c\u043f\u043e\u043d\u0435\u043d\u0442\u043e\u0432 \u043d\u0435 \u0431\u044b\u043b\u0438 \u0437\u0430\u0433\u0440\u0443\u0436\u0435\u043d\u044b"));
                    }
                    
                    $t = Bridge.getEnumerator(this.LoadedTests);
                    try
                    {
                        while ($t.moveNext())
                        {
                            var componentTest = {v: $t.Current};
                            
                            this.testRunner.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$1(componentTest.v.TestFixture, testNotifier, (function($me, componentTest)
                            {
                                return Bridge.fn.bind($me, function()
                                    {
                                        var $step = 0,
                                            $task1,
                                            $task2,
                                            $taskResult2,
                                            $jumpFromFinally,
                                            $tcs = new System.Threading.Tasks.TaskCompletionSource,
                                            $returnValue,
                                            type,
                                            $async_e,
                                            $asyncBody = Bridge.fn.bind(this, function()
                                            {
                                                try
                                                {
                                                    for (; ; )
                                                    {
                                                        $step = System.Array.min([0, 1, 2], $step);
                                                        switch ($step)
                                                        {
                                                            case 0:
                                                                {
                                                                    
                                                                    $task1 = this.currentPageService.EleWise_ELMA_Core$EleWise$ELMA$Core$Model$Managers$ICurrentPageService$SetCurrentPageUidAsync(componentTest.v.Header.ModuleUid$58d07f503a6246ab9bae7744ba909f2f, componentTest.v.Header.Uid$58d07f503a6246ab9bae7744ba909f2f, componentTest.v.Header.MetadataTypeUid$58d07f503a6246ab9bae7744ba909f2f, EleWise_ELMA_Core.EleWise.ELMA.Model.InterfaceBuilderViewMode.Emulation);
                                                                    $step = 1;
                                                                    if ($task1.isCompleted())
                                                                        continue;
                                                                    $task1.continue($asyncBody);
                                                                    return
                                                                }
                                                            case 1:
                                                                {
                                                                    $task1.getAwaitedResult();
                                                                    
                                                                    $task2 = this.GetType(componentTest.v.Header);
                                                                    $step = 2;
                                                                    if ($task2.isCompleted())
                                                                        continue;
                                                                    $task2.continue($asyncBody);
                                                                    return
                                                                }
                                                            case 2:
                                                                {
                                                                    $taskResult2 = $task2.getAwaitedResult();
                                                                    type = $taskResult2;
                                                                    
                                                                    componentTest.v.TestFixture.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestFixture$Instance = this.testFactory.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestFactory$CreateTest$1(type);
                                                                    $tcs.setResult(null);
                                                                    return
                                                                }
                                                            default:
                                                                {
                                                                    $tcs.setResult(null);
                                                                    return
                                                                }
                                                        }
                                                    }
                                                }
                                                catch($async_e1)
                                                {
                                                    $async_e = System.Exception.create($async_e1);
                                                    $tcs.setException($async_e)
                                                }
                                            }, arguments);
                                        if (mobx._getGlobalState().allowStateChanges)
                                        {
                                            $asyncBody = mobx.action($asyncBody)
                                        }
                                        $asyncBody();
                                        return $tcs.task
                                    })
                            })(this, componentTest))
                        }
                    }
                    finally
                    {
                        if (Bridge.is($t, System.IDisposable))
                        {
                            $t.System$IDisposable$Dispose()
                        }
                    }
                    
                    return System.Threading.Tasks.Task.CompletedTask
                }, LoadComponentTests: function()
                {
                    var $step = 0,
                        $task1,
                        $taskResult1,
                        $task2,
                        $taskResult2,
                        $jumpFromFinally,
                        $tcs = new System.Threading.Tasks.TaskCompletionSource,
                        $returnValue,
                        componentHeaders,
                        componentCount,
                        totalTestCount,
                        testComponentCount,
                        componentTests,
                        $t,
                        componentHeader,
                        componentTestModule,
                        type,
                        testFixture,
                        testCount,
                        $t1,
                        componentTestModuleTree,
                        $async_e,
                        $asyncBody = Bridge.fn.bind(this, function()
                        {
                            try
                            {
                                for (; ; )
                                {
                                    $step = System.Array.min([0, 1, 2, 3, 4, 5], $step);
                                    switch ($step)
                                    {
                                        case 0:
                                            {
                                                
                                                $task1 = this.ComponentMetadataItemManager.GetAllHeaders();
                                                $step = 1;
                                                if ($task1.isCompleted())
                                                    continue;
                                                $task1.continue($asyncBody);
                                                return
                                            }
                                        case 1:
                                            {
                                                $taskResult1 = $task1.getAwaitedResult();
                                                componentHeaders = $taskResult1;
                                                
                                                componentCount = System.Linq.Enumerable.from(componentHeaders, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f")).count();
                                                
                                                totalTestCount = 0;
                                                
                                                testComponentCount = 0;
                                                
                                                componentTests = new(System.Collections.Generic.List$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture)).ctor;
                                                
                                                $t = Bridge.getEnumerator(componentHeaders, EleWise_ELMA_Core.EleWise.ELMA.DTO.DTOHelper.ProxyType("58d07f50-3a62-46ab-9bae-7744ba909f2f"));
                                                $step = 2;
                                                continue
                                            }
                                        case 2:
                                            {
                                                if ($t.moveNext())
                                                {
                                                    componentHeader = $t.Current;
                                                    $step = 3;
                                                    continue
                                                }
                                                $step = 5;
                                                continue
                                            }
                                        case 3:
                                            {
                                                
                                                componentTestModule = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture;
                                                
                                                $task2 = this.GetType(componentHeader);
                                                $step = 4;
                                                if ($task2.isCompleted())
                                                    continue;
                                                $task2.continue($asyncBody);
                                                return
                                            }
                                        case 4:
                                            {
                                                $taskResult2 = $task2.getAwaitedResult();
                                                type = $taskResult2;
                                                
                                                if (type == null)
                                                {
                                                    
                                                    $step = 2;
                                                    continue
                                                }
                                                
                                                testFixture = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.TestFixture.$ctor1(type, componentHeader.DisplayName$58d07f503a6246ab9bae7744ba909f2f);
                                                
                                                testCount = System.Linq.Enumerable.from(testFixture.Tests, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ITestMethod).count();
                                                
                                                if (testCount === 0)
                                                {
                                                    
                                                    $step = 2;
                                                    continue
                                                }
                                                
                                                testComponentCount = (testComponentCount + 1) | 0;
                                                
                                                totalTestCount = (totalTestCount + testCount) | 0;
                                                
                                                componentTests.add(($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixture, $t1.Header = componentHeader, $t1.TestFixture = testFixture, $t1));
                                                $step = 2;
                                                continue
                                            }
                                        case 5:
                                            {
                                                
                                                componentTestModuleTree = ($t1 = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Core.ComponentTestFixtureTree, $t1.ComponentCount = componentCount, $t1.TestComponentCount = testComponentCount, $t1.TotalTestsCount = totalTestCount, $t1.TestModules = componentTests, $t1);
                                                
                                                this.LoadedTests = componentTests;
                                                
                                                $tcs.setResult(componentTestModuleTree);
                                                return
                                            }
                                        default:
                                            {
                                                $tcs.setResult(null);
                                                return
                                            }
                                    }
                                }
                            }
                            catch($async_e1)
                            {
                                $async_e = System.Exception.create($async_e1);
                                $tcs.setException($async_e)
                            }
                        }, arguments);
                    if (mobx._getGlobalState().allowStateChanges)
                    {
                        $asyncBody = mobx.action($asyncBody)
                    }
                    $asyncBody();
                    return $tcs.task
                }, RunTests: function()
                {
                    
                    var testAssemblies = this.testBuilder.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestAssemblyBuilder$Build$1(System.AppDomain.getAssemblies());
                    
                    this.testRunner.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Core$ITestRunner$Run$3(testAssemblies)
                }, GetType: function(componentHeader)
                {
                    var $step = 0,
                        $task1,
                        $taskResult1,
                        $jumpFromFinally,
                        $tcs = new System.Threading.Tasks.TaskCompletionSource,
                        $returnValue,
                        model,
                        componentMetadata,
                        assemblyName,
                        moduleObject,
                        $namespace,
                        type,
                        $async_e,
                        $asyncBody = Bridge.fn.bind(this, function()
                        {
                            try
                            {
                                for (; ; )
                                {
                                    $step = System.Array.min([0, 1], $step);
                                    switch ($step)
                                    {
                                        case 0:
                                            {
                                                
                                                $task1 = this.findComponentService.FindComponent(componentHeader.Uid$58d07f503a6246ab9bae7744ba909f2f, EleWise_ELMA_Core.EleWise.ELMA.Model.InterfaceBuilderViewMode.Emulation);
                                                $step = 1;
                                                if ($task1.isCompleted())
                                                    continue;
                                                $task1.continue($asyncBody);
                                                return
                                            }
                                        case 1:
                                            {
                                                $taskResult1 = $task1.getAwaitedResult();
                                                model = $taskResult1;
                                                
                                                if (model == null)
                                                {
                                                    
                                                    $tcs.setResult(null);
                                                    return
                                                }
                                                
                                                componentMetadata = this.ComponentMetadataItemManager.LoadOrNull(model.Header.ItemUid$48b67b7545b24092919e716c4de71544);
                                                
                                                if (componentMetadata == null)
                                                {
                                                    
                                                    $tcs.setResult(null);
                                                    return
                                                }
                                                
                                                assemblyName = componentMetadata.ClientScriptModule$85a97708d13a403cb13f5de968ee9b90.AssemblyName$cf23fd70ffa340a887b3ad45436c7f90;
                                                
                                                moduleObject = this.scriptLoaderService.EleWise_ELMA_Core$EleWise$ELMA$Scripts$IScriptLoaderService$LoadModule(assemblyName);
                                                
                                                if (moduleObject == null)
                                                {
                                                    
                                                    $tcs.setResult(null);
                                                    return
                                                }
                                                
                                                $namespace = EleWise_ELMA_Core.EleWise.ELMA.Model.Metadata.MetadataHelper.GetTypeFromModule(componentMetadata.Metadata$85a97708d13a403cb13f5de968ee9b90, moduleObject);
                                                
                                                if ($namespace == null)
                                                {
                                                    
                                                    $tcs.setResult(null);
                                                    return
                                                }
                                                
                                                type = $namespace[EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.TestController.ComponentTestsKey];
                                                
                                                $tcs.setResult(type);
                                                return
                                            }
                                        default:
                                            {
                                                $tcs.setResult(null);
                                                return
                                            }
                                    }
                                }
                            }
                            catch($async_e1)
                            {
                                $async_e = System.Exception.create($async_e1);
                                $tcs.setException($async_e)
                            }
                        }, arguments);
                    if (mobx._getGlobalState().allowStateChanges)
                    {
                        $asyncBody = mobx.action($asyncBody)
                    }
                    $asyncBody();
                    return $tcs.task
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.BDD.Test$1", EleWise_ELMA_TestFramework, function(T)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        v: true, a: 2, n: "Given", t: 8, pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "setup", pt: Function, ps: 1
                                                }], sn: "Given$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                                    }, {
                                        ov: true, a: 2, n: "RunScenario", t: 8, pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                                }], sn: "RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                                    }, {
                                        v: true, a: 2, n: "Then", t: 8, pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "assertion", pt: Function, ps: 1
                                                }], sn: "Then$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                                    }, {
                                        v: true, a: 2, n: "When", t: 8, pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "action", pt: Function, ps: 1
                                                }], sn: "When$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.String, Function]
                                    }, {
                                        ab: true, a: 3, n: "Model", t: 16, rt: Function, g: {
                                                ab: true, a: 3, n: "get_Model", t: 8, rt: Function, fg: "Model"
                                            }, fn: "Model"
                                    }, {
                                        a: 1, backing: true, n: "<Model>k__BackingField", t: 4, rt: Function, sn: "Model"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", alias: ["RunScenario", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$RunScenario"], methods: {
                    RunScenario: function(name, steps)
                    {
                        if (steps === void 0)
                        {
                            steps = []
                        }
                        
                        if (steps.length === 0)
                        {
                            
                            throw new System.InvalidOperationException.$ctor1(SR.T("\u0421\u0446\u0435\u043d\u0430\u0440\u0438\u0439 \u0434\u043e\u043b\u0436\u0435\u043d \u0441\u043e\u0434\u0435\u0440\u0436\u0430\u0442\u044c \u043a\u0430\u043a \u043c\u0438\u043d\u0438\u043c\u0443\u043c \u043e\u0434\u0438\u043d \u0448\u0430\u0433"));
                        }
                        
                        var bddRunner = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.BDDRunner;
                        
                        bddRunner.RunScenario$1(T, name, this.Model, steps)
                    }, Given$1: function(name, setup)
                        {
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(T))(setup, name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.GIVEN)
                        }, When$1: function(name, action)
                        {
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(T))(action, name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.WHEN)
                        }, Then$1: function(name, assertion)
                        {
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(T))(assertion, name, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.THEN)
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Mocking.MockFunction", {
    inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock], $metadata: function()
        {
            return {
                    att: 1048576, a: 4, m: [{
                                a: 2, n: ".ctor", t: 1, p: [System.String, Function], pi: [{
                                            n: "name", pt: System.String, ps: 0
                                        }, {
                                            n: "fn", pt: Function, ps: 1
                                        }], sn: "ctor"
                            }, {
                                a: 2, n: "Call", t: 8, sn: "Call", rt: System.Threading.Tasks.Task
                            }, {
                                a: 1, n: "fn", t: 4, rt: Function, sn: "fn", ro: true
                            }]
                }
        }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {fn: null}, ctors: {ctor: function(name, fn)
            {
                this.$initialize();
                EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock.ctor.call(this, name);
                
                this.fn = fn
            }}, methods: {Call: function()
            {
                
                this.IncrementCallCounter();
                
                this.fn();
                
                return System.Threading.Tasks.Task.CompletedTask
            }}
});
Bridge.define("EleWise.ELMA.TestFramework.Mocking.MockFunctionWithOutput$1", EleWise_ELMA_TestFramework, function(TResult)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock], $metadata: function()
                {
                    return {
                            att: 1048576, a: 4, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [System.String, Function], pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "fn", pt: Function, ps: 1
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Call", t: 8, sn: "Call", rt: System.Threading.Tasks.Task$1(TResult)
                                    }, {
                                        a: 1, n: "fn", t: 4, rt: Function, sn: "fn", ro: true
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {fn: null}, ctors: {ctor: function(name, fn)
                    {
                        this.$initialize();
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock.ctor.call(this, name);
                        
                        this.fn = fn
                    }}, methods: {Call: function()
                    {
                        
                        this.IncrementCallCounter();
                        
                        return System.Threading.Tasks.Task.fromResult(this.fn(), TResult)
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParam$1", EleWise_ELMA_TestFramework, function(T)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock], $metadata: function()
                {
                    return {
                            att: 1048576, a: 4, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [System.String, Function], pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "fn", pt: Function, ps: 1
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Call", t: 8, pi: [{
                                                    n: "arg", pt: T, ps: 0
                                                }], sn: "Call", rt: System.Threading.Tasks.Task, p: [T]
                                    }, {
                                        a: 1, n: "fn", t: 4, rt: Function, sn: "fn", ro: true
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {fn: null}, ctors: {ctor: function(name, fn)
                    {
                        this.$initialize();
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock.ctor.call(this, name);
                        
                        this.fn = fn
                    }}, methods: {Call: function(arg)
                    {
                        
                        this.IncrementCallCounter();
                        
                        this.fn(arg);
                        
                        return System.Threading.Tasks.Task.CompletedTask
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParamAndOutput$2", EleWise_ELMA_TestFramework, function(T, TResult)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock], $metadata: function()
                {
                    return {
                            att: 1048576, a: 4, m: [{
                                        a: 2, n: ".ctor", t: 1, p: [System.String, Function], pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "fn", pt: Function, ps: 1
                                                }], sn: "ctor"
                                    }, {
                                        a: 2, n: "Call", t: 8, pi: [{
                                                    n: "param", pt: T, ps: 0
                                                }], sn: "Call", rt: System.Threading.Tasks.Task$1(TResult), p: [T]
                                    }, {
                                        a: 1, n: "fn", t: 4, rt: Function, sn: "fn", ro: true
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {fn: null}, ctors: {ctor: function(name, fn)
                    {
                        this.$initialize();
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.Mock.ctor.call(this, name);
                        
                        this.fn = fn
                    }}, methods: {Call: function(param)
                    {
                        
                        this.IncrementCallCounter();
                        
                        return System.Threading.Tasks.Task.fromResult(this.fn(param), TResult)
                    }}
        }
});
Bridge.define("EleWise.ELMA.TestFramework.API.BaseReactComponentTest$3", EleWise_ELMA_TestFramework, function(TInputs, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseReactComponentTestModel$3(TContext, TController, TInputs)), EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 1, n: "CreateTestModel", t: 8, sn: "CreateTestModel", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseReactComponentTestModel$3(TContext, TController, TInputs)
                                    }, {
                                        ov: true, a: 2, sl: true, n: "RunScenario", t: 8, pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                                }], sn: "RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                                    }, {
                                        a: 1, n: "Setup", t: 8, sn: "Setup", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep
                                    }, {
                                        a: 1, n: "TriggerLifeCycleMethods", t: 8, sn: "TriggerLifeCycleMethods", rt: System.Void
                                    }, {
                                        ab: true, a: 2, n: "ComponentType", t: 16, rt: System.Type, g: {
                                                ab: true, a: 2, n: "get_ComponentType", t: 8, rt: System.Type, fg: "ComponentType"
                                            }, fn: "ComponentType"
                                    }, {
                                        ov: true, a: 3, n: "Model", t: 16, rt: Function, g: {
                                                ov: true, a: 3, n: "get_Model", t: 8, rt: Function, fg: "Model"
                                            }, fn: "Model"
                                    }, {
                                        a: 1, n: "model", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseReactComponentTestModel$3(TContext, TController, TInputs), sn: "model"
                                    }, {
                                        a: 1, n: "viewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel, sn: "viewModel"
                                    }, {
                                        a: 1, backing: true, n: "<ComponentType>k__BackingField", t: 4, rt: System.Type, sn: "ComponentType"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    viewModel: null, model: null, EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService: null
                }, props: {Model: {get: function()
                        {
                            
                            return Bridge.fn.cacheBind(this, this.CreateTestModel)
                        }}}, alias: ["RunScenario", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$RunScenario"], methods: {
                    RunScenario: function(name, steps)
                    {
                        if (steps === void 0)
                        {
                            steps = []
                        }
                        
                        if (steps.length > 0)
                        {
                            
                            steps.unshift(this.Setup())
                        }
                        
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseReactComponentTestModel$3(TContext, TController, TInputs)).prototype.RunScenario.call(this, name, steps)
                    }, CreateTestModel: function()
                        {
                            
                            var componentCreator = (Bridge.as(this, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest)).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService;
                            
                            this.viewModel = Bridge.cast(componentCreator.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateBaseReactComponent$1(this.ComponentType, TInputs, TContext, TController), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewModel);
                            
                            this.model = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseReactComponentTestModel$3(TContext, TController, TInputs))(this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Context, this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller, this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs);
                            
                            return this.model
                        }, Setup: function()
                        {
                            
                            var setup = Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseReactComponentTest$3.f1));
                            
                            return new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Step(setup, Bridge.Reflection.getTypeName(this.ComponentType), EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.GIVEN)
                        }, TriggerLifeCycleMethods: function()
                        {
                            var $step = 0,
                                $task1,
                                $jumpFromFinally,
                                onInitController,
                                $t,
                                onLoadController,
                                $t1,
                                onLoadAsyncController,
                                task,
                                $t2,
                                $asyncBody = Bridge.fn.bind(this, function()
                                {
                                    for (; ; )
                                    {
                                        $step = System.Array.min([0, 1, 2, 3], $step);
                                        switch ($step)
                                        {
                                            case 0:
                                                {
                                                    
                                                    if (((onInitController = Bridge.as(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller"], EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit))) != null)
                                                    {
                                                        
                                                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller"], ($t = Bridge.Reflection.getMembers(EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit, 8, 284, "OnInit")) != null ? $t.sn : null, null)
                                                    }
                                                    
                                                    if (((onLoadController = Bridge.as(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller"], EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad))) != null)
                                                    {
                                                        
                                                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller"], ($t1 = Bridge.Reflection.getMembers(EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad, 8, 284, "OnLoad")) != null ? $t1.sn : null, null)
                                                    }
                                                    
                                                    if (((onLoadAsyncController = Bridge.as(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller"], EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync))) != null)
                                                    {
                                                        $step = 1;
                                                        continue
                                                    }
                                                    $step = 3;
                                                    continue
                                                }
                                            case 1:
                                                {
                                                    
                                                    task = Bridge.cast(EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseReactComponentTestModel$3$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$" + Bridge.getTypeAlias(TInputs) + "$Controller"], ($t2 = Bridge.Reflection.getMembers(EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync, 8, 284, "OnLoadAsync")) != null ? $t2.sn : null, null), System.Threading.Tasks.Task);
                                                    
                                                    $task1 = task.wait();
                                                    $step = 2;
                                                    if ($task1.isCompleted())
                                                        continue;
                                                    $task1.continue($asyncBody);
                                                    return
                                                }
                                            case 2:
                                                {
                                                    $task1.getAwaitedResult();
                                                    $step = 3;
                                                    continue
                                                }
                                            case 3:
                                                {
                                                    return
                                                }
                                            default:
                                                {
                                                    return
                                                }
                                        }
                                    }
                                }, arguments);
                            if (mobx._getGlobalState().allowStateChanges)
                            {
                                $asyncBody = mobx.action($asyncBody)
                            }
                            $asyncBody()
                        }
                }
        }
});
Bridge.ns("EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseReactComponentTest$3", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseReactComponentTest$3, {f1: function()
    {
        
        this.TriggerLifeCycleMethods()
    }});
Bridge.define("EleWise.ELMA.TestFramework.API.BaseViewItemComponentTest$4", EleWise_ELMA_TestFramework, function(TViewItem, TInputs, TContext, TController)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseViewItemComponentTestModel$4(TViewItem, TInputs, TContext, TController)), EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 1, n: "CreateTestModel", t: 8, sn: "CreateTestModel", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseViewItemComponentTestModel$4(TViewItem, TInputs, TContext, TController)
                                    }, {
                                        ov: true, a: 2, n: "RunScenario", t: 8, pi: [{
                                                    n: "name", pt: System.String, ps: 0
                                                }, {
                                                    n: "steps", ip: true, pt: System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep), ps: 1
                                                }], sn: "RunScenario", rt: System.Void, p: [System.String, System.Array.type(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep)]
                                    }, {
                                        a: 1, n: "Setup", t: 8, sn: "Setup", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep
                                    }, {
                                        a: 1, n: "TriggerLifeCycleMethods", t: 8, sn: "TriggerLifeCycleMethods", rt: System.Void
                                    }, {
                                        ab: true, a: 2, n: "ComponentType", t: 16, rt: System.Type, g: {
                                                ab: true, a: 2, n: "get_ComponentType", t: 8, rt: System.Type, fg: "ComponentType"
                                            }, fn: "ComponentType"
                                    }, {
                                        ov: true, a: 3, n: "Model", t: 16, rt: Function, g: {
                                                ov: true, a: 3, n: "get_Model", t: 8, rt: Function, fg: "Model"
                                            }, fn: "Model"
                                    }, {
                                        a: 1, n: "model", t: 4, rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseViewItemComponentTestModel$4(TViewItem, TInputs, TContext, TController), sn: "model"
                                    }, {
                                        a: 1, n: "viewModel", t: 4, rt: EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemViewModel, sn: "viewModel"
                                    }, {
                                        a: 1, backing: true, n: "<ComponentType>k__BackingField", t: 4, rt: System.Type, sn: "ComponentType"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {
                    viewModel: null, model: null, EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService: null
                }, props: {Model: {get: function()
                        {
                            
                            return Bridge.fn.bind(this, Bridge.fn.bind(this, $asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseViewItemComponentTest$4.f1))
                        }}}, alias: ["RunScenario", "EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$BDD$IBDDTest$RunScenario"], methods: {
                    RunScenario: function(name, steps)
                    {
                        if (steps === void 0)
                        {
                            steps = []
                        }
                        
                        if (steps.length > 0)
                        {
                            
                            steps.unshift(this.Setup())
                        }
                        
                        EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IBaseViewItemComponentTestModel$4(TViewItem, TInputs, TContext, TController)).prototype.RunScenario.call(this, name, steps)
                    }, CreateTestModel: function()
                        {
                            
                            var componentCreator = (Bridge.as(this, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest)).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService;
                            
                            this.viewModel = Bridge.cast(componentCreator.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateBaseViewItemComponent$1(this.ComponentType, TViewItem, TContext, TController), EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IViewItemViewModel);
                            
                            this.model = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseViewItemComponentTestModel$4(TViewItem, TInputs, TContext, TController))(this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewItemViewModel$ViewItem, this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$InputModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IInputModel$Inputs, this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Context, this.viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller);
                            
                            return this.model
                        }, Setup: function()
                        {
                            
                            return new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Step(Bridge.fn.cacheBind(this, this.TriggerLifeCycleMethods), Bridge.Reflection.getTypeName(this.ComponentType), EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.GIVEN)
                        }, TriggerLifeCycleMethods: function()
                        {
                            var $step = 0,
                                $task1,
                                $jumpFromFinally,
                                onInitController,
                                $t,
                                onLoadController,
                                $t1,
                                onLoadAsyncController,
                                task,
                                $t2,
                                $asyncBody = Bridge.fn.bind(this, function()
                                {
                                    for (; ; )
                                    {
                                        $step = System.Array.min([0, 1, 2, 3], $step);
                                        switch ($step)
                                        {
                                            case 0:
                                                {
                                                    
                                                    if (((onInitController = Bridge.as(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit))) != null)
                                                    {
                                                        
                                                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], ($t = Bridge.Reflection.getMembers(EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnInit, 8, 284, "OnInit")) != null ? $t.sn : null, null)
                                                    }
                                                    
                                                    if (((onLoadController = Bridge.as(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad))) != null)
                                                    {
                                                        
                                                        EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], ($t1 = Bridge.Reflection.getMembers(EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoad, 8, 284, "OnLoad")) != null ? $t1.sn : null, null)
                                                    }
                                                    
                                                    if (((onLoadAsyncController = Bridge.as(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync))) != null)
                                                    {
                                                        $step = 1;
                                                        continue
                                                    }
                                                    $step = 3;
                                                    continue
                                                }
                                            case 1:
                                                {
                                                    
                                                    task = Bridge.cast(EleWise_ELMA_Core.EleWise.ELMA.Helpers.ViewModelHelper.CallControllerMethod(this.model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IBaseViewItemComponentTestModel$4$" + Bridge.getTypeAlias(TViewItem) + "$" + Bridge.getTypeAlias(TInputs) + "$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"], ($t2 = Bridge.Reflection.getMembers(EleWise_ELMA_Core.EleWise.ELMA.Core.Controllers.IOnLoadAsync, 8, 284, "OnLoadAsync")) != null ? $t2.sn : null, null), System.Threading.Tasks.Task);
                                                    
                                                    $task1 = task.wait();
                                                    $step = 2;
                                                    if ($task1.isCompleted())
                                                        continue;
                                                    $task1.continue($asyncBody);
                                                    return
                                                }
                                            case 2:
                                                {
                                                    $task1.getAwaitedResult();
                                                    $step = 3;
                                                    continue
                                                }
                                            case 3:
                                                {
                                                    return
                                                }
                                            default:
                                                {
                                                    return
                                                }
                                        }
                                    }
                                }, arguments);
                            if (mobx._getGlobalState().allowStateChanges)
                            {
                                $asyncBody = mobx.action($asyncBody)
                            }
                            $asyncBody()
                        }
                }
        }
});
Bridge.ns("EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseViewItemComponentTest$4", $asm.$);
Bridge.apply($asm.$.EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.BaseViewItemComponentTest$4, {f1: function()
    {
        return this.CreateTestModel()
    }});
Bridge.define("EleWise.ELMA.TestFramework.API.ComponentTest$2", EleWise_ELMA_TestFramework, function(TController, TServer)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)), EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 1, n: "CreateTestModel", t: 8, sn: "CreateTestModel", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)
                                    }, {
                                        a: 1, n: "GetMethodInfo", t: 8, pi: [{
                                                    n: "expression", pt: System.Object, ps: 0
                                                }], sn: "GetMethodInfo", rt: System.Reflection.MethodInfo, p: [System.Object]
                                    }, {
                                        a: 1, n: "GetPropertyName", t: 8, pi: [{
                                                    n: "target", pt: System.Object, ps: 0
                                                }, {
                                                    n: "prop", pt: System.Object, ps: 1
                                                }], sn: "GetPropertyName", rt: System.String, p: [System.Object, System.Object]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], sn: "MockAction", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "MockAction$2", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "MockAction$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], tpc: 2, tprm: ["T", "TResult"], sn: "MockAction$3", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 1, n: "MockProperty", t: 8, pi: [{
                                                    n: "target", pt: System.Object, ps: 0
                                                }, {
                                                    n: "propertyName", pt: System.String, ps: 1
                                                }, {
                                                    n: "mock", pt: System.Object, ps: 2
                                                }, {
                                                    n: "computed", dv: false, o: true, pt: System.Boolean, ps: 3
                                                }], sn: "MockProperty", rt: System.Void, p: [System.Object, System.String, System.Object, System.Boolean]
                                    }, {
                                        a: 2, n: "MockServer", t: 8, pi: [{
                                                    n: "expression", pt: System.Object, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], sn: "MockServer", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.Object, Function]
                                    }, {
                                        a: 2, n: "SetValue", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "valueFunc", pt: Function, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "SetValue$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "SetValue", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "value", pt: System.Object, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "SetValue", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, System.Object]
                                    }, {
                                        ab: true, a: 2, n: "ComponentUid", t: 16, rt: System.String, g: {
                                                ab: true, a: 2, n: "get_ComponentUid", t: 8, rt: System.String, fg: "ComponentUid"
                                            }, fn: "ComponentUid"
                                    }, {
                                        ov: true, a: 3, n: "Model", t: 16, rt: Function, g: {
                                                ov: true, a: 3, n: "get_Model", t: 8, rt: Function, fg: "Model"
                                            }, fn: "Model"
                                    }, {
                                        a: 1, backing: true, n: "<ComponentUid>k__BackingField", t: 4, rt: System.String, sn: "ComponentUid"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService: null}, props: {Model: {get: function()
                        {
                            
                            return Bridge.fn.cacheBind(this, this.CreateTestModel)
                        }}}, methods: {
                    MockServer: function(expression, mockFn)
                    {
                        
                        var methodInfo = this.GetMethodInfo(expression);
                        
                        var methodName = methodInfo.n;
                        
                        var action = function(model)
                            {
                                
                                var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParam$1(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IContext))(methodName, mockFn);
                                
                                var serverMethod = function()
                                    {
                                        return mock.Call(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"])
                                    };
                                
                                model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Controller"].EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IClientController$Server[methodInfo.sn] = serverMethod
                            };
                        
                        return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, methodName, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                    }, MockAction: function(expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunction(propertyName, mockFn);
                                    
                                    var method = function()
                                        {
                                            return mock.Call()
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, MockAction$2: function(T, expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParam$1(T))(propertyName, mockFn);
                                    
                                    var method = function(param)
                                        {
                                            return mock.Call(param)
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, MockAction$1: function(T, expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithOutput$1(T))(propertyName, mockFn);
                                    
                                    var method = function()
                                        {
                                            return mock.Call()
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, MockAction$3: function(T, TResult, expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParamAndOutput$2(T, TResult))(propertyName, mockFn);
                                    
                                    var method = function(param)
                                        {
                                            return mock.Call(param)
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, SetValue: function(T, expression, value)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, value)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, "SetValue", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.WHEN)
                        }, SetValue$1: function(T, expression, valueFunc)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$1$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, valueFunc, true)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$1(TController)))(action, "SetValue", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.WHEN)
                        }, CreateTestModel: function()
                        {
                            
                            var componentCreator = (Bridge.as(this, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest)).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService;
                            
                            var viewModel = componentCreator.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateModel(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel, this.ComponentUid);
                            
                            var model = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.ComponentTestModel$1(TController))(viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Context, viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller);
                            
                            return model
                        }, GetMethodInfo: function(expression)
                        {
                            var $t;
                            
                            var unaryExpression = ($t = expression.body, Bridge.cast($t, Bridge.hasValue($t) && ([4, 10, 11, 28, 29, 30, 34, 40, 44, 49, 54, 60, 62, 77, 78, 79, 80, 82, 83, 84].indexOf($t.ntype) >= 0)));
                            
                            var methodCallExpression = ($t = unaryExpression.operand, Bridge.as($t, Bridge.hasValue($t) && ($t.ntype === 6)));
                            
                            var methodInfoExpression = ($t = methodCallExpression.obj, Bridge.cast($t, Bridge.hasValue($t) && ($t.ntype === 9)));
                            
                            var methodInfo = Bridge.cast(methodInfoExpression.value, System.Reflection.MethodInfo);
                            
                            return methodInfo
                        }, GetPropertyName: function(target, prop)
                        {
                            
                            var name = null;
                            var keys = Object.getOwnPropertyNames(target);
                            for (var i = 0; i < keys.length; i++)
                            {
                                var propertyDescriptor = Object.getOwnPropertyDescriptor(target, keys[i]);
                                if (typeof propertyDescriptor.get === "function" && propertyDescriptor.get() === prop)
                                {
                                    name = keys[i]
                                }
                            }
                            
                            return name
                        }, MockProperty: function(target, propertyName, mock, computed)
                        {
                            if (computed === void 0)
                            {
                                computed = false
                            }
                            var attributes = {
                                    configurable: true, get: function()
                                        {
                                            return computed ? mock() : mock
                                        }
                                };
                            Object.defineProperty(target, propertyName, attributes)
                        }
                }
        }
});
Bridge.define("EleWise.ELMA.TestFramework.API.ComponentTest$3", EleWise_ELMA_TestFramework, function(TContext, TController, TServer)
{
    return {
            inherits: [EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.Test$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)), EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest], $metadata: function()
                {
                    return {
                            att: 1048705, a: 2, m: [{
                                        a: 3, isSynthetic: true, n: ".ctor", t: 1, sn: "ctor"
                                    }, {
                                        a: 1, n: "CreateTestModel", t: 8, sn: "CreateTestModel", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)
                                    }, {
                                        a: 1, n: "GetMethodInfo", t: 8, pi: [{
                                                    n: "expression", pt: System.Object, ps: 0
                                                }], sn: "GetMethodInfo", rt: System.Reflection.MethodInfo, p: [System.Object]
                                    }, {
                                        a: 1, n: "GetPropertyName", t: 8, pi: [{
                                                    n: "target", pt: System.Object, ps: 0
                                                }, {
                                                    n: "prop", pt: System.Object, ps: 1
                                                }], sn: "GetPropertyName", rt: System.String, p: [System.Object, System.Object]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], sn: "MockAction", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "MockAction$2", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "MockAction$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "MockAction", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], tpc: 2, tprm: ["T", "TResult"], sn: "MockAction$3", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 1, n: "MockProperty", t: 8, pi: [{
                                                    n: "target", pt: System.Object, ps: 0
                                                }, {
                                                    n: "propertyName", pt: System.String, ps: 1
                                                }, {
                                                    n: "mock", pt: System.Object, ps: 2
                                                }, {
                                                    n: "computed", dv: false, o: true, pt: System.Boolean, ps: 3
                                                }], sn: "MockProperty", rt: System.Void, p: [System.Object, System.String, System.Object, System.Boolean]
                                    }, {
                                        a: 2, n: "MockServer", t: 8, pi: [{
                                                    n: "expression", pt: System.Object, ps: 0
                                                }, {
                                                    n: "mockFn", pt: Function, ps: 1
                                                }], sn: "MockServer", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [System.Object, Function]
                                    }, {
                                        a: 2, n: "SetValue", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "valueFunc", pt: Function, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "SetValue$1", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, Function]
                                    }, {
                                        a: 2, n: "SetValue", t: 8, pi: [{
                                                    n: "expression", pt: Function, ps: 0
                                                }, {
                                                    n: "value", pt: System.Object, ps: 1
                                                }], tpc: 1, tprm: ["T"], sn: "SetValue", rt: EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.IStep, p: [Function, System.Object]
                                    }, {
                                        ab: true, a: 2, n: "ComponentUid", t: 16, rt: System.String, g: {
                                                ab: true, a: 2, n: "get_ComponentUid", t: 8, rt: System.String, fg: "ComponentUid"
                                            }, fn: "ComponentUid"
                                    }, {
                                        ov: true, a: 3, n: "Model", t: 16, rt: Function, g: {
                                                ov: true, a: 3, n: "get_Model", t: 8, rt: Function, fg: "Model"
                                            }, fn: "Model"
                                    }, {
                                        a: 1, backing: true, n: "<ComponentUid>k__BackingField", t: 4, rt: System.String, sn: "ComponentUid"
                                    }]
                        }
                }, $scope: EleWise_ELMA_TestFramework, $module: "EleWise_ELMA_TestFramework", fields: {EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService: null}, props: {Model: {get: function()
                        {
                            
                            return Bridge.fn.cacheBind(this, this.CreateTestModel)
                        }}}, methods: {
                    MockServer: function(expression, mockFn)
                    {
                        
                        var methodInfo = this.GetMethodInfo(expression);
                        
                        var methodName = methodInfo.n;
                        
                        var action = function(model)
                            {
                                
                                var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParam$1(TContext))(methodName, mockFn);
                                
                                var serverMethod = function()
                                    {
                                        return mock.Call(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"])
                                    };
                                
                                model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Controller"].EleWise_ELMA_Core$EleWise$ELMA$Core$Controllers$IClientController$Server[methodInfo.sn] = serverMethod
                            };
                        
                        return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, methodName, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                    }, MockAction: function(expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunction(propertyName, mockFn);
                                    
                                    var method = function()
                                        {
                                            return mock.Call()
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, MockAction$2: function(T, expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParam$1(T))(propertyName, mockFn);
                                    
                                    var method = function(param)
                                        {
                                            return mock.Call(param)
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, MockAction$1: function(T, expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithOutput$1(T))(propertyName, mockFn);
                                    
                                    var method = function()
                                        {
                                            return mock.Call()
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, MockAction$3: function(T, TResult, expression, mockFn)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var mock = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.Mocking.MockFunctionWithParamAndOutput$2(T, TResult))(propertyName, mockFn);
                                    
                                    var method = function(param)
                                        {
                                            return mock.Call(param)
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, method)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, "MockAction", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.MOCK)
                        }, SetValue: function(T, expression, value)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    var getter = function()
                                        {
                                            return value
                                        };
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, getter)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, "SetValue", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.WHEN)
                        }, SetValue$1: function(T, expression, valueFunc)
                        {
                            
                            var action = Bridge.fn.bind(this, function(model)
                                {
                                    
                                    var propertyName = this.GetPropertyName(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], expression(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"]));
                                    
                                    this.MockProperty(model["EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTestModel$2$" + Bridge.getTypeAlias(TContext) + "$" + Bridge.getTypeAlias(TController) + "$Context"], propertyName, valueFunc, true)
                                });
                            
                            return new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.TestStepWithParam$1(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTestModel$2(TContext, TController)))(action, "SetValue", EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.BDD.StepType.WHEN)
                        }, CreateTestModel: function()
                        {
                            
                            var componentCreator = (Bridge.as(this, EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.IComponentTest)).EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$API$IComponentTest$TestComponentCreatorService;
                            
                            var viewModel = componentCreator.EleWise_ELMA_TestFramework$EleWise$ELMA$TestFramework$Services$ITestComponentCreatorService$CreateModel(EleWise_ELMA_Core.EleWise.ELMA.Model.ViewModel.IComponentViewItemViewModel, this.ComponentUid);
                            
                            var model = new(EleWise_ELMA_TestFramework.EleWise.ELMA.TestFramework.API.ComponentTestModel$2(TContext, TController))(viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Context, viewModel.EleWise_ELMA_Core$EleWise$ELMA$Model$ViewModel$IViewModel$Controller);
                            
                            return model
                        }, GetMethodInfo: function(expression)
                        {
                            var $t;
                            
                            var unaryExpression = ($t = expression.body, Bridge.cast($t, Bridge.hasValue($t) && ([4, 10, 11, 28, 29, 30, 34, 40, 44, 49, 54, 60, 62, 77, 78, 79, 80, 82, 83, 84].indexOf($t.ntype) >= 0)));
                            
                            var methodCallExpression = ($t = unaryExpression.operand, Bridge.as($t, Bridge.hasValue($t) && ($t.ntype === 6)));
                            
                            var methodInfoExpression = ($t = methodCallExpression.obj, Bridge.cast($t, Bridge.hasValue($t) && ($t.ntype === 9)));
                            
                            var methodInfo = Bridge.cast(methodInfoExpression.value, System.Reflection.MethodInfo);
                            
                            return methodInfo
                        }, GetPropertyName: function(target, prop)
                        {
                            
                            var name = null;
                            var keys = Object.getOwnPropertyNames(target);
                            for (var i = 0; i < keys.length; i++)
                            {
                                var propertyDescriptor = Object.getOwnPropertyDescriptor(target, keys[i]);
                                if (typeof propertyDescriptor.get === "function" && propertyDescriptor.get() === prop)
                                {
                                    name = keys[i]
                                }
                            }
                            
                            return name
                        }, MockProperty: function(target, propertyName, mock, computed)
                        {
                            if (computed === void 0)
                            {
                                computed = false
                            }
                            var attributes = {
                                    configurable: true, get: function()
                                        {
                                            return computed ? mock() : mock
                                        }
                                };
                            Object.defineProperty(target, propertyName, attributes)
                        }
                }
        }
});
$asm.attr = [new EleWise_ELMA_Core.EleWise.ELMA.Core.ComponentModel.ComponentAssemblyAttribute];
$asm.$$typesToRegister = [{
        TypeName: "EleWise.ELMA.TestFramework.BDD.IBDDTest", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
    }, {
        TypeName: "EleWise.ELMA.TestFramework.BDD.Test", Constructor: {Arguments: []}, RegistrationType: 0, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.TestFramework.BDD.IBDDTest", Constructor: null, RegistrationType: 3, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.TestFramework.Core.TestRunner", Constructor: {Arguments: ["EleWise.ELMA.TestFramework.Services.ITestFactory"]}, RegistrationType: 1, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.TestFramework.Core.ITestRunner", Constructor: null, RegistrationType: 1, Order: 0, RegisterAs: []
                }]
    }, {
        TypeName: "EleWise.ELMA.TestFramework.TestController", Constructor: {Arguments: ["EleWise.ELMA.TestFramework.Core.ITestRunner", "EleWise.ELMA.Core.Model.Managers.ICurrentPageService", "EleWise.ELMA.Scripts.IScriptLoaderService", "EleWise.ELMA.Core.Services.INotificationService", "EleWise.ELMA.UI.Managers.ComponentMetadataItemManager", "EleWise.ELMA.Services.FindComponentService", "EleWise.ELMA.TestFramework.Services.ITestFactory"]}, RegistrationType: 1, Order: 0, RegisterAs: [{
                    TypeName: "EleWise.ELMA.TestFramework.ITestController", Constructor: null, RegistrationType: 1, Order: 0, RegisterAs: []
                }]
    }]
        Bridge.init();
        return EleWise_ELMA_TestFramework;
    }));

});

//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAiZmlsZSI6ICJFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5qcyIsCiAgInNvdXJjZVJvb3QiOiAiIiwKICAic291cmNlcyI6IFsiQXNzZXJ0LmNzIiwiSGVscGVycy9Qcm9taXNlLmNzIiwiQXR0cmlidXRlcy9JZ25vcmVBdHRyaWJ1dGUuY3MiLCJSZXN1bHRzL1Rlc3RTdWl0ZVJlc3VsdC5jcyIsIkF0dHJpYnV0ZXMvVGVzdEF0dHJpYnV0ZS5jcyIsIkJERC9UZXN0LmNzIiwiQVBJL0Jhc2VSZWFjdENvbXBvbmVudFRlc3RNb2RlbC5jcyIsIkFQSS9CYXNlVmlld0l0ZW1Db21wb25lbnRUZXN0TW9kZWwuY3MiLCJBUEkvQ29tcG9uZW50VGVzdE1vZGVsLmNzIiwiQkREL0JERFJ1bm5lci5jcyIsIkJERC9TY2VuYXJpby5jcyIsIkJERC9TY2VuYXJpb0J1aWxkZXIuY3MiLCJCREQvU3RlcC5jcyIsIkNvcmUvVGVzdEFzc2VtYmx5LmNzIiwiQ29yZS9UZXN0QXNzZW1ibHlCdWlsZGVyLmNzIiwiQ29yZS9UZXN0Q29udGV4dC5jcyIsIkNvcmUvVGVzdEZpeHR1cmUuY3MiLCJDb3JlL1Rlc3RNZXRob2QuY3MiLCJDb3JlL1Rlc3RSdW5uZXIuY3MiLCJNb2NraW5nL01vY2suY3MiLCJSZXN1bHRzL1NjZW5hcmlvUmVzdWx0LmNzIiwiUmVzdWx0cy9TdGVwUmVzdWx0LmNzIiwiUmVzdWx0cy9UZXN0Rml4dHVyZVJlc3VsdC5jcyIsIlJlc3VsdHMvVGVzdFJlc3VsdC5jcyIsIlNlcnZpY2VzL1Rlc3RGYWN0b3J5LmNzIiwiVGVzdENvbnRyb2xsZXIuY3MiLCJNb2NraW5nL01vY2tGdW5jdGlvbi5jcyIsIk1vY2tpbmcvTW9ja0Z1bmN0aW9uV2l0aE91dHB1dC5jcyIsIk1vY2tpbmcvTW9ja0Z1bmN0aW9uV2l0aFBhcmFtLmNzIiwiTW9ja2luZy9Nb2NrRnVuY3Rpb25XaXRoUGFyYW1BbmRPdXRwdXQuY3MiLCJBUEkvQmFzZVJlYWN0Q29tcG9uZW50VGVzdC5jcyIsIkFQSS9CYXNlVmlld0l0ZW1Db21wb25lbnRUZXN0LmNzIiwiQVBJL0NvbXBvbmVudFRlc3QuY3MiXSwKICAibmFtZXMiOiBbIiJdLAogICJtYXBwaW5ncyI6ICI7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O3dCQWFrQkE7Ozs7Ozs7Ozt3QkFXTkE7Ozs7Ozs7OzRCQVdBQTs7Ozs7Ozs7NEJBV0FBOzs7Ozs7Ozs0QkFXQUE7Ozs7Ozs7OzRCQVVBQTs7Ozs7Ozs7NEJBVUFBOzs7Ozs7Ozs0QkFVQUE7Ozs7Ozs7OzRCQVdBQTs7Ozs7Ozs7NEJBV0FBOzs7Ozs7Ozs0QkFVQUE7Ozs7Ozs7OzRCQVVBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkM1RkFBOzs7NEJBRUlBOzs0QkFFQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7NERBSVFBOzs7Ozs7Ozs7Ozs0REFDQUE7Ozs7Ozs7NERBSUFBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OzRCQUlSQTs7Ozs7Ozs7Z0JBaENKQTs7Z0JBRUFBOzs7Ozs7Ozs7Ozs7O2dCQXFDQUE7Ozs7Ozs7O29CQU1BQTs7Ozs7Ozs7b0JBTUFBOzs7Ozs7OztvQkFNQUE7O29CQUNBQTs7O3dCQUVJQTs7d0JBRUFBOzs7NEJBRUlBOzs7d0JBR0pBOzs7Ozs7Ozs7b0JBTUpBOzs7d0JBRUlBOzs7NEJBQXdCQTs7Ozs7O3dCQUl4QkE7Ozs0QkFBd0JBOzs7O29CQUc1QkE7O29CQUNBQTs7O3dCQUVJQTs7d0JBRUFBOzs7NEJBRUlBOzs7Z0NBRUlBOzs7Ozs7NEJBS0pBOzs7Z0NBRUlBOzs7O3dCQUlSQTs7OzRCQUVJQTs7O3dCQUdKQTs7O29CQUdKQTs7Ozs7Ozs7O1FBMUdJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQ0xKQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDTEFBOztnQkFDQUE7O2dCQUNBQTs7Ozs7Z0JBeUZBQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUNBQTs7Z0JBQ0FBOztnQkFDQUE7Ozs7b0JBU0FBOztvQkFDQUE7O29CQUVBQTs7b0JBQ0FBOzs7d0JBRUlBOzs7Ozt3QkFJQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JDekdBQTs7Ozt3QkFJQUE7Ozs7O3dCQVdSQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQ3RCSUE7O2dCQUNBQTs7OztvQkFXQUE7Ozs7b0JBV0FBOzs7O29CQVdBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0JDdkNBQTs7d0JBQ0FBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3QkNNQUE7O3dCQUNBQTs7d0JBQ0FBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0JDTUFBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7d0JBbkJBQTs7d0JBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQ0tBQTs7Z0JBS0FBOztnQkFDQUE7O2dCQUNBQTs7O2dCQUdBQTs7Z0JBR0FBOztnQkFDQUE7OztvQkFFSUE7Ozs7OztvQkFJQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFDQUE7Ozs7O29CQUlBQTs7Ozs7Ozs7Ozs7b0JBWUpBOztvQkFLQUE7O29CQUNBQTs7O29CQUdBQTs7b0JBR0FBOztvQkFFQUE7Ozt3QkFFSUE7O3dCQUNBQTs7Ozs7O3dCQUlBQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNBQTs7Ozs7d0JBSUFBOzs7OztvQkFLWkE7Ozs7b0JBSVFBOztvQkFDQUE7O29CQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkN4RUFBOztnQkFDQUE7Ozs7O2dCQVNBQTs7Z0JBQ0FBOztnQkFLQUE7O2dCQUNBQTs7O29CQUVJQTs7b0JBQ0FBOztvQkFDaEJBOztvQkFDZ0JBOzs7d0JBRUlBOzt3QkFHQUE7O3dCQUdBQTs7d0JBUUFBOzs7NEJBRUlBOzs7Ozs7NEJBSUFBOzs0QkFDQUE7OzRCQUNBQTs7NEJBQ0FBOzs7Ozs0QkFJQUE7OzRCQUNBQTs7Ozs7O3dCQUtKQTs7OztnQkFJUkE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDckVBQTs7Z0JBQ0FBOzs7Ozs7OztvQkFVQUE7O29CQUNBQTs7OztvQkFTQUE7O29CQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkNwQkFBOztnQkFDQUE7O2dCQUNBQTs7OztnQkFtQkFBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O3dCQW1CQUE7O3dCQUNBQTs7d0JBQ0FBOzs7O3dCQW1CQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDbEVBQTs7Z0JBQ0FBOztnQkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDSUFBOztnQkFFQUE7O2dCQUVBQTs7Ozs7Ozt3QkFFSUE7O3dCQUNBQTs7OzRCQUVJQTs7O3dCQUdKQTs7OzRCQUVJQTs7NEJBQ0FBOzs7Ozs7Ozs7Ozs7Z0JBSVJBOzs7O29CQVVBQTs7b0JBRUFBOztvQkFDQUE7O29CQUNBQTs7b0JBRUFBOzs7OztvQkFLQUE7O29CQUVBQTs7Ozs7Ozs0QkFFSUE7OzRCQUNBQTs7O2dDQUVJQTs7Z0NBQ0FBOzs7Ozs7Ozs7Ozs7b0JBSVJBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDMUJBQTs7O29CQUVJQTs7O2dCQUVKQTs7OztvQkFNQUE7O29CQUNBQTs7b0JBQ0FBOzs7d0JBRUlBOzt3QkFDQUE7Ozs0QkFFSUE7OzRCQUNwQkE7Ozs7b0JBR1lBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CQzlDQUE7O29CQUNBQTs7b0JBQ0FBOzs7Ozs7Z0JBcUNBQTs7Z0JBQ0FBOzs7b0JBRUlBOztvQkFDQUE7OztnQkFHSkE7O2dCQUNBQTs7Z0JBQ0FBOzs7Ozs7O3dCQUVJQTs7OzRCQUVJQTs7O3dCQUdKQTs7OzRCQUVJQTs7O3dCQUdKQTs7d0JBQ0FBOzs7NEJBRUlBOzs0QkFDQUE7OzRCQUNBQTs7O2dDQUVJQTs7Z0NBQ0FBOzs7NEJBRUpBOzs7Ozs7Ozs7Ozs7Z0JBSVJBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvQkM1REFBOztvQkFDQUE7O29CQUNBQTs7b0JBQ0FBOztvQkFFQUE7Ozt3QkFFSUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDakJKQTs7Ozs7O2dCQU1BQTs7Ozs7Ozt3QkFFSUE7Ozs7Ozs7Ozs7Ozs7b0JBT0pBOzs7OztvQkFNQUE7Ozs7Ozs7NEJBRUlBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JBT0pBOztvQkFFQUE7O29CQUNBQTs7b0JBRUFBOzs7d0JBRUlBOzt3QkFDQUE7O3dCQUNBQTs7d0JBQ0FBOzs7b0JBR0pBOzs7O3dCQUVJQTs7d0JBRUFBOzs7Ozs7O2dDQUVJQTs7O29DQUVJQTs7Ozs7Ozs7Ozs7Ozs7O29CQVNaQTs7O3dCQUVJQTs7d0JBQ0FBOzs7b0JBR0pBOzs7d0JBRUlBOzt3QkFDQUE7O3dCQUNBQTs7d0JBQ0FBOzs7Ozt3QkFFQUE7Ozs0QkFFSUE7Ozt3QkFHSkE7O3dCQUVBQTs7d0JBRUFBOzs7OztvQkFNSkE7Ozt3QkFFSUE7O3dCQUNBQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNBQTs7Ozs7b0JBTUpBOzs7OztnQ0FJUUE7Ozs7O29DQUlBQTs7OztvQkFJUkE7Ozt3QkFFSUE7Ozs0QkFFSUE7OzRCQUNBQTs7NEJBQ0FBOzs7Ozs7d0JBS0pBOzs7NEJBQWdDQTs7OztvQkFHcENBOzs7O29CQUtBQTs7b0JBQ0FBOztvQkFDQUE7Ozs7b0JBS0FBOztvQkFDQUE7O29CQUNBQTs7b0JBQ0FBOzs7O29CQUtaQTs7b0JBR1lBOztvQkFRQUE7O29CQUlaQTs7b0JBT1lBOzs7O3dCQUVJQTs7d0JBQ0FBOzt3QkFDQUE7O3dCQUNBQTs7O29CQUdKQTs7b0JBVUFBOzs7O3dCQUVaQTs7d0JBQWtDQTs7OzRCQUVkQTs7NEJBQ0FBOzs0QkFDQUE7Ozs7b0JBSVJBOztvQkFtQkFBOzs7Ozs7Ozs7OztRQWhFSUE7Ozs7OztZQVFBQTs7OztZQUlaQTs7Ozs7O1lBZVlBOztZQUNBQTs7Ozs7WUFtQkFBOzs7OztZQW1CQUE7O1lBQ0FBOzs7Z0JBRUlBOztnQkFDQUE7O2dCQUNBQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JDM09SQTs7Ozs7Ozs7OztnQkFjQUE7Ozs7b0JBUUFBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDckJBQTs7Z0JBQ0FBOztnQkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQ0RBQTs7Z0JBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDSEFBOztnQkFDQUE7O2dCQUNBQTs7Z0JBRUFBOzs7b0JBRUlBOztvQkFDQUE7OztnQkFHSkE7Ozs7Ozs7d0JBRUlBOzs7NEJBRUlBOzs0QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Z0JDZlJBOztnQkFDQUE7O2dCQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQkNZQUE7O2dCQUNBQTs7Ozs7Z0JBVUFBOzs7O29CQVVBQTs7O3dCQUVJQTs7O29CQUdKQTs7O3dCQUVJQTs7d0JBQ0FBOzt3QkFDQUE7OztvQkFHSkE7O29CQUNBQTs7O3dCQUVJQTs7d0JBQ0FBOzs7NEJBRUlBOzs7Ozs0QkFJQUE7OzRCQUNBQTs7NEJBQ0FBOzs0QkFDQUE7OztnQ0FFSUE7Ozs7d0JBSVJBOzs7NEJBRUlBOzs0QkFDQUE7Ozt3QkFFcEJBOzt3QkFDZ0JBOzs7NEJBRUlBOzs7d0JBR0pBOzs7Ozs7d0JBSUFBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dCQzNCSkE7O2dCQUNBQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUNBQTs7Z0JBQ0FBOztnQkFDQUE7O2dCQUVBQTs7Z0JBQ0FBOzs7OztnQkFZQUE7O2dCQUNBQTs7Z0JBQ0FBOztnQkFDQUE7OztvQkFFSUE7OztnQkFHSkE7O2dCQUNBQTs7O29CQUVJQTs7O2dCQUdKQTs7Z0JBQ0FBOzs7b0JBRUlBOzs7Z0JBR0pBOztnQkFDQUE7OztvQkFFSUE7OztnQkFHSkE7O2dCQUNBQTs7O29CQUVJQTs7b0JBQ0FBOzs7Z0JBR0pBOzs7OztvQkFzREFBOzs7d0JBRUlBOzs7b0JBR0pBOzs7Ozs7OzRCQUVJQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztvRUFFUUE7Ozs7Ozs7Ozs7O29FQU9BQTs7Ozs7Ozs7Ozs7O29FQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29CQUtaQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnREF0RUFBOzs7Ozs7Ozs7Ozs7Z0RBQ0FBOztnREFDQUE7O2dEQUNBQTs7Z0RBRUFBOztnREFFQUE7Ozs7Ozs7Ozs7Ozs7Ozs7OztnREFFSUE7O2dEQUNBQTs7Ozs7Ozs7Ozs7O2dEQUNBQTs7O29EQUVJQTs7OztnREFHSkE7O2dEQUNBQTs7Z0RBQ0FBOzs7b0RBRUlBOzs7O2dEQUdKQTs7Z0RBQ0FBOztnREFDQUE7Ozs7Ozs7Z0RBT0pBOztnREFRQUE7O2dEQUVBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7b0JBb0NBQTs7b0JBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O2dEQUtBQTs7Ozs7Ozs7Ozs7O2dEQUVBQTs7O29EQUVJQTs7OztnREFHSkE7O2dEQUNBQTs7O29EQUVJQTs7OztnREFHSkE7O2dEQUNBQTs7Z0RBRUFBOzs7b0RBRUlBOzs7O2dEQUdKQTs7Z0RBQ0FBOzs7b0RBRUlBOzs7O2dEQUdKQTs7Z0RBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3QnBCdktBQTs7OzRCQUVJQTs7O3dCQUdKQTs7d0JBQ0FBOzs7OzRCQVdBQTs7Ozs0QkFXQUE7Ozs7NEJBV0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztnQnFCL0ZBQTs7OztnQkFRQUE7O2dCQUNBQTs7Z0JBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3QkNUQUE7Ozs7d0JBU0FBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O3dCQ1ZBQTs7Ozt3QkFTQUE7O3dCQUNBQTs7d0JBQ0FBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozt3QkNWQUE7Ozs7d0JBVUFBOzt3QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs0QkNzQkpBOzs7Ozs7Ozs7d0JBZElBOzs7NEJBRUlBOzs7d0JBR0pBOzs7OzRCQW1CQUE7OzRCQUNBQTs7NEJBQ0FBOzs0QkFDQUE7Ozs7NEJBS0FBOzs0QkFDQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29EQUt5QkE7Ozt3REFFckJBOzs7b0RBR0pBOzs7d0RBRUlBOzs7b0RBR0pBOzs7Ozs7Ozs7OztvREFFSUE7O29EQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztRQW5CaUJBOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OzRCQ2Z6QkE7Ozs7Ozs7Ozt3QkFkSUE7Ozs0QkFFSUE7Ozt3QkFHSkE7Ozs7NEJBbUJBQTs7NEJBQ0FBOzs0QkFFQUE7OzRCQU9BQTs7Ozs0QkFLQUE7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O29EQUt5QkE7Ozt3REFFckJBOzs7b0RBR0pBOzs7d0RBRUlBOzs7b0RBR0pBOzs7Ozs7Ozs7OztvREFFSUE7O29EQUNBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7NEJDdVJSQTs7Ozs7d0JBcklJQTs7d0JBQ0FBOzt3QkFFQUE7OztnQ0FFSUE7O2dDQUNBQTs7Ozs7Z0NBQ0FBOzs7d0JBR0pBOzs7OzRCQVdBQTs7O29DQUVJQTs7b0NBQ0FBOztvQ0FDQUE7Ozs7O29DQUNBQTs7OzRCQUdKQTs7Ozs0QkFXQUE7OztvQ0FFSUE7O29DQUNBQTs7b0NBQ0FBOzs7OztvQ0FDQUE7Ozs0QkFFSkE7Ozs7NEJBV0FBOzs7b0NBRUlBOztvQ0FDQUE7O29DQUNBQTs7Ozs7b0NBQ0FBOzs7NEJBRUpBOzs7OzRCQVdBQTs7O29DQUVJQTs7b0NBQ0FBOztvQ0FDQUE7Ozs7O29DQUNBQTs7OzRCQUVKQTs7Ozs0QkFjQUE7OztvQ0FFSUE7O29DQUNBQTs7OzRCQUVKQTs7Ozs0QkFZQUE7OztvQ0FFSUE7O29DQUNBQTs7OzRCQUVKQTs7Ozs0QkFtQkFBOzs0QkFDQUE7OzRCQUNBQTs7NEJBQ0FBOzs7Ozs0QkFLQUE7OzRCQUNBQTs7NEJBQ0FBOzs0QkFDQUE7OzRCQUNBQTs7Ozs0QkFLQUE7Ozs7Ozs7Ozs7OzRCQVdBQTs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OzRCQWpQSkE7Ozs7O3dCQXJJSUE7O3dCQUNBQTs7d0JBRUFBOzs7Z0NBRUlBOztnQ0FDQUE7Ozs7O2dDQUNBQTs7O3dCQUdKQTs7Ozs0QkFXQUE7OztvQ0FFSUE7O29DQUNBQTs7b0NBQ0FBOzs7OztvQ0FDQUE7Ozs0QkFFSkE7Ozs7NEJBV0FBOzs7b0NBRUlBOztvQ0FDQUE7O29DQUNBQTs7Ozs7b0NBQ0FBOzs7NEJBRUpBOzs7OzRCQVdBQTs7O29DQUVJQTs7b0NBQ0FBOztvQ0FDQUE7Ozs7O29DQUNBQTs7OzRCQUVKQTs7Ozs0QkFXQUE7OztvQ0FFSUE7O29DQUNBQTs7b0NBQ0FBOzs7OztvQ0FDQUE7Ozs0QkFFSkE7Ozs7NEJBY0FBOzs7b0NBRUlBOztvQ0FDQUE7Ozs7O29DQUNBQTs7OzRCQUVKQTs7Ozs0QkFZQUE7OztvQ0FFSUE7O29DQUNBQTs7OzRCQUVKQTs7Ozs0QkFtQkFBOzs0QkFDQUE7OzRCQUNBQTs7NEJBQ0FBOzs7Ozs0QkFLQUE7OzRCQUNBQTs7NEJBQ0FBOzs0QkFDQUE7OzRCQUNBQTs7Ozs0QkFLQUE7Ozs7Ozs7Ozs7OzRCQVdBQSIsCiAgInNvdXJjZXNDb250ZW50IjogWyJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkNvcmU7XHJcbnVzaW5nIFFVbml0QXNzZXJ0ID0gQnJpZGdlLlFVbml0LkFzc2VydDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29ya1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JrQu9Cw0YHRgSwg0L/RgNC10LTQvtGB0YLQsNCy0LvRj9GO0YnQuNC5INC80LXRgtC+0LTRiyDQtNC70Y8g0L/RgNC+0LLQtdGA0LrQuCDRg9GB0LvQvtCy0LjQuSDQstC90YPRgtGA0Lgg0YLQtdGB0YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBzZWFsZWQgY2xhc3MgQXNzZXJ0XHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSBzdGF0aWMgRnVuYzxRVW5pdEFzc2VydD4gYXNzZXJ0XHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBnZXQgeyByZXR1cm4gVGVzdENvbnRleHQuQ3VycmVudC5Bc3NlcnQ7IH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/RgNC+0LLQtdGA0Y/QtdGCINC30L3QsNGH0LXQvdC40Y8g0L3QsCDRgNCw0LLQtdC90YHRgtCy0L5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdHVhbFwiPtCk0LDQutGC0LjRh9C10YHQutC+0LUg0LfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwZWN0ZWRcIj7QntC20LjQtNCw0LXQvNC+0LUg0LfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWVzc2FnZVwiPtCh0L7QvtCx0YnQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIEVxdWFsKG9iamVjdCBhY3R1YWwsIG9iamVjdCBleHBlY3RlZCwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYXNzZXJ0KCkuU3RyaWN0RXF1YWwoYWN0dWFsLCBleHBlY3RlZCwgbWVzc2FnZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0YDQvtCy0LXRgNGP0LXRgiwg0YfRgtC+INC30L3QsNGH0LXQvdC40Y8g0L3QtSDRgNCw0LLQvdGLINC00YDRg9CzINC00YDRg9Cz0YNcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdHVhbFwiPtCk0LDQutGC0LjRh9C10YHQutC+0LUg0LfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwZWN0ZWRcIj7QntC20LjQtNCw0LXQvNC+0LUg0LfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWVzc2FnZVwiPtCh0L7QvtCx0YnQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIE5vdEVxdWFsKG9iamVjdCBhY3R1YWwsIG9iamVjdCBleHBlY3RlZCwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYXNzZXJ0KCkuTm90U3RyaWN0RXF1YWwoYWN0dWFsLCBleHBlY3RlZCwgbWVzc2FnZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCh0YDQsNCy0L3QuNCy0LDQtdGCINC30L3QsNGH0LXQvdC40Y8g0YEg0YPRh9C10YLQvtC8INC40YUg0YHQstC+0LnRgdGC0LJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdHVhbFwiPtCk0LDQutGC0LjRh9C10YHQutC+0LUg0LfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwZWN0ZWRcIj7QntC20LjQtNCw0LXQvNC+0LUg0LfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWVzc2FnZVwiPtCh0L7QvtCx0YnQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIERlZXBFcXVhbChvYmplY3QgYWN0dWFsLCBvYmplY3QgZXhwZWN0ZWQsIHN0cmluZyBtZXNzYWdlID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGFzc2VydCgpLkRlZXBFcXVhbChhY3R1YWwsIGV4cGVjdGVkLCBtZXNzYWdlKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/RgNC+0LLQtdGA0Y/QtdGCLCDRh9GC0L4g0LfQvdCw0YfQtdC90LjRjyDQvdC1INGA0LDQstC90Ysg0LTRgNGD0LMg0LTRgNGD0LPRgyDRgSDRg9GH0LXRgtC+0Lwg0LjRhSDRgdCy0L7QudGB0YLQslxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYWN0dWFsXCI+0KTQsNC60YLQuNGH0LXRgdC60L7QtSDQt9C90LDRh9C10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHBlY3RlZFwiPtCe0LbQuNC00LDQtdC80L7QtSDQt9C90LDRh9C10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXNzYWdlXCI+0KHQvtC+0LHRidC10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIHZvaWQgTm90RGVlcEVxdWFsKG9iamVjdCBhY3R1YWwsIG9iamVjdCBleHBlY3RlZCwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYXNzZXJ0KCkuTm90RGVlcEVxdWFsKGFjdHVhbCwgZXhwZWN0ZWQsIG1lc3NhZ2UpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9GA0L7QstC10YDRj9C10YIsINGH0YLQviDQt9C90LDRh9C10L3QuNC1INGA0LDQstC90L4gdHJ1ZVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYWN0dWFsXCI+0JfQvdCw0YfQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWVzc2FnZVwiPtCh0L7QvtCx0YnQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIFRydWUob2JqZWN0IGFjdHVhbCwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgRXF1YWwoYWN0dWFsLCB0cnVlLCBtZXNzYWdlKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/RgNC+0LLQtdGA0Y/QtdGCLCDRh9GC0L4g0LfQvdCw0YfQtdC90LjQtSDRgNCw0LLQvdC+IGZhbHNlXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJhY3R1YWxcIj7Ql9C90LDRh9C10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXNzYWdlXCI+0KHQvtC+0LHRidC10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIHZvaWQgRmFsc2Uob2JqZWN0IGFjdHVhbCwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgRXF1YWwoYWN0dWFsLCBmYWxzZSwgbWVzc2FnZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0YDQvtCy0LXRgNGP0LXRgiwg0YfRgtC+INC/0LXRgNC10LTQsNC90L3Ri9C5INC80LXRgtC+0LQg0LLRi9Cx0YDQsNGB0YvQstCw0LXRgiDQuNGB0LrQu9GO0YfQtdC90LjQtSDQv9GA0Lgg0LLRi9C/0L7Qu9C90LXQvdC40LhcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdGlvblwiPtCc0LXRgtC+0LQ8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1lc3NhZ2VcIj7QodC+0L7QsdGJ0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBzdGF0aWMgdm9pZCBUaHJvd3MoQWN0aW9uIGFjdGlvbiwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYXNzZXJ0KCkuVGhyb3dzKChBY3Rpb24pYWN0aW9uLCBtZXNzYWdlKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/RgNC+0LLQtdGA0Y/QtdGCLCDRh9GC0L4g0L/QtdGA0LXQtNCw0L3QvdGL0Lkg0LzQtdGC0L7QtCDQstGL0LHRgNCw0YHRi9Cy0LDQtdGCINC+0LbQuNC00LDQtdC80L7QtSDQuNGB0LrQu9GO0YfQtdC90LjQtVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYWN0aW9uXCI+0JzQtdGC0L7QtDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwZWN0ZWRcIj7QntC20LjQtNCw0LXQvNCw0Y8g0L7RiNC40LHQutCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXNzYWdlXCI+0KHQvtC+0LHRidC10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIHZvaWQgVGhyb3dzKEFjdGlvbiBhY3Rpb24sIG9iamVjdCBleHBlY3RlZCwgc3RyaW5nIG1lc3NhZ2UgPSBudWxsKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYXNzZXJ0KCkuVGhyb3dzKChBY3Rpb24pYWN0aW9uLCBleHBlY3RlZCwgbWVzc2FnZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0YDQvtCy0LXRgNGP0LXRgiwg0YfRgtC+INC/0LXRgNC10LTQsNC90L3Ri9C5INC80LXRgtC+0LQg0LLRi9Cx0YDQsNGB0YvQstCw0LXRgiDQvtC20LjQtNCw0LXQvNC+0LUg0LjRgdC60LvRjtGH0LXQvdC40LVcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdGlvblwiPtCc0LXRgtC+0LQ8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImV4cGVjdGVkXCI+0KTRg9C90LrRhtC40Y8g0L/RgNC+0LLQtdGA0LrQuCwg0LTQvtC70LbQvdCwINCy0LXRgNC90YPRgtGMIHRydWUsINGH0YLQvtCx0Ysg0YLQtdGB0YIg0YHRh9C40YLQsNC70YHRjyDQv9GA0L7QudC00LXQvdC90YvQvDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibWVzc2FnZVwiPtCh0L7QvtCx0YnQtdC90LjQtTwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIFRocm93cyhBY3Rpb24gYWN0aW9uLCBGdW5jPG9iamVjdCwgYm9vbD4gZXhwZWN0ZWQsIHN0cmluZyBtZXNzYWdlID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGFzc2VydCgpLlRocm93cygoQWN0aW9uKWFjdGlvbiwgKEZ1bmM8b2JqZWN0LGJvb2w+KWV4cGVjdGVkLCBtZXNzYWdlKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/RgNC+0LLQtdGA0Y/QtdGCLCDRh9GC0L4g0L/QtdGA0LXQtNCw0L3QvdC+0LUg0LfQvdCw0YfQtdC90LjQtSDRgNCw0LLQvdC+IG51bGxcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdHVhbFwiPtCX0L3QsNGH0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1lc3NhZ2VcIj7QodC+0L7QsdGJ0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBzdGF0aWMgdm9pZCBOdWxsKG9iamVjdCBhY3R1YWwsIHN0cmluZyBtZXNzYWdlID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGFzc2VydCgpLkVxdWFsKGFjdHVhbCwgbnVsbCwgbWVzc2FnZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0YDQvtCy0LXRgNGP0LXRgiwg0YfRgtC+INC/0LXRgNC10LTQsNC90L3QvtC1INC30L3QsNGH0LXQvdC40LUg0L3QtSDRgNCw0LLQvdC+IG51bGxcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdHVhbFwiPtCX0L3QsNGH0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1lc3NhZ2VcIj7QodC+0L7QsdGJ0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBzdGF0aWMgdm9pZCBOb3ROdWxsKG9iamVjdCBhY3R1YWwsIHN0cmluZyBtZXNzYWdlID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGFzc2VydCgpLk5vdEVxdWFsKGFjdHVhbCwgbnVsbCwgbWVzc2FnZSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7XHJcbnVzaW5nIFN5c3RlbS5UaHJlYWRpbmcuVGFza3M7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuSGVscGVyc1xyXG57XHJcbiAgICAvLyBUT0RPOiDQo9C00LDQu9C40YLRjCDQv9C+0YHQu9C1INCy0YvQv9C+0LvQvdC10L3QuNGPIEVMTUE0LTM1MDJcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQoNC10LDQu9C40LfQsNGG0LjRjyDQv9GA0L7QvNC40YHQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBQcm9taXNlIDogSVByb21pc2VcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIGRlbGVnYXRlIHZvaWQgUHJvbWlzZURlbGVnYXRlKHBhcmFtcyBvYmplY3RbXSBhcmdzKTtcclxuICAgICAgICBwcml2YXRlIGRlbGVnYXRlIHZvaWQgTmV4dChQcm9taXNlRGVsZWdhdGUgZnVsZmlsbGVkSGFuZGxlciwgUHJvbWlzZURlbGVnYXRlIGVycm9ySGFuZGxlciA9IG51bGwsIFByb21pc2VEZWxlZ2F0ZSBwcm9ncmVzc0hhbmRsZXIgPSBudWxsKTtcclxuICAgICAgICBwcml2YXRlIE5leHQgZG9UaGVuO1xyXG4gICAgICAgIHByaXZhdGUgTGlzdDxIYW5kbGVyPiB0aGVucztcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgUHJvbWlzZSgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB0aGVucyA9IG5ldyBMaXN0PEhhbmRsZXI+KCk7XHJcblxyXG4gICAgICAgICAgICBkb1RoZW4gPSAoZiwgZSwgcCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdGhlbnMuQWRkKG5ldyBIYW5kbGVyKCkgeyBGaWxsZWQgPSBmLCBFcnJvciA9IGUsIFByb2dyZXNzID0gcCB9KTtcclxuICAgICAgICAgICAgfTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J7QsdC10YDQvdGD0YLRjCDRhNGD0L3QutGG0LjRjlxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYXN5bmNGdW5jXCI+0JDRgdC40L3RhdGA0L7QvdC90LDRjyDRhNGD0L3QutGG0LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCf0YDQvtC80LjRgTwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIEZ1bmM8UHJvbWlzZT4gUHJvbWlzaWZ5KEZ1bmM8VGFzaz4gYXN5bmNGdW5jKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBGdW5jPFByb21pc2U+KCgpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBwcm9taXNlID0gbmV3IFByb21pc2UoKTtcclxuXHJcbiAgICAgICAgICAgICAgICBuZXcgRnVuYzxUYXNrPihhc3luYyAoKSA9PlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHRyeVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgYXdhaXQgYXN5bmNGdW5jKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHByb21pc2UuUmVzb2x2ZSgpO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgICAgICBjYXRjaCAoRXhjZXB0aW9uIGV4KVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgcHJvbWlzZS5SZWplY3QoZXgpO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIH0pKCk7XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHByb21pc2U7XHJcbiAgICAgICAgICAgIH0pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBUaGVuKERlbGVnYXRlIGZ1bGZpbGxlZEhhbmRsZXIsIERlbGVnYXRlIGVycm9ySGFuZGxlciA9IG51bGwsIERlbGVnYXRlIHByb2dyZXNzSGFuZGxlciA9IG51bGwpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBkb1RoZW4oKFByb21pc2VEZWxlZ2F0ZSlmdWxmaWxsZWRIYW5kbGVyLCAoUHJvbWlzZURlbGVnYXRlKWVycm9ySGFuZGxlciwgKFByb21pc2VEZWxlZ2F0ZSlwcm9ncmVzc0hhbmRsZXIpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBSZXNvbHZlKHBhcmFtcyBvYmplY3RbXSBhcmdzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQ29tcGxldGUoV2hpY2guUmVzb2x2ZSwgYXJncyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFJlamVjdChwYXJhbXMgb2JqZWN0W10gYXJncylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIENvbXBsZXRlKFdoaWNoLlJlamVjdCwgYXJncyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFByb2dyZXNzKHBhcmFtcyBvYmplY3RbXSBhcmdzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGkgPSAwO1xyXG4gICAgICAgICAgICB3aGlsZSAoaSA8IHRoZW5zLkNvdW50KVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgYVRoZW4gPSB0aGVuc1tpXTtcclxuXHJcbiAgICAgICAgICAgICAgICBpZiAoYVRoZW4uUHJvZ3Jlc3MgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBhVGhlbi5Qcm9ncmVzcyhhcmdzKTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBpKys7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgdm9pZCBDb21wbGV0ZShXaGljaCB3aGljaCwgcGFyYW1zIG9iamVjdFtdIGFyZ3MpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAod2hpY2ggPT0gV2hpY2guUmVzb2x2ZSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgZG9UaGVuID0gKGYsIGUsIHApID0+IHsgUmVzb2x2ZShhcmdzKTsgfTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGRvVGhlbiA9IChmLCBlLCBwKSA9PiB7IFJlamVjdChhcmdzKTsgfTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIGkgPSAwO1xyXG4gICAgICAgICAgICB3aGlsZSAoaSA8IHRoZW5zLkNvdW50KVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgYVRoZW4gPSB0aGVuc1tpXTtcclxuXHJcbiAgICAgICAgICAgICAgICBpZiAod2hpY2ggPT0gV2hpY2guUmVzb2x2ZSlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBpZiAoYVRoZW4uRmlsbGVkICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBhVGhlbi5GaWxsZWQuQXBwbHkobnVsbCwgYXJncyk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgZWxzZVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGlmIChhVGhlbi5FcnJvciAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgYVRoZW4uRXJyb3IuQXBwbHkobnVsbCwgYXJncyk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIGlmIChhVGhlbi5Qcm9ncmVzcyAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGFUaGVuLlByb2dyZXNzKDEwMCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgaSsrO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB0aGVucy5DbGVhcigpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBjbGFzcyBIYW5kbGVyXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBwdWJsaWMgUHJvbWlzZURlbGVnYXRlIEZpbGxlZFxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBnZXQ7IHNldDtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcHVibGljIFByb21pc2VEZWxlZ2F0ZSBFcnJvclxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBnZXQ7IHNldDtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBwdWJsaWMgUHJvbWlzZURlbGVnYXRlIFByb2dyZXNzXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGdldDsgc2V0O1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIGVudW0gV2hpY2hcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIFJlc29sdmUsIFJlamVjdFxyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmtcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCf0L7QvNC10YfQsNC10YIg0YLQtdGB0YLQvtCy0YvQuSDQvNC10YLQvtC0INC40LvQuCDQutC70LDRgdGBINC60LDQuiDQuNCz0L3QvtGA0LjRgNGD0LXQvNGL0LlcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBbQXR0cmlidXRlVXNhZ2UoQXR0cmlidXRlVGFyZ2V0cy5NZXRob2QgfCBBdHRyaWJ1dGVUYXJnZXRzLkNsYXNzLCBBbGxvd011bHRpcGxlID0gZmFsc2UsIEluaGVyaXRlZCA9IGZhbHNlKV1cclxuICAgIHB1YmxpYyBjbGFzcyBJZ25vcmVBdHRyaWJ1dGUgOiBBdHRyaWJ1dGVcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0YDQuNGH0LjQvdCwINC/0YDQvtC/0YPRgdC60LAg0YLQtdGB0YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBSZWFzb24geyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/QvtC80LXRh9Cw0LXRgiDRgtC10YHRgtC+0LLRi9C5INC80LXRgtC+0LQg0LjQu9C4INC60LvQsNGB0YEg0LrQsNC6INC40LPQvdC+0YDQuNGA0YPQtdC80YvQuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwicmVhc29uXCI+0J/RgNC40YfQuNC90LAg0L/RgNC+0L/Rg9GB0LrQsDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIElnbm9yZUF0dHJpYnV0ZShzdHJpbmcgcmVhc29uKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgUmVhc29uID0gcmVhc29uO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5SZXN1bHRzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQoNC10LfRg9C70YzRgtCw0YIg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YLQtdGB0YLQvtCy0L7Qs9C+INC80L7QtNGD0LvRj1xyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIGNsYXNzIFRlc3RTdWl0ZVJlc3VsdFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gQ3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIFRlc3RTdWl0ZVJlc3VsdCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBc3NlcnRzID0gbmV3IExpc3Q8QXNzZXJ0UmVzdWx0PigpO1xyXG4gICAgICAgICAgICBDaGlsZHJlbiA9IG5ldyBMaXN0PFRlc3RTdWl0ZVJlc3VsdD4oKTtcclxuICAgICAgICAgICAgRmFpbGVkSWRzID0gbmV3IExpc3Q8c3RyaW5nPigpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9GA0L7QstC10YDQutC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSUNvbGxlY3Rpb248QXNzZXJ0UmVzdWx0PiBBc3NlcnRzIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktC70L7QttC10L3QvdGL0LUg0LzQvtC00YPQu9C4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgTGlzdDxUZXN0U3VpdGVSZXN1bHQ+IENoaWxkcmVuIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0LvQuNGH0LXRgdGC0LLQviDRgdGG0LXQvdCw0YDQuNC10LJcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBpbnQgU2NlbmFyaW9Db3VudCB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRgNC10LzRjyDQstGL0L/QvtC70L3QtdC90LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIGludCBEdXJhdGlvbiB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J7QsdGJ0LXQtSDQutC+0LvQuNGH0LXRgdGC0LLQviDQv9GA0L7QstC10YDQvtC6XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgaW50IFRvdGFsIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0LvQuNGH0LXRgdGC0LLQviDRg9GB0L/QtdGI0L3Ri9GFINC/0YDQvtCy0LXRgNC+0LpcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBpbnQgUGFzc2VkIHsgZ2V0OyBpbnRlcm5hbCBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0LvQuNGH0LXRgdGC0LLQviDQv9GA0L7QstCw0LvQtdC90L3Ri9GFINC/0YDQvtCy0LXRgNC+0LpcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBpbnQgRmFpbGVkIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0LvQuNGH0LXRgdGC0LLQviDQv9GA0L7Qv9GD0YnQtdC90L3Ri9GFINGC0LXRgdGC0L7QsiDQuCDQvNC+0LTRg9C70LXQuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIGludCBTa2lwcGVkIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQoNC+0LTQuNGC0LXQu9GM0YHQutC40Lkg0LzQvtC00YPQu9GMXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgVGVzdFN1aXRlUmVzdWx0IFBhcmVudCB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JPQu9C+0LHQsNC70YzQvdCw0Y8g0L7RiNC40LHQutCwINC80L7QtNGD0LvRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIEV4Y2VwdGlvbiBFeGNlcHRpb24geyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCY0LzRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBOYW1lIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LvQvdC+0LUg0LjQvNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIEZ1bGxOYW1lIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmNC00LXQvdGC0LjRhNC40LrQsNGC0L7RgFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBJZCB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JjQtNC10L3RgtC40YTQuNC60LDRgtC+0YDRiyDQv9GA0L7QstCw0LvQtdC90L3Ri9GFINGC0LXRgdGC0L7QslxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIElDb2xsZWN0aW9uPHN0cmluZz4gRmFpbGVkSWRzIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQodGC0LDRgtGD0YEg0LLRi9C/0L7Qu9C90LXQvdC40Y9cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBUZXN0U3RhdHVzIFN0YXR1cyB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/RgNC40YfQuNC90LAg0L/RgNC+0L/Rg9GB0LrQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBTa2lwUmVhc29uIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQlNC+0LHQsNCy0LjRgtGMINGA0LXQt9GD0LvRjNGC0LDRglxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwicmVzdWx0XCI+0KDQtdC30YPQu9GM0YLQsNGCPC9wYXJhbT5cclxuICAgICAgICBpbnRlcm5hbCB2b2lkIEFkZENoaWxkUmVzdWx0KFRlc3RTdWl0ZVJlc3VsdCByZXN1bHQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXN1bHQuUGFyZW50ID0gdGhpcztcclxuICAgICAgICAgICAgQ2hpbGRyZW4uQWRkKHJlc3VsdCk7XHJcbiAgICAgICAgICAgIFRvdGFsICs9IHJlc3VsdC5Ub3RhbDtcclxuICAgICAgICAgICAgUGFzc2VkICs9IHJlc3VsdC5QYXNzZWQ7XHJcbiAgICAgICAgICAgIEZhaWxlZCArPSByZXN1bHQuRmFpbGVkO1xyXG4gICAgICAgICAgICBTa2lwcGVkICs9IHJlc3VsdC5Ta2lwcGVkO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQlNC+0LHQsNCy0LjRgtGMINGA0LXQt9GD0LvRjNGC0LDRgiDQstGL0L/QvtC70L3QtdC90LjRjyDQv9GA0L7QstC10YDQutC4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJyZXN1bHRcIj7QoNC10LfRg9C70YzRgtCw0YI8L3BhcmFtPlxyXG4gICAgICAgIGludGVybmFsIHZvaWQgQWRkQXNzZXJ0UmVzdWx0KEFzc2VydFJlc3VsdCByZXN1bHQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXN1bHQuSWQgPSBzdHJpbmcuRm9ybWF0KFwiezB9X2Fzc2VydHsxfVwiLElkLEFzc2VydHMuQ291bnQpO1xyXG4gICAgICAgICAgICBBc3NlcnRzLkFkZChyZXN1bHQpO1xyXG5cclxuICAgICAgICAgICAgVG90YWwgKz0gMTtcclxuICAgICAgICAgICAgaWYgKHJlc3VsdC5QYXNzZWQpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIFBhc3NlZCArPSAxO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGVsc2VcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgRmFpbGVkICs9IDE7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkNGC0YDQuNCx0YPRgiwg0LrQvtGC0L7RgNGL0Lwg0L/QvtC80LXRh9Cw0LXRgtGB0Y8g0YLQtdGB0YJcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBbQXR0cmlidXRlVXNhZ2UoQXR0cmlidXRlVGFyZ2V0cy5NZXRob2QpXVxyXG4gICAgcHVibGljIHNlYWxlZCBjbGFzcyBUZXN0QXR0cmlidXRlIDogQXR0cmlidXRlXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSBpbnQ/IGV4cGVjdGVkQ291bnQgPSBudWxsO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qt9Cy0L7Qu9GP0LXRgiDQt9Cw0LTQsNGC0Ywg0LjQvNGPINC00LvRjyDRgtC10YHRgtCwLlxyXG4gICAgICAgIC8vLyDQn9C+INGD0LzQvtC70YfQsNC90LjRjiDQsdGD0LTQtdGCINC40YHQv9C+0LvRjNC30L7QstCw0L3QviDQuNC80Y8g0LzQtdGC0L7QtNCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIE5hbWUgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7Qt9Cy0L7Qu9GP0LXRgiDQt9Cw0LTQsNGC0Ywg0L/RgNC10LTQv9C+0LvQsNCz0LDQtdC80L7QtSDQutC+0LvQuNGH0LXRgdGC0LLQviDQv9GA0L7QstC10YDQvtC6IChhc3NlcnRpb25zKSDQstC90YPRgtGA0Lgg0YLQtdGB0YLQvtCy0L7Qs9C+INC80LXRgtC+0LTQsC5cclxuICAgICAgICAvLy8g0JXRgdC70Lgg0LfQsNC00LDQvdC90L7QtSDQutC+0LvQuNGH0LXRgdGC0LLQviDQvdC1INGB0L7QstC/0LDQtNCw0LXRgiDRgSDRhNCw0LrRgtC40YfQtdGB0LrQuNC8IC0g0YLQtdGB0YIg0LfQsNCy0LXRgNGI0LjRgtGB0Y8g0YEg0L7RiNC40LHQutC+0LlcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBpbnQgRXhwZWN0ZWRDb3VudFxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgZ2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBleHBlY3RlZENvdW50LkdldFZhbHVlT3JEZWZhdWx0KCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgc2V0XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGV4cGVjdGVkQ291bnQgPSB2YWx1ZTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICB9XHJcbi8vLyA8c3VtbWFyeT5cclxuLy8vINCf0L7Qt9Cy0L7Qu9GP0LXRgiDQv9GA0L7QstC10YDQuNGC0YwsINC30LDQtNCw0L3QviDQu9C4IEV4cGVjdGVkQ291bnRcclxuLy8vIDwvc3VtbWFyeT5cclxuaW50ZXJuYWwgYm9vbCBJc0V4cGVjdGVkQ291bnRTZXRcclxue1xyXG4gICAgZ2V0XHJcbiAgICB7XHJcbiAgICAgICAgcmV0dXJuIGV4cGVjdGVkQ291bnQgIT0gbnVsbDtcclxuICAgIH1cclxufSAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdCw0LfQvtCy0YvQuSDQutC70LDRgdGBINGC0LXRgdGC0LAg0YEgQkREINC90L7RgtCw0YbQuNC10LlcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBbQ29tcG9uZW50KENyZWF0ZUluc3RhbmNlUGVyUmVzb2x2ZSA9IHRydWUpXVxyXG4gICAgcHVibGljIGNsYXNzIFRlc3QgOiBJQkREVGVzdFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC/0YPRgdGC0LjRgtGMINGC0LXRgdGC0L7QstGL0Lkg0YHRhtC10L3QsNGA0LjQuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCY0LzRjyDRgdGG0LXQvdCw0YDQuNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzdGVwc1wiPtCh0L/QuNGB0L7QuiDRiNCw0LPQvtCyINC00LvRjyDQstGL0L/QvtC70L3QtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgdm9pZCBSdW5TY2VuYXJpbyhzdHJpbmcgbmFtZSwgcGFyYW1zIElTdGVwW10gc3RlcHMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgYmRkUnVubmVyID0gbmV3IEJERFJ1bm5lcigpO1xyXG4gICAgICAgICAgICBiZGRSdW5uZXIuUnVuU2NlbmFyaW8obmFtZSwgc3RlcHMpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQldGB0LvQuFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCY0LzRjyDRiNCw0LPQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwic2V0dXBcIj7QmNC90LjRhtC40LDQu9C40LfQsNGG0LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCh0LvQtdC00YPRjtGJ0LjQuSDRiNCw0LMg0YHRhtC10L3QsNGA0LjRjzwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgSVN0ZXAgR2l2ZW4oc3RyaW5nIG5hbWUsIEFjdGlvbiBzZXR1cClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgU3RlcChzZXR1cCwgbmFtZSwgU3RlcFR5cGUuR0lWRU4pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmtC+0LPQtNCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJuYW1lXCI+0JjQvNGPINGI0LDQs9CwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJhY3Rpb25cIj7QlNC10LnRgdGC0LLQuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KHQu9C10LTRg9GO0YnQuNC5INGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBXaGVuKHN0cmluZyBuYW1lLCBBY3Rpb24gYWN0aW9uKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBTdGVwKGFjdGlvbiwgbmFtZSwgU3RlcFR5cGUuV0hFTik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0L5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y8g0YjQsNCz0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFzc2VydGlvblwiPtCf0YDQvtCy0LXRgNC60LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodC70LXQtNGD0Y7RidC40Lkg0YjQsNCzINGB0YbQtdC90LDRgNC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIElTdGVwIFRoZW4oc3RyaW5nIG5hbWUsIEFjdGlvbiBhc3NlcnRpb24pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFN0ZXAoYXNzZXJ0aW9uLCBuYW1lLCBTdGVwVHlwZS5USEVOKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60LvQsNGB0YEg0YLQtdGB0YLQsCDQtNC70Y8g0YHRg9GJ0L3QvtGB0YLQuCDRgSBCREQg0L3QvtGC0LDRhtC40LXQuVxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBUZXN0PFQ+IDogVGVzdFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KTRg9C90LrRhtC40Y8g0YHQvtC30LTQsNC90LjRjyDRgtC10YHRgtC+0LLQvtC5INC80L7QtNC10LvQuCDRgdGD0YnQvdC+0YHRgtC4LlxyXG4gICAgICAgIC8vLyDQkdGD0LTQtdGCINCy0YvQt9Cy0LDQvdCwINC/0YDQuCDQstGL0L/QvtC70L3QtdC90LjQuCDRgtC10YHRgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwcm90ZWN0ZWQgYWJzdHJhY3QgRnVuYzxUPiBNb2RlbCB7IGdldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCX0LDQv9GD0YHRgtC40YLRjCDRgtC10YHRgtC+0LLRi9C5INGB0YbQtdC90LDRgNC40LlcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y8g0YHRhtC10L3QsNGA0LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwic3RlcHNcIj7QodC/0LjRgdC+0Log0YjQsNCz0L7QsiDQtNC70Y8g0LLRi9C/0L7Qu9C90LXQvdC40Y88L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBvdmVycmlkZSB2b2lkIFJ1blNjZW5hcmlvKHN0cmluZyBuYW1lLCBwYXJhbXMgSVN0ZXBbXSBzdGVwcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChzdGVwcy5MZW5ndGggPT0gMClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdGhyb3cgbmV3IEludmFsaWRPcGVyYXRpb25FeGNlcHRpb24oU1IuVChcItCh0YbQtdC90LDRgNC40Lkg0LTQvtC70LbQtdC9INGB0L7QtNC10YDQttCw0YLRjCDQutCw0Log0LzQuNC90LjQvNGD0Lwg0L7QtNC40L0g0YjQsNCzXCIpKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIGJkZFJ1bm5lciA9IG5ldyBCRERSdW5uZXIoKTtcclxuICAgICAgICAgICAgYmRkUnVubmVyLlJ1blNjZW5hcmlvPFQ+KG5hbWUsIChGdW5jPFQ+KU1vZGVsLCBzdGVwcyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCV0YHQu9C4XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJuYW1lXCI+0JjQvNGPINGI0LDQs9CwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzZXR1cFwiPtCY0L3QuNGG0LjQsNC70LjQt9Cw0YbQuNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KHQu9C10LTRg9GO0YnQuNC5INGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyB2aXJ0dWFsIElTdGVwIEdpdmVuKHN0cmluZyBuYW1lLCBBY3Rpb248VD4gc2V0dXApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFRlc3RTdGVwV2l0aFBhcmFtPFQ+KHNldHVwLCBuYW1lLCBTdGVwVHlwZS5HSVZFTik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCa0L7Qs9C00LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y8g0YjQsNCz0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdGlvblwiPtCU0LXQudGB0YLQstC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodC70LXQtNGD0Y7RidC40Lkg0YjQsNCzINGB0YbQtdC90LDRgNC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIHZpcnR1YWwgSVN0ZXAgV2hlbihzdHJpbmcgbmFtZSwgQWN0aW9uPFQ+IGFjdGlvbilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgVGVzdFN0ZXBXaXRoUGFyYW08VD4oYWN0aW9uLCBuYW1lLCBTdGVwVHlwZS5XSEVOKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KLQvlxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCY0LzRjyDRiNCw0LPQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiYXNzZXJ0aW9uXCI+0J/RgNC+0LLQtdGA0LrQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCh0LvQtdC00YPRjtGJ0LjQuSDRiNCw0LMg0YHRhtC10L3QsNGA0LjRjzwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgdmlydHVhbCBJU3RlcCBUaGVuKHN0cmluZyBuYW1lLCBBY3Rpb248VD4gYXNzZXJ0aW9uKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBUZXN0U3RlcFdpdGhQYXJhbTxUPihhc3NlcnRpb24sIG5hbWUsIFN0ZXBUeXBlLlRIRU4pO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db250cm9sbGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5BUElcclxue1xyXG4gICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgIHB1YmxpYyBjbGFzcyBCYXNlUmVhY3RDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyLCBUSW5wdXRzPiA6IElCYXNlUmVhY3RDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyLCBUSW5wdXRzPlxyXG4gICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUNvbnRleHRcclxuICAgICAgICB3aGVyZSBUQ29udHJvbGxlciA6IElDb250cm9sbGVyXHJcbiAgICAgICAgd2hlcmUgVElucHV0cyA6IElJbnB1dHNcclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgQmFzZVJlYWN0Q29tcG9uZW50VGVzdE1vZGVsKElDb250ZXh0IGNvbnRleHQsIElDb250cm9sbGVyIGNvbnRyb2xsZXIsIElJbnB1dHMgaW5wdXRzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQ29udGV4dCA9IChUQ29udGV4dCljb250ZXh0O1xyXG4gICAgICAgICAgICBDb250cm9sbGVyID0gKFRDb250cm9sbGVyKWNvbnRyb2xsZXI7XHJcbiAgICAgICAgICAgIElucHV0cyA9IChUSW5wdXRzKWlucHV0cztcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBUQ29udGV4dCBDb250ZXh0IHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVENvbnRyb2xsZXIgQ29udHJvbGxlciB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgVElucHV0cyBJbnB1dHMgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29udHJvbGxlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5BUElcclxue1xyXG4gICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgIHB1YmxpYyBjbGFzcyBCYXNlVmlld0l0ZW1Db21wb25lbnRUZXN0TW9kZWw8VFZpZXdJdGVtLCBUSW5wdXRzLCBUQ29udGV4dCwgVENvbnRyb2xsZXI+IDogSUJhc2VWaWV3SXRlbUNvbXBvbmVudFRlc3RNb2RlbDxUVmlld0l0ZW0sIFRJbnB1dHMsIFRDb250ZXh0LCBUQ29udHJvbGxlcj5cclxuICAgICAgICAgICAgd2hlcmUgVFZpZXdJdGVtIDogSVZpZXdJdGVtXHJcbiAgICAgICAgICAgIHdoZXJlIFRJbnB1dHMgOiBJSW5wdXRzXHJcbiAgICAgICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUNvbnRleHRcclxuICAgICAgICAgICAgd2hlcmUgVENvbnRyb2xsZXIgOiBJQ29udHJvbGxlclxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gY3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmlld0l0ZW1cIj5cItCt0LvQtdC80LXQvdGCINC/0YDQtdC00YHRgtCw0LLQu9C10L3QuNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJpbnB1dHNcIj7QmNC90L/Rg9GC0Ys8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImNvbnRleHRcIj7QmtC+0L3RgtC10LrRgdGCPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjb250cm9sbGVyXCI+0JrQvtC90YLRgNC+0LvQu9C10YA8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBCYXNlVmlld0l0ZW1Db21wb25lbnRUZXN0TW9kZWwoSVZpZXdJdGVtIHZpZXdJdGVtLCBJSW5wdXRzIGlucHV0cywgSUNvbnRleHQgY29udGV4dCwgSUNvbnRyb2xsZXIgY29udHJvbGxlcilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIFZpZXdJdGVtID0gKFRWaWV3SXRlbSl2aWV3SXRlbTtcclxuICAgICAgICAgICAgSW5wdXRzID0gKFRJbnB1dHMpaW5wdXRzO1xyXG4gICAgICAgICAgICBDb250ZXh0ID0gKFRDb250ZXh0KWNvbnRleHQ7XHJcbiAgICAgICAgICAgIENvbnRyb2xsZXIgPSAoVENvbnRyb2xsZXIpY29udHJvbGxlcjtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIFRWaWV3SXRlbSBWaWV3SXRlbSB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgVENvbnRleHQgQ29udGV4dCB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgVENvbnRyb2xsZXIgQ29udHJvbGxlciB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgVElucHV0cyBJbnB1dHMgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29udHJvbGxlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQVBJXHJcbntcclxuICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgcHVibGljIGNsYXNzIENvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+IDogSUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+XHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQ29udGV4dFxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgQ29tcG9uZW50VGVzdE1vZGVsKElDb250ZXh0IGNvbnRleHQsIElDb250cm9sbGVyIGNvbnRyb2xsZXIpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDb250ZXh0ID0gKFRDb250ZXh0KWNvbnRleHQ7XHJcbiAgICAgICAgICAgIENvbnRyb2xsZXIgPSAoVENvbnRyb2xsZXIpY29udHJvbGxlcjtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBUQ29udGV4dCBDb250ZXh0IHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVENvbnRyb2xsZXIgQ29udHJvbGxlciB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuICAgIH1cclxuXHJcbiAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgIHB1YmxpYyBjbGFzcyBDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+IDogSUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj5cclxuICAgICAgICB3aGVyZSBUQ29udHJvbGxlciA6IElDb250cm9sbGVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jIC8+XHJcbiAgICAgICAgcHVibGljIENvbXBvbmVudFRlc3RNb2RlbChJQ29udGV4dCBjb250ZXh0LCBJQ29udHJvbGxlciBjb250cm9sbGVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQ29udGV4dCA9IGNvbnRleHQ7XHJcbiAgICAgICAgICAgIENvbnRyb2xsZXIgPSAoVENvbnRyb2xsZXIpY29udHJvbGxlcjtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYyAvPlxyXG4gICAgICAgIHB1YmxpYyBJQ29udGV4dCBDb250ZXh0IHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MgLz5cclxuICAgICAgICBwdWJsaWMgVENvbnRyb2xsZXIgQ29udHJvbGxlciB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Db3JlO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5SZXN1bHRzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkJERFxyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KDQsNC90L3QtdGAINGC0LXRgdGC0L7QstGL0YUg0YHRhtC10L3QsNGA0LjQtdCyXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgaW50ZXJuYWwgY2xhc3MgQkREUnVubmVyIDogSUJERFJ1bm5lclxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC/0YPRgdGC0LjRgtGMINGC0LXRgdGC0L7QstGL0Lkg0YHRhtC10L3QsNGA0LjQuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCd0LDQt9Cy0LDQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInN0ZXBzXCI+0KjQsNCz0Lgg0YLQtdGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUnVuU2NlbmFyaW8oc3RyaW5nIG5hbWUsIHBhcmFtcyBJU3RlcFtdIHN0ZXBzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHNjZW5hcmlvID0gQ29uZmlndXJlU2NlbmFyaW8oKVxyXG4gICAgICAgICAgICAgICAgLldpdGhOYW1lKG5hbWUpXHJcbiAgICAgICAgICAgICAgICAuV2l0aFN0ZXBzKHN0ZXBzKVxyXG4gICAgICAgICAgICAgICAgLkJ1aWxkKCk7XHJcblxyXG4gICAgICAgICAgICB2YXIgY29udGV4dCA9IENyZWF0ZUNvbnRleHQoKTtcclxuICAgICAgICAgICAgY29udGV4dC5DdXJyZW50U2NlbmFyaW8gPSBzY2VuYXJpbztcclxuICAgICAgICAgICAgc2NlbmFyaW8uRXhlY3V0ZShjb250ZXh0KTtcclxuXHJcbiAgICAgICAgICAgIFRlc3RDb250ZXh0LkN1cnJlbnQuU2NlbmFyaW9Db3VudCArPSAxO1xyXG4gICAgICAgICAgICB2YXIgcmVzdWx0ID0gbmV3IFNjZW5hcmlvUmVzdWx0KHNjZW5hcmlvKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBJZCA9IHN0cmluZy5Gb3JtYXQoXCJTY2VuYXJpb197MH1cIixUZXN0Q29udGV4dC5DdXJyZW50LlNjZW5hcmlvQ291bnQpICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgVGVzdENvbnRleHQuQ3VycmVudC5TZXRSZXN1bHQocmVzdWx0KTtcclxuICAgICAgICAgICAgdHJ5XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHNjZW5hcmlvLkV4ZWN1dGUoY29udGV4dCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgY2F0Y2ggKEV4Y2VwdGlvbiBleClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIGV4Y2VwdGlvbiA9IG5ldyBFeGNlcHRpb24oU1IuVChcItCSINC/0YDQvtGG0LXRgdGB0LUg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YHRhtC10L3QsNGA0LjRjyDQstC+0LfQvdC40LrQu9CwINC+0YjQuNCx0LrQsFwiKSwgZXgpO1xyXG4gICAgICAgICAgICAgICAgcmVzdWx0LkZhaWxlZCA9IDE7XHJcbiAgICAgICAgICAgICAgICByZXN1bHQuRXhjZXB0aW9uID0gZXhjZXB0aW9uO1xyXG4gICAgICAgICAgICAgICAgdGhyb3cgZXhjZXB0aW9uO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGZpbmFsbHlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgVGVzdENvbnRleHQuQ3VycmVudC5Qb3BSZXN1bHQoKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQl9Cw0L/Rg9GB0YLQuNGC0Ywg0YLQtdGB0YLQvtCy0YvQuSDRgdGG0LXQvdCw0YDQuNC5INC00LvRjyDQvNC+0LTQtdC70LhcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QndCw0LfQstCw0L3QuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtb2RlbENyZWF0b3JcIj7QpNGD0L3QutGG0LjRjyDRgdC+0LfQtNCw0L3QuNGPINGC0LXRgdGC0L7QstC+0Lkg0LzQvtC00LXQu9C4INC00LvRjyDQtNCw0L3QvdC+0LPQviDRgdGG0LXQvdCw0YDQuNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzdGVwc1wiPtCo0LDQs9C4INGC0LXRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFJ1blNjZW5hcmlvPFQ+KHN0cmluZyBuYW1lLCBGdW5jPFQ+IG1vZGVsQ3JlYXRvciwgcGFyYW1zIElTdGVwW10gc3RlcHMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgc2NlbmFyaW8gPSBDb25maWd1cmVTY2VuYXJpbygpXHJcbiAgICAgICAgICAgICAgICAuV2l0aE5hbWUobmFtZSlcclxuICAgICAgICAgICAgICAgIC5XaXRoU3RlcHMoc3RlcHMpXHJcbiAgICAgICAgICAgICAgICAuQnVpbGQoKTtcclxuXHJcbiAgICAgICAgICAgIHZhciBjb250ZXh0ID0gQ3JlYXRlQ29udGV4dCgpO1xyXG4gICAgICAgICAgICBjb250ZXh0LkN1cnJlbnRTY2VuYXJpbyA9IHNjZW5hcmlvO1xyXG5cclxuICAgICAgICAgICAgVGVzdENvbnRleHQuQ3VycmVudC5TY2VuYXJpb0NvdW50ICs9IDE7XHJcbiAgICAgICAgICAgIHZhciByZXN1bHQgPSBuZXcgU2NlbmFyaW9SZXN1bHQoc2NlbmFyaW8pXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIElkID0gc3RyaW5nLkZvcm1hdChcIlNjZW5hcmlvX3swfVwiLFRlc3RDb250ZXh0LkN1cnJlbnQuU2NlbmFyaW9Db3VudCkgICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICBUZXN0Q29udGV4dC5DdXJyZW50LlNldFJlc3VsdChyZXN1bHQpO1xyXG5cclxuICAgICAgICAgICAgdHJ5XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNvbnRleHQuTW9kZWwgPSBtb2RlbENyZWF0b3IoKTtcclxuICAgICAgICAgICAgICAgIHNjZW5hcmlvLkV4ZWN1dGUoY29udGV4dCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgY2F0Y2ggKEV4Y2VwdGlvbiBleClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIGV4Y2VwdGlvbiA9IG5ldyBFeGNlcHRpb24oU1IuVChcItCSINC/0YDQvtGG0LXRgdGB0LUg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YHRhtC10L3QsNGA0LjRjyDQstC+0LfQvdC40LrQu9CwINC+0YjQuNCx0LrQsFwiKSwgZXgpO1xyXG4gICAgICAgICAgICAgICAgcmVzdWx0LkZhaWxlZCA9IDE7XHJcbiAgICAgICAgICAgICAgICByZXN1bHQuRXhjZXB0aW9uID0gZXhjZXB0aW9uO1xyXG4gICAgICAgICAgICAgICAgdGhyb3cgZXhjZXB0aW9uO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGZpbmFsbHlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgVGVzdENvbnRleHQuQ3VycmVudC5Qb3BSZXN1bHQoKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxucHJpdmF0ZSBJU2NlbmFyaW9CdWlsZGVyIENvbmZpZ3VyZVNjZW5hcmlvKClcclxue1xyXG4gICAgcmV0dXJuIG5ldyBTY2VuYXJpb0J1aWxkZXIoKTtcclxufVxyXG4gICAgICAgIHByaXZhdGUgSVNjZW5hcmlvRXhlY3V0aW9uQ29udGV4dCBDcmVhdGVDb250ZXh0KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBjb250ZXh0ID0gbmV3IFNjZW5hcmlvRXhlY3V0aW9uQ29udGV4dCgpO1xyXG4gICAgICAgICAgICBTY2VuYXJpb0V4ZWN1dGlvbkNvbnRleHQuQ3VycmVudCA9IGNvbnRleHQ7XHJcbiAgICAgICAgICAgIHJldHVybiBjb250ZXh0O1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Db3JlO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Ob3RpZmljYXRpb247XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLlJlc3VsdHM7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQotC10YHRgtC+0LLRi9C5INGB0YbQtdC90LDRgNC40LlcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgU2NlbmFyaW8gOiBJU2NlbmFyaW9cclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElTdGVwW10gc3RlcHM7XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBOYW1lIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y88L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInN0ZXBzXCI+0KjQsNCz0Lgg0YHRhtC10L3QsNGA0LjRjzwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFNjZW5hcmlvKHN0cmluZyBuYW1lLCBJU3RlcFtdIHN0ZXBzKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgTmFtZSA9IG5hbWU7XHJcbiAgICAgICAgICAgIHRoaXMuc3RlcHMgPSBzdGVwcztcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRi9C/0L7Qu9C90LjRgtGMINGB0YbQtdC90LDRgNC40LlcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImNvbnRleHRcIj7QmtC+0L3RgtC10LrRgdGCINCy0YvQv9C+0LvQvdC10L3QuNGPINGB0YbQtdC90LDRgNC40Y88L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEV4ZWN1dGUoSVNjZW5hcmlvRXhlY3V0aW9uQ29udGV4dCBjb250ZXh0KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIG5vdGlmaWVyID0gVGVzdENvbnRleHQuQ3VycmVudC5Ob3RpZmllciBhcyBJU2NlbmFyaW9Qcm9ncmVzc05vdGlmaWVyO1xyXG4gICAgICAgICAgICBub3RpZmllciE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbUxhbWJkYSgoKT0+bm90aWZpZXIuU2NlbmFyaW9TdGFydGVkKG5ldyBTY2VuYXJpb0luZm8oKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBOYW1lID0gTmFtZVxyXG4gICAgICAgICAgICB9KSk6bnVsbDtcclxuXHJcbiAgICAgICAgICAgIHZhciB0b3RhbCA9IHN0ZXBzLkxlbmd0aDtcclxuICAgICAgICAgICAgZm9yICh2YXIgaSA9IDA7IGkgPCB0b3RhbDsgaSsrKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgc3RlcCA9IHN0ZXBzW2ldO1xyXG4gICAgICAgICAgICAgICAgY29udGV4dC5DdXJyZW50U3RlcCA9IHN0ZXA7XHJcbklFeGVjdXRhYmxlU3RlcCBleGVjdXRhYmxlU3RlcDtcclxuICAgICAgICAgICAgICAgIGlmICgoZXhlY3V0YWJsZVN0ZXAgPSBzdGVwIGFzIElFeGVjdXRhYmxlU3RlcCkgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgcmVzdWx0ID0gbmV3IFN0ZXBSZXN1bHQoc3RlcClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIElkID0gc3RyaW5nLkZvcm1hdChcInswfV97MX1cIixUZXN0Q29udGV4dC5DdXJyZW50LkN1cnJlbnRSZXN1bHQuSWQsaSkgICAgICAgICAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgICAgICAgICAgVGVzdENvbnRleHQuQ3VycmVudC5TZXRSZXN1bHQocmVzdWx0KTtcclxuXHJcblxyXG4gICAgICAgICAgICAgICAgICAgIG5vdGlmaWVyIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tTGFtYmRhKCgpPT5ub3RpZmllci5TdGVwU3RhcnRlZChuZXcgU3RlcEluZm9cclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIE5hbWUgPSBzdGVwLk5hbWUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFR5cGUgPSBzdGVwLlR5cGUsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIE51bWJlciA9IGkgKyAxLFxyXG4gICAgICAgICAgICAgICAgICAgICAgICBUb3RhbCA9IHRvdGFsXHJcbiAgICAgICAgICAgICAgICAgICAgfSkpOm51bGw7XHJcblxyXG4gICAgICAgICAgICAgICAgICAgIHRyeVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgZXhlY3V0YWJsZVN0ZXAuRXhlY3V0ZShjb250ZXh0KTtcclxuICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICAgICAgY2F0Y2ggKEV4Y2VwdGlvbiBleClcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHZhciBleGNlcHRpb24gPSBuZXcgRXhjZXB0aW9uKFNSLlQoXCLQktGL0L/QvtC70L3QtdC90LjQtSDRiNCw0LPQsCDQt9Cw0LLQtdGA0YjQuNC70L7RgdGMINGBINC+0YjQuNCx0LrQvtC5XCIpLCBleCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHJlc3VsdC5GYWlsZWQgPSAxO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICByZXN1bHQuRXhjZXB0aW9uID0gZXhjZXB0aW9uO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICB0aHJvdyBleGNlcHRpb247XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIGZpbmFsbHlcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFRlc3RDb250ZXh0LkN1cnJlbnQuUG9wUmVzdWx0KCk7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIG5vdGlmaWVyIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tTGFtYmRhKCgpPT5ub3RpZmllci5TdGVwRmluaXNoZWQocmVzdWx0KSk6bnVsbDtcclxuICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdGhyb3cgbmV3IEV4Y2VwdGlvbihTUi5UKFwi0J3QtdCy0L7Qt9C80L7QttC90L4g0LLRi9C/0L7Qu9C90LjRgtGMINGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPOiDRiNCw0LMgezB9INC90LUg0Y/QstC70Y/QtdGC0YHRjyB7MX1cIiwgc3RlcC5OYW1lLCB0eXBlb2YoSUV4ZWN1dGFibGVTdGVwKSkpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBub3RpZmllciE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbUxhbWJkYSgoKT0+bm90aWZpZXIuU2NlbmFyaW9GaW5pc2hlZChuZXcgU2NlbmFyaW9SZXN1bHQodGhpcykpKTpudWxsO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJuYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQkdC40LvQtNC10YAg0YLQtdGB0YLQvtCy0YvRhSDRgdGG0LXQvdCw0YDQuNC10LJcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBjbGFzcyBTY2VuYXJpb0J1aWxkZXIgOiBJU2NlbmFyaW9CdWlsZGVyXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSBzdHJpbmcgbmFtZTtcclxuICAgICAgICBwcml2YXRlIElTdGVwW10gc3RlcHM7XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC00LDRgtGMINC40LzRjyDRgdGG0LXQvdCw0YDQuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJuYW1lXCI+0JjQvNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0JHQuNC70LTQtdGAPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU2NlbmFyaW9CdWlsZGVyIFdpdGhOYW1lKHN0cmluZyBuYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5uYW1lID0gbmFtZTtcclxuICAgICAgICAgICAgcmV0dXJuIHRoaXM7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCX0LDQtNCw0YLRjCDRiNCw0LPQuCDQtNC70Y8g0LLRi9C/0L7Qu9C90LXQvdC40Y8g0LIg0YHRhtC10L3QsNGA0LjQuFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwic3RlcHNcIj7QqNCw0LPQuCDRgdGG0LXQvdCw0YDQuNGPPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0JHQuNC70LTQtdGAPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU2NlbmFyaW9CdWlsZGVyIFdpdGhTdGVwcyhwYXJhbXMgSVN0ZXBbXSBzdGVwcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMuc3RlcHMgPSBzdGVwcztcclxuICAgICAgICAgICAgcmV0dXJuIHRoaXM7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCh0L7Qt9C00LDRgtGMINGB0YbQtdC90LDRgNC40LlcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodGG0LXQvdCw0YDQuNC5PC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU2NlbmFyaW8gQnVpbGQoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHNjZW5hcmlvID0gbmV3IFNjZW5hcmlvKG5hbWUsIHN0ZXBzKTtcclxuICAgICAgICAgICAgcmV0dXJuIHNjZW5hcmlvO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQqNCw0LMg0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIGNsYXNzIFN0ZXAgOiBJU3RlcCwgSUV4ZWN1dGFibGVTdGVwXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBBY3Rpb24gYWN0aW9uO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdGlvblwiPtCU0LXQudGB0YLQstC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y88L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInN0ZXBUeXBlXCI+0KLQuNC/PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgU3RlcChBY3Rpb24gYWN0aW9uLCBzdHJpbmcgbmFtZSwgU3RlcFR5cGUgc3RlcFR5cGUpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB0aGlzLmFjdGlvbiA9IGFjdGlvbjtcclxuICAgICAgICAgICAgTmFtZSA9IG5hbWU7XHJcbiAgICAgICAgICAgIFR5cGUgPSBzdGVwVHlwZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JjQvNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIE5hbWUgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KLQuNC/XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgU3RlcFR5cGUgVHlwZSB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktGL0L/QvtC70L3QuNGC0Ywg0YjQsNCzXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjb250ZXh0XCI+0JrQvtC90YLQtdC60YHRgiDQstGL0L/QvtC70L3QtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIHZvaWQgRXhlY3V0ZShJU2NlbmFyaW9FeGVjdXRpb25Db250ZXh0IGNvbnRleHQpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBhY3Rpb24oKTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCo0LDQsyDRgdGG0LXQvdCw0YDQuNGPINGBINC/0LDRgNCw0LzQtdGC0YDQvtC8XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgaW50ZXJuYWwgY2xhc3MgVGVzdFN0ZXBXaXRoUGFyYW08VD4gOiBJU3RlcCwgSUV4ZWN1dGFibGVTdGVwXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBBY3Rpb248VD4gYWN0aW9uO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFjdGlvblwiPtCU0LXQudGB0YLQstC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y88L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInN0ZXBUeXBlXCI+0KLQuNC/PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgVGVzdFN0ZXBXaXRoUGFyYW0oQWN0aW9uPFQ+IGFjdGlvbiwgc3RyaW5nIG5hbWUsIFN0ZXBUeXBlIHN0ZXBUeXBlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5hY3Rpb24gPSBhY3Rpb247XHJcbiAgICAgICAgICAgIE5hbWUgPSBuYW1lO1xyXG4gICAgICAgICAgICBUeXBlID0gc3RlcFR5cGU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCY0LzRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBOYW1lIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LjQv1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIFN0ZXBUeXBlIFR5cGUgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRi9C/0L7Qu9C90LjRgtGMINGI0LDQs1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY29udGV4dFwiPtCa0L7QvdGC0LXQutGB0YIg0LLRi9C/0L7Qu9C90LXQvdC40Y88L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIEV4ZWN1dGUoSVNjZW5hcmlvRXhlY3V0aW9uQ29udGV4dCBjb250ZXh0KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgYWN0aW9uKChUKWNvbnRleHQuTW9kZWwpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgU3lzdGVtLlJlZmxlY3Rpb247XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQ29yZVxyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KHQsdC+0YDQutCwINGBINGC0LXRgdGC0LDQvNC4XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgaW50ZXJuYWwgc2VhbGVkIGNsYXNzIFRlc3RBc3NlbWJseSA6IElUZXN0QXNzZW1ibHlcclxuICAgIHtcclxuICAgICAgICAjcmVnaW9uIGN0b3JcclxuXHJcbiAgICAgICAgcHVibGljIFRlc3RBc3NlbWJseShBc3NlbWJseSBhc3NlbWJseSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEFzc2VtYmx5ID0gYXNzZW1ibHk7XHJcbiAgICAgICAgICAgIE5hbWUgPSBhc3NlbWJseS5GdWxsTmFtZTtcclxuICAgICAgICAgICAgVGVzdEZpeHR1cmVzID0gbmV3IExpc3Q8SVRlc3RGaXh0dXJlPigpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBBc3NlbWJseSBBc3NlbWJseSB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIE5hbWUgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIElFbnVtZXJhYmxlPElUZXN0Rml4dHVyZT4gVGVzdEZpeHR1cmVzIHsgZ2V0OyBzZXQ7IH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBTeXN0ZW0uUmVmbGVjdGlvbjtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29tcG9uZW50TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkRpYWdub3N0aWNzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkNvcmVcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCh0LXRgNCy0LjRgSDQtNC70Y8g0LPQtdC90LXRgNCw0YbQuNC4INGC0LXRgdGC0L7QstGL0YUg0YHQsdC+0YDQvtC6XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgaW50ZXJuYWwgY2xhc3MgVGVzdEFzc2VtYmx5QnVpbGRlciA6IElUZXN0QXNzZW1ibHlCdWlsZGVyXHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0YHRgtGA0L7QuNGC0Ywg0YLQtdGB0YLQvtCy0YvQtSDRgdCx0L7RgNC60LhcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImFzc2VtYmxpZXNcIj7QmNGB0YXQvtC00L3Ri9C1INGB0LHQvtGA0LrQuDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCi0LXRgdGC0L7QstGL0LUg0YHQsdC+0YDQutC4PC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJRW51bWVyYWJsZTxJVGVzdEFzc2VtYmx5PiBCdWlsZChBc3NlbWJseVtdIGFzc2VtYmxpZXMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDb250cmFjdC5Bcmd1bWVudE5vdE51bGwoYXNzZW1ibGllcywgXCJhc3NlbWJsaWVzXCIpO1xyXG5cclxuICAgICAgICAgICAgdmFyIHRlc3RBc3NlbWJsaWVzID0gbmV3IExpc3Q8SVRlc3RBc3NlbWJseT4oKTtcclxuXHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciBhc3NlbWJseSBpbiBhc3NlbWJsaWVzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgY29tcG9uZW50QXNzZW1ibHlBdHRyaWJ1dGUgPSBBdHRyaWJ1dGVIZWxwZXI8Q29tcG9uZW50QXNzZW1ibHlBdHRyaWJ1dGU+LkdldEF0dHJpYnV0ZShhc3NlbWJseSk7XHJcbiAgICAgICAgICAgICAgICBpZiAoY29tcG9uZW50QXNzZW1ibHlBdHRyaWJ1dGUgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBjb250aW51ZTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICBpZiAoYXNzZW1ibHkuRnVsbE5hbWUuRW5kc1dpdGgoVGVzdENvbnRyb2xsZXIuRnJhbWV3b3JrQ29uZmlnLlRlc3RBc3NlbWJseU5hbWVQYXR0ZXJuKSlcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgdGVzdEFzc2VtYmx5ID0gQnVpbGQoYXNzZW1ibHkpO1xyXG4gICAgICAgICAgICAgICAgICAgIHRlc3RBc3NlbWJsaWVzLkFkZCh0ZXN0QXNzZW1ibHkpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gdGVzdEFzc2VtYmxpZXM7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCh0LPQtdC90LXRgNC40YDQvtCy0LDRgtGMINGC0LXRgdGC0L7QstGD0Y4g0YHQsdC+0YDQutGDXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJhc3NlbWJseVwiPtCY0YHRhdC+0LTQvdCw0Y8g0YHQsdC+0YDQutCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KLQtdGB0YLQvtCy0LDRjyDRgdCx0L7RgNC60LA8L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIElUZXN0QXNzZW1ibHkgQnVpbGQoQXNzZW1ibHkgYXNzZW1ibHkpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBDb250cmFjdC5Bcmd1bWVudE5vdE51bGwoYXNzZW1ibHksIFwiYXNzZW1ibHlcIik7XHJcblxyXG4gICAgICAgICAgICB2YXIgdGVzdEFzc2VtYmx5ID0gbmV3IFRlc3RBc3NlbWJseShhc3NlbWJseSk7XHJcbiAgICAgICAgICAgIHZhciB0eXBlcyA9IGFzc2VtYmx5LkdldFR5cGVzKCk7XHJcbiAgICAgICAgICAgIHRlc3RBc3NlbWJseS5UZXN0Rml4dHVyZXMgPSBCdWlsZCh0eXBlcyk7XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gdGVzdEFzc2VtYmx5O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBJTGlzdDxJVGVzdEZpeHR1cmU+IEJ1aWxkKFR5cGVbXSB0eXBlcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBmaXh0dXJlcyA9IG5ldyBMaXN0PElUZXN0Rml4dHVyZT4oKTtcclxuXHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciB0eXBlIGluIHR5cGVzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgYXR0ciA9IEF0dHJpYnV0ZUhlbHBlcjxUZXN0Rml4dHVyZUF0dHJpYnV0ZT4uR2V0QXR0cmlidXRlKHR5cGUsIGZhbHNlKTtcclxuICAgICAgICAgICAgICAgIGlmIChhdHRyICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGZpeHR1cmUgPSBuZXcgVGVzdEZpeHR1cmUodHlwZSwgYXR0ci5OYW1lKTtcclxuICAgICAgICAgICAgICAgICAgICBmaXh0dXJlcy5BZGQoZml4dHVyZSk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBmaXh0dXJlcztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnMuR2VuZXJpYztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuTm90aWZpY2F0aW9uO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5SZXN1bHRzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5TZXJ2aWNlcztcclxudXNpbmcgUVVuaXRBc3NlcnQgPSBCcmlkZ2UuUVVuaXQuQXNzZXJ0O1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkNvcmVcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCa0L7QvdGC0LXQutGB0YIg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YLQtdGB0YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBUZXN0Q29udGV4dCA6IElUZXN0Q29udGV4dFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KLQtdC60YPRidC40Lkg0LrQvtC90YLQtdC60YHRgiDQstGL0L/QvtC70L3QtdC90LjRjyDRgtC10YHRgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgc3RhdGljIFRlc3RDb250ZXh0IEN1cnJlbnQgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBGdW5jPFFVbml0QXNzZXJ0PiBBc3NlcnQgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBJVGVzdE5vdGlmaWVyIE5vdGlmaWVyIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgSVRlc3RGYWN0b3J5IFRlc3RGYWN0b3J5IHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgVGVzdFN1aXRlUmVzdWx0IEN1cnJlbnRSZXN1bHQgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIElUZXN0TWV0aG9kIEN1cnJlbnRUZXN0IHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgSVRlc3RGaXh0dXJlIEN1cnJlbnRUZXN0Rml4dHVyZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIGludCBBc3NlcnRDb3VudGVyIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgaW50IFNjZW5hcmlvQ291bnQgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFNldFJlc3VsdChUZXN0U3VpdGVSZXN1bHQgdmFsdWUpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoQ3VycmVudFJlc3VsdCAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YWx1ZS5QYXJlbnQgPSBDdXJyZW50UmVzdWx0O1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIEN1cnJlbnRSZXN1bHQgPSB2YWx1ZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUG9wUmVzdWx0KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBjdXJyZW50ID0gQ3VycmVudC5DdXJyZW50UmVzdWx0O1xyXG4gICAgICAgICAgICB2YXIgcGFyZW50ID0gY3VycmVudC5QYXJlbnQ7XHJcbiAgICAgICAgICAgIGlmIChwYXJlbnQgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcGFyZW50LkFkZENoaWxkUmVzdWx0KGN1cnJlbnQpO1xyXG4gICAgICAgICAgICAgICAgaWYgKGN1cnJlbnQuRmFpbGVkID4gMClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBwYXJlbnQuRmFpbGVkSWRzLkFkZChjdXJyZW50LklkKTtcclxuU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWMuSUNvbGxlY3Rpb25FeHRlbnNpb25zLkFkZFJhbmdlPHN0cmluZz4oICAgICAgICAgICAgICAgICAgICBwYXJlbnQuRmFpbGVkSWRzLGN1cnJlbnQuRmFpbGVkSWRzKTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICBDdXJyZW50LkN1cnJlbnRSZXN1bHQgPSBwYXJlbnQ7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7XHJcbnVzaW5nIFN5c3RlbS5SZWZsZWN0aW9uO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db21wb25lbnRNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuSGVscGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuUmVzdWx0cztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Db3JlXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyAg0JrQu9Cw0YHRgSDQtNC70Y8g0L/RgNC10LTRgdGC0LDQstC70LXQvdC40Y8g0LrQu9Cw0YHRgdCwINGBINGC0LXRgdGC0LDQvNC4INCy0L3Rg9GC0YDQuCDRhNGA0LXQudC80LLQvtGA0LrQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBUZXN0Rml4dHVyZSA6IElUZXN0Rml4dHVyZVxyXG4gICAge1xyXG4gICAgICAgICNyZWdpb24gY3RvciBcclxuXHJcbiAgICAgICAgcHVibGljIFRlc3RGaXh0dXJlKFR5cGUgdHlwZSkgOiB0aGlzKHR5cGUsIHR5cGUuTmFtZSkgeyB9XHJcblxyXG4gICAgICAgIHB1YmxpYyBUZXN0Rml4dHVyZShUeXBlIHR5cGUsIHN0cmluZyBuYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgVHlwZSA9IHR5cGU7XHJcbiAgICAgICAgICAgIE5hbWUgPSBuYW1lID8/IHR5cGUuTmFtZTtcclxuICAgICAgICAgICAgSW5pdGlhbGl6ZSgpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBUeXBlIFR5cGUgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBOYW1lIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBJRW51bWVyYWJsZTxJVGVzdE1ldGhvZD4gVGVzdHMgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIG9iamVjdCBJbnN0YW5jZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIE1ldGhvZEluZm8gU2V0VXAgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBNZXRob2RJbmZvIFRlYXJEb3duIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgRnVuYzxUYXNrPiBPbmVUaW1lU2V0VXAgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBUZXN0Rml4dHVyZVJlc3VsdCBSZXN1bHQgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBib29sIFNraXAgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHN0cmluZyBTa2lwUmVhc29uIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgSW5pdGlhbGl6ZSgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgaWdub3JlQXR0cmlidXRlID0gQXR0cmlidXRlSGVscGVyPElnbm9yZUF0dHJpYnV0ZT4uR2V0QXR0cmlidXRlKFR5cGUsIGZhbHNlKTtcclxuICAgICAgICAgICAgaWYgKGlnbm9yZUF0dHJpYnV0ZSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBTa2lwID0gdHJ1ZTtcclxuICAgICAgICAgICAgICAgIFNraXBSZWFzb24gPSBpZ25vcmVBdHRyaWJ1dGUuUmVhc29uO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgdGVzdE1ldGhvZHMgPSBuZXcgTGlzdDxJVGVzdE1ldGhvZD4oKTtcclxuICAgICAgICAgICAgdmFyIG1ldGhvZHMgPSBUeXBlLkdldE1ldGhvZHMoQmluZGluZ0ZsYWdzLlB1YmxpYyB8IEJpbmRpbmdGbGFncy5EZWNsYXJlZE9ubHkgfCBCaW5kaW5nRmxhZ3MuSW5zdGFuY2UpO1xyXG4gICAgICAgICAgICBmb3JlYWNoICh2YXIgbWV0aG9kIGluIG1ldGhvZHMpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGlmIChBdHRyaWJ1dGVIZWxwZXI8U2V0VXBBdHRyaWJ1dGU+LkdldEF0dHJpYnV0ZShtZXRob2QsIGZhbHNlKSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIFNldFVwID0gbWV0aG9kO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIGlmIChBdHRyaWJ1dGVIZWxwZXI8VGVhckRvd25BdHRyaWJ1dGU+LkdldEF0dHJpYnV0ZShtZXRob2QsIGZhbHNlKSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIFRlYXJEb3duID0gbWV0aG9kO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciB0ZXN0QXR0cmlidXRlID0gQXR0cmlidXRlSGVscGVyPFRlc3RBdHRyaWJ1dGU+LkdldEF0dHJpYnV0ZShtZXRob2QsIGZhbHNlKTtcclxuICAgICAgICAgICAgICAgIGlmICh0ZXN0QXR0cmlidXRlICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHRlc3QgPSBuZXcgVGVzdE1ldGhvZCh0aGlzLCBtZXRob2QsIHRlc3RBdHRyaWJ1dGUuTmFtZSwgdGVzdEF0dHJpYnV0ZS5Jc0V4cGVjdGVkQ291bnRTZXQgPyAoaW50Pyl0ZXN0QXR0cmlidXRlLkV4cGVjdGVkQ291bnQgOiBudWxsKTtcclxuICAgICAgICAgICAgICAgICAgICB2YXIgdGVzdElnbm9yZUF0dHJpYnV0ZSA9IEF0dHJpYnV0ZUhlbHBlcjxJZ25vcmVBdHRyaWJ1dGU+LkdldEF0dHJpYnV0ZShtZXRob2QsIGZhbHNlKTtcclxuICAgICAgICAgICAgICAgICAgICBpZiAodGVzdElnbm9yZUF0dHJpYnV0ZSAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdGVzdC5Ta2lwID0gdHJ1ZTtcclxuICAgICAgICAgICAgICAgICAgICAgICAgdGVzdC5Ta2lwUmVhc29uID0gdGVzdElnbm9yZUF0dHJpYnV0ZS5SZWFzb247XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgICAgIHRlc3RNZXRob2RzLkFkZCh0ZXN0KTtcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgVGVzdHMgPSB0ZXN0TWV0aG9kcztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtLlJlZmxlY3Rpb247XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQ29yZVxyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JrQu9Cw0YHRgSDQtNC70Y8g0L/RgNC10LTRgdGC0LDQstC70LXQvdC40Y8g0YLQtdGB0YLQvtCy0L7Qs9C+INC80LXRgtC+0LTQsCDQstC90YPRgtGA0Lgg0YTRgNC10LnQvNCy0L7RgNC60LBcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgVGVzdE1ldGhvZCA6IElUZXN0TWV0aG9kXHJcbiAgICB7XHJcbiAgICAgICAgI3JlZ2lvbiBjdG9yXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YHRgtGA0YPQutGC0L7RgCDRgtC10YHRgtCwINGBINC40LzQtdC90LXQvCDQutCw0Log0YMg0L/QtdGA0LXQtNCw0L3QvdC+0LPQviDQvNC10YLQvtC00LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInRlc3RGaXh0dXJlXCI+0JzQvtC00YPQu9GMPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXRob2RcIj7QnNC10YLQvtC0PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgVGVzdE1ldGhvZChJVGVzdEZpeHR1cmUgdGVzdEZpeHR1cmUsIE1ldGhvZEluZm8gbWV0aG9kKSA6IHRoaXModGVzdEZpeHR1cmUsIG1ldGhvZCwgbWV0aG9kLk5hbWUpIHsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCa0L7QvdGB0YLRgNGD0LrRgtC+0YAg0YLQtdGB0YLQsCDRgSDQt9Cw0LTQsNC90L3Ri9C8INC40LzQtdC90LXQvFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidGVzdEZpeHR1cmVcIj7QnNC+0LTRg9C70Yw8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1ldGhvZFwiPtCc0LXRgtC+0LQ8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y8g0YLQtdGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFRlc3RNZXRob2QoSVRlc3RGaXh0dXJlIHRlc3RGaXh0dXJlLCBNZXRob2RJbmZvIG1ldGhvZCwgc3RyaW5nIG5hbWUpIDogdGhpcyh0ZXN0Rml4dHVyZSwgbWV0aG9kLCBtZXRob2QuTmFtZSwgbnVsbCkgeyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JrQvtC90YHRgtGA0YPQutGC0L7RgCDRgtC10YHRgtCwINGBINC30LDQtNCw0L3QvdGL0Lwg0LjQvNC10L3QtdC8INC4INC+0L/RgNC10LTQtdC70LXQvdC90YvQvCDQutC+0LvQuNGH0LXRgdGC0LLQvtC8INC/0YDQvtCy0LXRgNC+0LpcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInRlc3RGaXh0dXJlXCI+0JzQvtC00YPQu9GMPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtZXRob2RcIj7QnNC10YLQvtC0PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJuYW1lXCI+0JjQvNGPINGC0LXRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImV4cGVjdGVkQ291bnRcIj7QntC20LjQtNCw0LXQvNC+0LUg0LrQvtC70LjRh9C10YHRgtCy0L4g0L/RgNC+0LLQtdGA0L7QujwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFRlc3RNZXRob2QoSVRlc3RGaXh0dXJlIHRlc3RGaXh0dXJlLCBNZXRob2RJbmZvIG1ldGhvZCwgc3RyaW5nIG5hbWUsIGludD8gZXhwZWN0ZWRDb3VudClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEZpeHR1cmUgPSB0ZXN0Rml4dHVyZTtcclxuICAgICAgICAgICAgTmFtZSA9IG5hbWUgPz8gbWV0aG9kLk5hbWU7XHJcbiAgICAgICAgICAgIE1ldGhvZCA9IG1ldGhvZDtcclxuICAgICAgICAgICAgRnVsbE5hbWUgPSBtZXRob2QuU2NyaXB0TmFtZTtcclxuXHJcbiAgICAgICAgICAgIGlmIChleHBlY3RlZENvdW50Lkhhc1ZhbHVlKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBFeHBlY3RlZENvdW50ID0gZXhwZWN0ZWRDb3VudC5WYWx1ZTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBNZXRob2RJbmZvIE1ldGhvZCB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIE5hbWUgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBzdHJpbmcgRnVsbE5hbWUgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBpbnQ/IEV4cGVjdGVkQ291bnQgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBJVGVzdEZpeHR1cmUgRml4dHVyZSB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgYm9vbCBTa2lwIHsgZ2V0OyBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgc3RyaW5nIFNraXBSZWFzb24geyBnZXQ7IHNldDsgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7XHJcbnVzaW5nIFN5c3RlbS5UaHJlYWRpbmcuVGFza3M7XHJcbnVzaW5nIEJyaWRnZS5RVW5pdDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmU7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbXBvbmVudE1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5IZWxwZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Ob3RpZmljYXRpb247XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLlJlc3VsdHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLlNlcnZpY2VzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkNvcmVcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCh0LXRgNCy0LjRgSDQtNC70Y8g0LfQsNC/0YPRgdC60LAg0YLQtdGB0YLQvtCyXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgW1NlcnZpY2VdXHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgVGVzdFJ1bm5lciA6IElUZXN0UnVubmVyXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJVGVzdEZhY3RvcnkgdGVzdEZhY3Rvcnk7XHJcbiAgICAgICAgcHJpdmF0ZSBib29sIGhhc1N0YXJ0ZWQ7XHJcbiAgICAgICAgcHJpdmF0ZSBUZXN0Q29udGV4dCBjb250ZXh0O1xyXG5cclxuICAgICAgICBwdWJsaWMgVGVzdFJ1bm5lcihJVGVzdEZhY3RvcnkgdGVzdEZhY3RvcnkpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB0aGlzLnRlc3RGYWN0b3J5ID0gdGVzdEZhY3Rvcnk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFJ1bihJRW51bWVyYWJsZTxJVGVzdEFzc2VtYmx5PiB0ZXN0QXNzZW1ibGllcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciB0ZXN0QXNzZW1ibGllIGluIHRlc3RBc3NlbWJsaWVzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBSdW4odGVzdEFzc2VtYmxpZSk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUnVuKElUZXN0QXNzZW1ibHkgdGVzdEFzc2VtYmx5KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgUnVuKHRlc3RBc3NlbWJseS5UZXN0Rml4dHVyZXMpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxpbmhlcml0ZG9jLz5cclxuICAgICAgICBwdWJsaWMgdm9pZCBSdW4oSUVudW1lcmFibGU8SVRlc3RGaXh0dXJlPiB0ZXN0Rml4dHVyZXMpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBmb3JlYWNoICh2YXIgdGVzdFN1aXRlIGluIHRlc3RGaXh0dXJlcylcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgUnVuKHRlc3RTdWl0ZSk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8aW5oZXJpdGRvYy8+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUnVuKElUZXN0Rml4dHVyZSB0ZXN0Rml4dHVyZSwgSVRlc3ROb3RpZmllciB0ZXN0Tm90aWZpZXIgPSBudWxsLCBGdW5jPFRhc2s+IHNldHVwID0gbnVsbClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBob29rcyA9IENyZWF0ZUhvb2tzKHRlc3RGaXh0dXJlLCAoRnVuYzxUYXNrPilzZXR1cCk7XHJcblxyXG4gICAgICAgICAgICBTdGFydFFVbml0KCk7XHJcbiAgICAgICAgICAgIGNvbnRleHQuTm90aWZpZXIgPSB0ZXN0Tm90aWZpZXI7XHJcblxyXG4gICAgICAgICAgICBpZiAodGVzdEZpeHR1cmUuU2tpcClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHJlc3VsdCA9IG5ldyBUZXN0Rml4dHVyZVJlc3VsdCh0ZXN0Rml4dHVyZSk7XHJcbiAgICAgICAgICAgICAgICBjb250ZXh0LkN1cnJlbnRSZXN1bHQuQWRkQ2hpbGRSZXN1bHQocmVzdWx0KTtcclxuICAgICAgICAgICAgICAgIFFVbml0SGVscGVyLlNraXBNb2R1bGUodGVzdEZpeHR1cmUuTmFtZSk7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIFFVbml0SGVscGVyLk1vZHVsZSh0ZXN0Rml4dHVyZS5OYW1lLCBob29rcywgKEFjdGlvbikoKCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdGVzdEZpeHR1cmUuSW5zdGFuY2UgPSB0ZXN0RmFjdG9yeS5DcmVhdGVUZXN0KHRlc3RGaXh0dXJlLlR5cGUpO1xyXG5cclxuICAgICAgICAgICAgICAgIGZvcmVhY2ggKHZhciB0ZXN0IGluIHRlc3RGaXh0dXJlLlRlc3RzKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGlmICh0ZXN0ICE9IG51bGwpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBSdW4odGVzdCk7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9KSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFJ1bihJVGVzdE1ldGhvZCB0ZXN0KVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKHRlc3QuU2tpcClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgUVVuaXQuU2tpcCh0ZXN0Lk5hbWUpO1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBRVW5pdC5UZXN0KHRlc3QuTmFtZSwgKEFjdGlvbjxCcmlkZ2UuUVVuaXQuQXNzZXJ0PikoYXNzZXJ0ID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNvbnRleHQuQ3VycmVudFRlc3QgPSB0ZXN0O1xyXG4gICAgICAgICAgICAgICAgdmFyIHJlc3VsdCA9IG5ldyBUZXN0UmVzdWx0KHRlc3QpO1xyXG4gICAgICAgICAgICAgICAgVGVzdENvbnRleHQuQ3VycmVudC5TZXRSZXN1bHQocmVzdWx0KTtcclxuICAgICAgICAgICAgICAgIGNvbnRleHQuQXNzZXJ0ID0gKCkgPT4gYXNzZXJ0O1xyXG5cclxuICAgICAgICAgICAgICAgIGlmICh0ZXN0LkV4cGVjdGVkQ291bnQuSGFzVmFsdWUpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgYXNzZXJ0LkV4cGVjdCh0ZXN0LkV4cGVjdGVkQ291bnQuVmFsdWUpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIHZhciBkb25lID0gYXNzZXJ0LkFzeW5jKCk7XHJcblxyXG4gICAgICAgICAgICAgICAgdGVzdC5NZXRob2QuSW52b2tlKHRlc3QuRml4dHVyZS5JbnN0YW5jZSk7XHJcblxyXG4gICAgICAgICAgICAgICAgZG9uZSgpO1xyXG4gICAgICAgICAgICB9KSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgU3RhcnRRVW5pdCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAoIWhhc1N0YXJ0ZWQpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGhhc1N0YXJ0ZWQgPSB0cnVlO1xyXG4gICAgICAgICAgICAgICAgUVVuaXRIZWxwZXIuTG9hZCgpO1xyXG4gICAgICAgICAgICAgICAgUVVuaXQuU3RhcnQoKTtcclxuICAgICAgICAgICAgICAgIFJlZ2lzdGVyUVVuaXRFdmVudEhhbmRsZXJzKCk7XHJcbiAgICAgICAgICAgICAgICBJbml0aWFsaXplVGVzdEV4ZWN1dGlvbkNvbnRleHQoKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBRVW5pdEhlbHBlci5Nb2R1bGVIb29rcyBDcmVhdGVIb29rcyhJVGVzdEZpeHR1cmUgdGVzdEZpeHR1cmUsIEZ1bmM8VGFzaz4gc2V0dXApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgaG9va3MgPSBuZXcgUVVuaXRIZWxwZXIuTW9kdWxlSG9va3NcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgQmVmb3JlRWFjaCA9ICgpID0+XHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTFcIix0ZXN0Rml4dHVyZS5TZXRVcCkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPFN5c3RlbS5SZWZsZWN0aW9uLk1ldGhvZEluZm8+KFwia2V5MVwiKS5JbnZva2UodGVzdEZpeHR1cmUuSW5zdGFuY2UpOihvYmplY3QpbnVsbDtcclxuICAgICAgICAgICAgICAgIH0sXHJcbiAgICAgICAgICAgICAgICBBZnRlckVhY2ggPSAoKSA9PlxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkyXCIsdGVzdEZpeHR1cmUuVGVhckRvd24pIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxTeXN0ZW0uUmVmbGVjdGlvbi5NZXRob2RJbmZvPihcImtleTJcIikuSW52b2tlKHRlc3RGaXh0dXJlLkluc3RhbmNlKToob2JqZWN0KW51bGw7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH07XHJcblxyXG4gICAgICAgICAgICBpZiAoc2V0dXAgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgaG9va3MuQmVmb3JlID0gbmV3IEZ1bmM8UHJvbWlzZT4oKCkgPT5cclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBTZXRUZXN0Rml4dHVyZSh0ZXN0Rml4dHVyZSk7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIHByb21pc2UgPSBuZXcgUHJvbWlzZSgpO1xyXG4gICAgICAgICAgICAgICAgICAgIHJldHVybiBQcm9taXNlLlByb21pc2lmeSgoRnVuYzxUYXNrPilzZXR1cCkoKTtcclxuICAgICAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIGVsc2VcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgaG9va3MuQmVmb3JlID0gbmV3IEFjdGlvbigoKSA9PiBTZXRUZXN0Rml4dHVyZSh0ZXN0Rml4dHVyZSkpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gaG9va3M7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgU2V0VGVzdEZpeHR1cmUoSVRlc3RGaXh0dXJlIHRlc3RGaXh0dXJlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgY29udGV4dC5DdXJyZW50VGVzdEZpeHR1cmUgPSB0ZXN0Rml4dHVyZTtcclxuICAgICAgICAgICAgdmFyIHJlc3VsdCA9IG5ldyBUZXN0Rml4dHVyZVJlc3VsdCh0ZXN0Rml4dHVyZSk7XHJcbiAgICAgICAgICAgIFRlc3RDb250ZXh0LkN1cnJlbnQuU2V0UmVzdWx0KHJlc3VsdCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHZvaWQgSW5pdGlhbGl6ZVRlc3RFeGVjdXRpb25Db250ZXh0KClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBjb250ZXh0ID0gbmV3IFRlc3RDb250ZXh0KCk7XHJcbiAgICAgICAgICAgIFRlc3RDb250ZXh0LkN1cnJlbnQgPSBjb250ZXh0O1xyXG4gICAgICAgICAgICBUZXN0Q29udGV4dC5DdXJyZW50LlNldFJlc3VsdChuZXcgVGVzdFN1aXRlUmVzdWx0KCkpO1xyXG4gICAgICAgICAgICB0aGlzLmNvbnRleHQgPSBjb250ZXh0O1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSB2b2lkIFJlZ2lzdGVyUVVuaXRFdmVudEhhbmRsZXJzKClcclxuICAgICAgICB7XHJcblN5c3RlbS5BY3Rpb24gUG9wUmVzdWx0ID0gbnVsbDtcbiAgICAgICAgICAgIFxyXG5cclxuICAgICAgICAgICAgUVVuaXQuQmVnaW4oKEFjdGlvbjxUZXN0U3VpdGVCZWdpbkNhbGxiYWNrQXJncz4pKGluZm8gPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTNcIixUZXN0Q29udGV4dC5DdXJyZW50Lk5vdGlmaWVyKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbUxhbWJkYSgoKT0+Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPElUZXN0Tm90aWZpZXI+KFwia2V5M1wiKS5Ob3RpZnlTdGFydChuZXcgVGVzdFN1aXRlSW5mb1xyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIFRlc3RDb3VudCA9IGluZm8uVG90YWxUZXN0c1xyXG4gICAgICAgICAgICAgICAgfSkpOm51bGw7XHJcbiAgICAgICAgICAgIH0pKTtcclxuXHJcbiAgICAgICAgICAgIFFVbml0Lk1vZHVsZVN0YXJ0KChBY3Rpb248TW9kdWxlU3RhcnRDYWxsYmFja0FyZ3M+KShpbmZvID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXk0XCIsVGVzdENvbnRleHQuQ3VycmVudC5Ob3RpZmllcikhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21MYW1iZGEoKCk9Pmdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxJVGVzdE5vdGlmaWVyPihcImtleTRcIikuTm90aWZ5Rml4dHVyZVN0YXJ0KG5ldyBUZXN0Rml4dHVyZUluZm8geyBOYW1lID0gaW5mby5OYW1lIH0pKTpudWxsO1xyXG4gICAgICAgICAgICB9KSk7XHJcblBvcFJlc3VsdCA9ICgpID0+XHJcbntcclxuICAgIFRlc3RDb250ZXh0LkN1cnJlbnQuUG9wUmVzdWx0KCk7XHJcbn1cclxuXHJcbjtcblxyXG4gICAgICAgICAgICBRVW5pdC5Nb2R1bGVEb25lKChBY3Rpb248TW9kdWxlRG9uZUNhbGxiYWNrQXJncz4pKGluZm8gPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHJlc3VsdCA9IGNvbnRleHQuQ3VycmVudFJlc3VsdCBhcyBUZXN0Rml4dHVyZVJlc3VsdDtcclxuICAgICAgICAgICAgICAgIHJlc3VsdC5EdXJhdGlvbiA9IGluZm8uUnVudGltZTtcclxuICAgICAgICAgICAgICAgIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXk1XCIsVGVzdENvbnRleHQuQ3VycmVudC5Ob3RpZmllcikhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21MYW1iZGEoKCk9Pmdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxJVGVzdE5vdGlmaWVyPihcImtleTVcIikuTm90aWZ5Rml4dHVyZURvbmUocmVzdWx0KSk6bnVsbDtcclxuICAgICAgICAgICAgICAgIFBvcFJlc3VsdCgpO1xyXG4gICAgICAgICAgICB9KSk7XHJcblxyXG4gICAgICAgICAgICBRVW5pdC5UZXN0U3RhcnQoKEFjdGlvbjxUZXN0U3RhcnRDYWxsYmFja0FyZ3M+KShpbmZvID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNvbnRleHQuQXNzZXJ0Q291bnRlciA9IDA7XHJcbiAgICAgICAgICAgICAgICBnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5NlwiLGNvbnRleHQuTm90aWZpZXIpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tTGFtYmRhKCgpPT5nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8SVRlc3ROb3RpZmllcj4oXCJrZXk2XCIpLk5vdGlmeVRlc3RTdGFydChuZXcgVGVzdEluZm9cclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBOYW1lID0gaW5mby5OYW1lLFxyXG4gICAgICAgICAgICAgICAgICAgIE1vZHVsZSA9IGluZm8uTW9kdWxlXHJcbiAgICAgICAgICAgICAgICB9KSk6bnVsbDtcclxuICAgICAgICAgICAgfSkpO1xyXG5cclxuICAgICAgICAgICAgUVVuaXQuVGVzdERvbmUoKEFjdGlvbjxUZXN0RG9uZUNhbGxiYWNrQXJncz4pKGluZm8gPT5cclxuICAgICAgICAgICAge1xyXG5UZXN0UmVzdWx0IHJlc3VsdDsgICAgICAgICAgICAgICAgaWYgKChyZXN1bHQgPSBjb250ZXh0LkN1cnJlbnRSZXN1bHQgYXMgVGVzdFJlc3VsdCkgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICByZXN1bHQuRHVyYXRpb24gPSBpbmZvLlJ1bnRpbWU7XHJcbiAgICAgICAgICAgICAgICAgICAgZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTdcIixjb250ZXh0Lk5vdGlmaWVyKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbUxhbWJkYSgoKT0+Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPElUZXN0Tm90aWZpZXI+KFwia2V5N1wiKS5Ob3RpZnlUZXN0RW5kKHJlc3VsdCkpOm51bGw7XHJcbiAgICAgICAgICAgICAgICAgICAgUG9wUmVzdWx0KCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH0pKTtcclxuXHJcbiAgICAgICAgICAgIFFVbml0LkxvZyhpbmZvID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIGNvbnRleHQuQ3VycmVudFJlc3VsdC5BZGRBc3NlcnRSZXN1bHQobmV3IEFzc2VydFJlc3VsdFxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIElkID0gc3RyaW5nLkZvcm1hdChcInswfV9hc3NlcnR7MX1cIixpbmZvW1widGVzdElkXCJdLGNvbnRleHQuQXNzZXJ0Q291bnRlciksXHJcbiAgICAgICAgICAgICAgICAgICAgUGFzc2VkID0gaW5mby5SZXN1bHQsXHJcbiAgICAgICAgICAgICAgICAgICAgQWN0dWFsID0gaW5mby5BY3R1YWwsXHJcbiAgICAgICAgICAgICAgICAgICAgRXhwZWN0ZWQgPSBpbmZvLkV4cGVjdGVkLFxyXG4gICAgICAgICAgICAgICAgICAgIE1lc3NhZ2UgPSBpbmZvLk1lc3NhZ2UgIT0gbnVsbFxyXG4gICAgICAgICAgICAgICAgICAgICAgICA/IGluZm8uTWVzc2FnZVxyXG4gICAgICAgICAgICAgICAgICAgICAgICA6IChpbmZvLlJlc3VsdCA/IFNSLlQoXCLQntC6XCIpIDogU1IuVChcItCf0YDQvtCy0LDQu9C10L3QvlwiKSksXHJcbiAgICAgICAgICAgICAgICAgICAgTmVnYXRpdmUgPSAoYm9vbClpbmZvW1wibmVnYXRpdmVcIl0sXHJcbiAgICAgICAgICAgICAgICAgICAgTW9kdWxlID0gaW5mby5Nb2R1bGUsXHJcbiAgICAgICAgICAgICAgICAgICAgU291cmNlID0gaW5mby5Tb3VyY2VcclxuICAgICAgICAgICAgICAgIH0pO1xyXG5cclxuICAgICAgICAgICAgICAgIGNvbnRleHQuQXNzZXJ0Q291bnRlciArPSAxO1xyXG4gICAgICAgICAgICB9KTtcclxuXHJcbiAgICAgICAgICAgIFFVbml0LkRvbmUoKEFjdGlvbjxUZXN0U3VpdGVEb25lQ2FsbGJhY2tBcmdzPikoaW5mbyA9PlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBoYXNTdGFydGVkID0gZmFsc2U7XHJcbiAgICAgICAgICAgICAgICBpZiAoY29udGV4dCAhPSBudWxsKVxyXG4gICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciByZXN1bHQgPSBjb250ZXh0LkN1cnJlbnRSZXN1bHQ7XHJcbiAgICAgICAgICAgICAgICAgICAgcmVzdWx0LkR1cmF0aW9uID0gaW5mby5SdW50aW1lO1xyXG4gICAgICAgICAgICAgICAgICAgIHJlc3VsdC5TY2VuYXJpb0NvdW50ID0gY29udGV4dC5TY2VuYXJpb0NvdW50O1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciBub3RpZmllciA9IGNvbnRleHQuTm90aWZpZXI7XHJcbiAgICAgICAgICAgICAgICAgICAgbm90aWZpZXIhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21MYW1iZGEoKCk9Pm5vdGlmaWVyLk5vdGlmeUVuZChyZXN1bHQpKTpudWxsO1xyXG4gICAgICAgICAgICAgICAgICAgIFRlc3RDb250ZXh0LkN1cnJlbnQgPSBudWxsO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9KSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59IiwibmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLk1vY2tpbmdcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLQsNGPINGA0LXQsNC70LjQt9Cw0YbQuNGPINC80L7QutCwINGE0YPQvdC60YbQuNC4XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgcHVibGljIGFic3RyYWN0IGNsYXNzIE1vY2sgOiBJTW9ja1xyXG4gICAge1xyXG4gICAgICAgIHByaXZhdGUgaW50IGNhbGxDb3VudGVyID0gMDtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJuYW1lXCI+0JjQvNGPINGE0YPQvdC60YbQuNC4PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgTW9jayhzdHJpbmcgbmFtZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIE5hbWUgPSBuYW1lO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQmNC80Y9cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBzdHJpbmcgTmFtZSB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9GA0L7QstC10YDRj9C10YIsINGH0YLQviDQvNC+0Log0LHRi9C7INCy0YvQt9Cy0LDQvSDRg9C60LDQt9Cw0L3QvdC+0LUg0LrQvtC70LjRh9C10YHRgtCy0L4g0YDQsNC3XHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjb3VudFwiPtCe0LbQuNC00LDQtdC80L7QtSDQutC+0LvQuNGH0LXRgdGC0LLQviDQstGL0LfQvtCy0L7QsjwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIGJvb2wgV2FzQ2FsbGVkKGludCBjb3VudCA9IDApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICByZXR1cm4gY291bnQgPT0gY2FsbENvdW50ZXI7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCj0LLQtdC70LjRh9C40YLRjCDRgdGH0LXRgtGH0LjQuiDQstGL0LfQvtCy0L7QslxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHJvdGVjdGVkIHZvaWQgSW5jcmVtZW50Q2FsbENvdW50ZXIoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgY2FsbENvdW50ZXIrKztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkJERDtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5SZXN1bHRzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQoNC10LfRg9C70YzRgtCw0YIg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBTY2VuYXJpb1Jlc3VsdCA6IFRlc3RTdWl0ZVJlc3VsdCwgSVNjZW5hcmlvUmVzdWx0XHJcbiAgICB7XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzY2VuYXJpb1wiPtCh0YbQtdC90LDRgNC40Lk8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBTY2VuYXJpb1Jlc3VsdChJU2NlbmFyaW8gc2NlbmFyaW8pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBTY2VuYXJpbyA9IHNjZW5hcmlvO1xyXG4gICAgICAgICAgICBTdGVwcyA9IG5ldyBMaXN0PElTdGVwUmVzdWx0PigpO1xyXG4gICAgICAgICAgICBOYW1lID0gU2NlbmFyaW8uTmFtZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KHRhtC10L3QsNGA0LjQuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIElTY2VuYXJpbyBTY2VuYXJpbyB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KjQsNCz0Lgg0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIElDb2xsZWN0aW9uPElTdGVwUmVzdWx0PiBTdGVwcyB7IGdldDsgc2V0OyB9XHJcbiAgICB9XHJcbn0iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5CREQ7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuUmVzdWx0c1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KDQtdC30YPQu9GM0YLQsNGCINCy0YvQv9C+0LvQvdC10L3QuNGPINGI0LDQs9CwINGB0YbQtdC90LDRgNC40Y9cclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgU3RlcFJlc3VsdCA6IFRlc3RTdWl0ZVJlc3VsdCwgSVN0ZXBSZXN1bHRcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInN0ZXBcIj7QqNCw0LM8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBTdGVwUmVzdWx0KElTdGVwIHN0ZXApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBTdGVwID0gc3RlcDtcclxuICAgICAgICAgICAgTmFtZSA9IHN0cmluZy5Gb3JtYXQoXCJ7MH06IHsxfVwiLEVudW0uR2V0TmFtZSh0eXBlb2YoU3RlcFR5cGUpLCBTdGVwLlR5cGUpLFN0ZXAuTmFtZSk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBTdGVwIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG4gICAgfVxyXG59IiwidXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQ29yZTtcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5SZXN1bHRzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQoNC10LfRg9C70YzRgtCw0YIg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YLQtdGB0YLQvtCy0L7Qs9C+INC80L7QtNGD0LvRj1xyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBUZXN0Rml4dHVyZVJlc3VsdCA6IFRlc3RTdWl0ZVJlc3VsdFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gQ3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidGVzdEZpeHR1cmVcIj7QotC10YHRgtC+0LLRi9C5INC80L7QtNGD0LvRjDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFRlc3RGaXh0dXJlUmVzdWx0KElUZXN0Rml4dHVyZSB0ZXN0Rml4dHVyZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIFRlc3RGaXh0dXJlID0gdGVzdEZpeHR1cmU7XHJcbiAgICAgICAgICAgIE5hbWUgPSB0ZXN0Rml4dHVyZS5OYW1lO1xyXG4gICAgICAgICAgICBJZCA9IHRlc3RGaXh0dXJlLlR5cGUuRnVsbE5hbWU7XHJcblxyXG4gICAgICAgICAgICBpZiAodGVzdEZpeHR1cmUuU2tpcClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgU3RhdHVzID0gVGVzdFN0YXR1cy5Ta2lwcGVkO1xyXG4gICAgICAgICAgICAgICAgU2tpcFJlYXNvbiA9IHRlc3RGaXh0dXJlLlNraXBSZWFzb247XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciB0ZXN0IGluIHRlc3RGaXh0dXJlLlRlc3RzKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBpZiAoVGVzdEZpeHR1cmUuU2tpcCB8fCB0ZXN0LlNraXApXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgU2tpcHBlZCArPSAxO1xyXG4gICAgICAgICAgICAgICAgICAgIEFkZENoaWxkUmVzdWx0KG5ldyBUZXN0UmVzdWx0KHRlc3QpXHJcbiAgICAgICAgICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBTdGF0dXMgPSBUZXN0U3RhdHVzLlNraXBwZWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgIFNraXBSZWFzb24gPSB0ZXN0LlNraXBSZWFzb24gPz8gdGVzdEZpeHR1cmUuU2tpcFJlYXNvblxyXG4gICAgICAgICAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LXRgdGC0L7QstGL0Lkg0LzQvtC00YPQu9GMXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgSVRlc3RGaXh0dXJlIFRlc3RGaXh0dXJlIHsgZ2V0OyBwcml2YXRlIHNldDsgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkNvcmU7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuUmVzdWx0c1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KDQtdC30YPQu9GM0YLQsNGCINCy0YvQv9C+0LvQvdC10L3QuNGPINGC0LXRgdGC0LBcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICBpbnRlcm5hbCBzZWFsZWQgY2xhc3MgVGVzdFJlc3VsdCA6IFRlc3RTdWl0ZVJlc3VsdFxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gQ3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidGVzdFwiPtCi0LXRgdGC0L7QstGL0Lkg0LzQtdGC0L7QtDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIFRlc3RSZXN1bHQoSVRlc3RNZXRob2QgdGVzdClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIFRlc3QgPSB0ZXN0O1xyXG4gICAgICAgICAgICBOYW1lID0gdGVzdC5OYW1lO1xyXG4gICAgICAgICAgICBJZCA9IHRlc3QuRnVsbE5hbWU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LXRgdGC0L7QstGL0Lkg0LzQtdGC0L7QtFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIElUZXN0TWV0aG9kIFRlc3QgeyBnZXQ7IHByaXZhdGUgc2V0OyB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uQ29sbGVjdGlvbnM7XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuTG9nZ2luZztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Jb2MuQWJzdHJhY3Q7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkFQSTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLlNlcnZpY2VzXHJcbntcclxuICAgIC8vLyA8c3VtbWFyeT5cclxuICAgIC8vLyDQpNCw0LHRgNC40LrQsCDQtNC70Y8g0YDQsNCx0L7RgtGLINGBINC60L7QvdGC0YDQvtC70LvQtdGA0L7QvFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIHNlYWxlZCBjbGFzcyBUZXN0RmFjdG9yeSA6IElUZXN0RmFjdG9yeVxyXG4gICAge1xyXG4gICAgICAgICNyZWdpb24gUHJpdmF0ZSBEZWZpbml0aW9uc1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUNvbnRhaW5lciBjb250YWluZXI7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJTG9nZ2VyIGxvZ2dlcjtcclxuICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gY3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiY29udGFpbmVyXCI+0JrQvtC90YLQtdC50L3QtdGAPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJsb2dnZXJcIj7Qm9C+0LPQs9C10YA8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBUZXN0RmFjdG9yeShJQ29udGFpbmVyIGNvbnRhaW5lciwgSUxvZ2dlciBsb2dnZXIpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB0aGlzLmNvbnRhaW5lciA9IGNvbnRhaW5lcjtcclxuICAgICAgICAgICAgdGhpcy5sb2dnZXIgPSBsb2dnZXI7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCh0L7Qt9C00LDRgtGMINGN0LrQt9C10LzQv9C70Y/RgCDQutC+0L3RgtGA0L7Qu9C70LXRgNCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVFwiPtCi0LjQvyDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC90eXBlcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCt0LrQt9C10LzQv9C70Y/RgCDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBUIENyZWF0ZVRlc3Q8VD4oKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIChUKUNyZWF0ZVRlc3QodHlwZW9mKFQpKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KHQvtC30LTQsNGC0Ywg0Y3QutC30LXQvNC/0LvRj9GAINC60L7QvdGC0YDQvtC70LvQtdGA0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInR5cGVcIj7QotC40L8g0LrQvtC90YLRgNC+0LvQu9C10YDQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCt0LrQt9C10LzQv9C70Y/RgCDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBvYmplY3QgQ3JlYXRlVGVzdChUeXBlIHR5cGUpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBpZiAodHlwZSA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB0aHJvdyBuZXcgQXJndW1lbnROdWxsRXhjZXB0aW9uKFwidHlwZVwiKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgaWYgKCF0eXBlLklzSW5oZXJpdE9yU2FtZTxJQkREVGVzdD4oKSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIG1lc3NhZ2UgPSBTUi5UKFwi0J/QtdGA0LXQtNCw0L3QvdGL0Lkg0YLQuNC/IHswfSDQvdC1INGP0LLQu9GP0LXRgtGB0Y8gezF9XCIsIHR5cGUuTmFtZSwgXCJJQkREVGVzdFwiKTtcclxuICAgICAgICAgICAgICAgIGxvZ2dlci5FcnJvcihtZXNzYWdlKTtcclxuICAgICAgICAgICAgICAgIHRocm93IG5ldyBFeGNlcHRpb24obWVzc2FnZSk7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBleE1lc3NhZ2UgPSBTUi5UKFwi0J3QtdCy0L7Qt9C80L7QttC90L4g0YHQvtC30LTQsNGC0Ywg0Y3QutC30LXQvNC/0LvRj9GAINC40L3RgtC10YDRhNC10LnRgdCwINC00LvRjyDRgtC40L/QsCB7MH06IHsxfVwiLCB0eXBlLk5hbWUsIHR5cGUpO1xyXG4gICAgICAgICAgICB0cnlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgb2JqZWN0IHRlc3QgPSBudWxsO1xyXG4gICAgICAgICAgICAgICAgaWYgKHR5cGUuSXNDbGFzcylcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICB0ZXN0ID0gY29udGFpbmVyLlJlc29sdmUodHlwZSk7XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICBlbHNlXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGdlbmVyaWNUeXBlID0gdHlwZW9mKElFbnVtZXJhYmxlPD4pLk1ha2VHZW5lcmljVHlwZShuZXdbXSB7IHR5cGUgfSk7XHJcbiAgICAgICAgICAgICAgICAgICAgdmFyIGVudW1lcmFibGUgPSAoSUVudW1lcmFibGUpY29udGFpbmVyLlJlc29sdmUoZ2VuZXJpY1R5cGUpO1xyXG4gICAgICAgICAgICAgICAgICAgIHZhciBlbnVtZXJhdG9yID0gZW51bWVyYWJsZS5HZXRFbnVtZXJhdG9yKCk7XHJcbiAgICAgICAgICAgICAgICAgICAgaWYgKGVudW1lcmF0b3IuTW92ZU5leHQoKSlcclxuICAgICAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgICAgIHRlc3QgPSBlbnVtZXJhdG9yLkN1cnJlbnQ7XHJcbiAgICAgICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgICAgIGlmICh0ZXN0ID09IG51bGwpXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgbG9nZ2VyLkVycm9yKGV4TWVzc2FnZSk7XHJcbiAgICAgICAgICAgICAgICAgICAgdGhyb3cgbmV3IEV4Y2VwdGlvbihleE1lc3NhZ2UpO1xyXG4gICAgICAgICAgICAgICAgfVxyXG5JQ29tcG9uZW50VGVzdCBjb21wb25lbnRUZXN0O1xyXG4gICAgICAgICAgICAgICAgaWYgKChjb21wb25lbnRUZXN0ID0gdGVzdCBhcyBJQ29tcG9uZW50VGVzdCkgIT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBjb21wb25lbnRUZXN0LlRlc3RDb21wb25lbnRDcmVhdG9yU2VydmljZSA9IGNvbnRhaW5lci5SZXNvbHZlPElUZXN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2U+KCk7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgcmV0dXJuIHRlc3Q7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgY2F0Y2ggKEV4Y2VwdGlvbiBlKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBsb2dnZXIuRXJyb3IoZXhNZXNzYWdlLCBlKTtcclxuICAgICAgICAgICAgICAgIHRocm93IG5ldyBFeGNlcHRpb24oZXhNZXNzYWdlLCBlKTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5Db2xsZWN0aW9ucy5HZW5lcmljO1xyXG51c2luZyBTeXN0ZW0uTGlucTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgQnJpZGdlO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5NZXRhZGF0YTtcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQWJzdHJhY3Rpb25zLk1ldGFkYXRhLk1vZGVscy5VSS5Nb2RlbHM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Db3JlLkNvbXBvbmVudE1vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Nb2RlbC5NYW5hZ2VycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuU2VydmljZXM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLk1ldGFkYXRhO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuU2NyaXB0cztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Db3JlO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Ob3RpZmljYXRpb247XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLlNlcnZpY2VzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVUkuTWFuYWdlcnM7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmtcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCa0LvQsNGB0YEg0LTQu9GPINGD0L/RgNCw0LLQu9C10L3QuNGPINGC0LXRgdGC0L7QstGL0Lwg0YTRgNC10LnQvNCy0L7RgNC60L7QvFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIFtTZXJ2aWNlXVxyXG4gICAgaW50ZXJuYWwgc2VhbGVkIGNsYXNzIFRlc3RDb250cm9sbGVyIDogSVRlc3RDb250cm9sbGVyXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSBjb25zdCBzdHJpbmcgQ29tcG9uZW50VGVzdHNLZXkgPSBcIkNvbXBvbmVudFRlc3RzXCI7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJVGVzdFJ1bm5lciB0ZXN0UnVubmVyO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSUN1cnJlbnRQYWdlU2VydmljZSBjdXJyZW50UGFnZVNlcnZpY2U7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJU2NyaXB0TG9hZGVyU2VydmljZSBzY3JpcHRMb2FkZXJTZXJ2aWNlO1xyXG4gICAgICAgIHByaXZhdGUgcmVhZG9ubHkgSVRlc3RBc3NlbWJseUJ1aWxkZXIgdGVzdEJ1aWxkZXI7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBDb21wb25lbnRNZXRhZGF0YUl0ZW1NYW5hZ2VyIENvbXBvbmVudE1ldGFkYXRhSXRlbU1hbmFnZXI7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBGaW5kQ29tcG9uZW50U2VydmljZSBmaW5kQ29tcG9uZW50U2VydmljZTtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IElOb3RpZmljYXRpb25TZXJ2aWNlIG5vdGlmaWNhdGlvblNlcnZpY2U7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBJVGVzdEZhY3RvcnkgdGVzdEZhY3Rvcnk7XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J3QsNGB0YLRgNC+0LnQutC4INGC0LXRgdGC0L7QstC+0LPQviDRhNGA0LXQudC80LLQvtGA0LrQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHN0YXRpYyBUZXN0Q29uZmlnIEZyYW1ld29ya0NvbmZpZyB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQl9Cw0LPRgNGD0LbQtdC90L3Ri9C1INGC0LXRgdGC0YtcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBMaXN0PENvbXBvbmVudFRlc3RGaXh0dXJlPiBMb2FkZWRUZXN0cyB7IGdldDsgcHJpdmF0ZSBzZXQ7IH1cclxuXHJcbiAgICAgICAgI3JlZ2lvbiBjdG9yXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JjQvdC40YbQuNCw0LvQuNC30LjRgNC+0LLQsNGC0Ywg0LrQvtC90YLRgNC+0LvQu9C10YAg0YEg0LfQsNC00LDQvdC90YvQvNC4INC90LDRgdGC0YDQvtC50LrQsNC80LhcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInRlc3RSdW5uZXJcIj7QodC10YDQstC40YEg0LfQsNC/0YPRgdC60LAg0YLQtdGB0YLQvtCyPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJjdXJyZW50UGFnZVNlcnZpY2VcIj7QodC10YDQstC40YEg0YLQtdC60YPRidC10Lkg0YHRgtGA0LDQvdC40YbRizwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwic2NyaXB0TG9hZGVyU2VydmljZVwiPtCh0LXRgNCy0LjRgSDQtNC70Y8g0LfQsNCz0YDRg9C30LrQuCDRgdC60YDQuNC/0YLQvtCyPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJub3RpZmljYXRpb25TZXJ2aWNlXCI+0KHQtdGA0LLQuNGBINGD0LLQtdC00L7QvNC70LXQvdC40Lk8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIkNvbXBvbmVudE1ldGFkYXRhSXRlbU1hbmFnZXJcIj7QnNC10L3QtdC00LbQtdGAINC00LvRjyDRgNCw0LHQvtGC0Ysg0YEg0LrQvtC80L/QvtC90LXQvdGC0LDQvNC4PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJmaW5kQ29tcG9uZW50U2VydmljZVwiPtCh0LXRgNCy0LjRgSDQv9C+0LjRgdC60LAg0LrQvtC80L/QvtC90LXQvdGC0L7QsjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidGVzdEZhY3RvcnlcIj7QpNCw0LHRgNC40LrQsCDQtNC70Y8g0YDQsNCx0L7RgtGLINGBINGC0LXRgdGC0LDQvNC4PC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgVGVzdENvbnRyb2xsZXIoXHJcbiAgICAgICAgICAgIElUZXN0UnVubmVyIHRlc3RSdW5uZXIsXHJcbiAgICAgICAgICAgIElDdXJyZW50UGFnZVNlcnZpY2UgY3VycmVudFBhZ2VTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJU2NyaXB0TG9hZGVyU2VydmljZSBzY3JpcHRMb2FkZXJTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJTm90aWZpY2F0aW9uU2VydmljZSBub3RpZmljYXRpb25TZXJ2aWNlLFxyXG4gICAgICAgICAgICBDb21wb25lbnRNZXRhZGF0YUl0ZW1NYW5hZ2VyIENvbXBvbmVudE1ldGFkYXRhSXRlbU1hbmFnZXIsXHJcbiAgICAgICAgICAgIEZpbmRDb21wb25lbnRTZXJ2aWNlIGZpbmRDb21wb25lbnRTZXJ2aWNlLFxyXG4gICAgICAgICAgICBJVGVzdEZhY3RvcnkgdGVzdEZhY3RvcnlcclxuICAgICAgICApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB0aGlzLmN1cnJlbnRQYWdlU2VydmljZSA9IGN1cnJlbnRQYWdlU2VydmljZTtcclxuICAgICAgICAgICAgdGhpcy50ZXN0UnVubmVyID0gdGVzdFJ1bm5lcjtcclxuICAgICAgICAgICAgdGhpcy5zY3JpcHRMb2FkZXJTZXJ2aWNlID0gc2NyaXB0TG9hZGVyU2VydmljZTtcclxuICAgICAgICAgICAgdGhpcy5ub3RpZmljYXRpb25TZXJ2aWNlID0gbm90aWZpY2F0aW9uU2VydmljZTtcclxuICAgICAgICAgICAgdGhpcy5Db21wb25lbnRNZXRhZGF0YUl0ZW1NYW5hZ2VyID0gQ29tcG9uZW50TWV0YWRhdGFJdGVtTWFuYWdlcjtcclxuICAgICAgICAgICAgdGhpcy5maW5kQ29tcG9uZW50U2VydmljZSA9IGZpbmRDb21wb25lbnRTZXJ2aWNlO1xyXG4gICAgICAgICAgICB0aGlzLnRlc3RGYWN0b3J5ID0gdGVzdEZhY3Rvcnk7XHJcblxyXG4gICAgICAgICAgICB0ZXN0QnVpbGRlciA9IG5ldyBUZXN0QXNzZW1ibHlCdWlsZGVyKCk7XHJcbiAgICAgICAgICAgIEZyYW1ld29ya0NvbmZpZyA9IG5ldyBUZXN0Q29uZmlnKCk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC/0YPRgdGC0LjRgtGMINGC0LXRgdGCINC60L7QvNC/0L7QvdC10L3RgtCwINC/0L4g0YLQuNC/0YNcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImNvbXBvbmVudFVpZFwiPtCj0L3QuNC60LDQu9GM0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAINC60L7QvNC/0L7QvdC10L3RgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJub3RpZmllclwiPtCd0L7RgtC40YTQuNC60LDRgtC+0YAg0LTQu9GPINGC0LXQutGD0YnQtdCz0L4g0LfQsNC/0YPRgdC60LA8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyB2b2lkIFJ1bkNvbXBvbmVudFRlc3RzKEd1aWQgY29tcG9uZW50VWlkLCBJVGVzdE5vdGlmaWVyIG5vdGlmaWVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHBhZ2VNb2RlbCA9IGN1cnJlbnRQYWdlU2VydmljZS5DdXJyZW50UGFnZVZpZXdNb2RlbDtcclxuICAgICAgICAgICAgdmFyIGFzc2VtYmx5TmFtZSA9IHBhZ2VNb2RlbC5DbGllbnRTY3JpcHRNb2R1bGUuQXNzZW1ibHlOYW1lO1xyXG4gICAgICAgICAgICB2YXIgbW9kdWxlT2JqZWN0ID0gc2NyaXB0TG9hZGVyU2VydmljZS5Mb2FkTW9kdWxlKGFzc2VtYmx5TmFtZSk7XHJcbiAgICAgICAgICAgIGlmIChtb2R1bGVPYmplY3QgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgbWV0YWRhdGEgPSBwYWdlTW9kZWwuTWV0YWRhdGEgYXMgSUNvZGVJdGVtTWV0YWRhdGE7XHJcbiAgICAgICAgICAgIGlmIChtZXRhZGF0YSA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBAbmFtZXNwYWNlID0gbWV0YWRhdGEuR2V0VHlwZUZyb21Nb2R1bGUobW9kdWxlT2JqZWN0KTtcclxuICAgICAgICAgICAgaWYgKEBuYW1lc3BhY2UgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgdHlwZSA9IFNjcmlwdC5Xcml0ZTxUeXBlPihcInswfVt7MX1dXCIsIEBuYW1lc3BhY2UsIENvbXBvbmVudFRlc3RzS2V5KTtcclxuICAgICAgICAgICAgaWYgKHR5cGUgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgdGVzdEZpeHR1cmUgPSBuZXcgVGVzdEZpeHR1cmUodHlwZSk7XHJcbiAgICAgICAgICAgIGlmICghU3lzdGVtLkxpbnEuRW51bWVyYWJsZS5Bbnk8SVRlc3RNZXRob2Q+KHRlc3RGaXh0dXJlLlRlc3RzKSlcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgbm90aWZpY2F0aW9uU2VydmljZS5XYXJuaW5nKFNSLlQoXCLQl9Cw0L/Rg9GB0Log0YLQtdGB0YLQvtCyXCIpLCBTUi5UKFwi0J3QtSDQvdCw0LnQtNC10L3RiyDRgtC10YHRgtGLINC00LvRjyDQt9Cw0L/Rg9GB0LrQsFwiKSk7XHJcbiAgICAgICAgICAgICAgICByZXR1cm47XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHRlc3RSdW5uZXIuUnVuKHRlc3RGaXh0dXJlLCBub3RpZmllcik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBhc3luYyBUYXNrPENvbXBvbmVudFRlc3RGaXh0dXJlVHJlZT4gTG9hZENvbXBvbmVudFRlc3RzKClcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBjb21wb25lbnRIZWFkZXJzID0gYXdhaXQgQ29tcG9uZW50TWV0YWRhdGFJdGVtTWFuYWdlci5HZXRBbGxIZWFkZXJzKCk7XHJcbiAgICAgICAgICAgIHZhciBjb21wb25lbnRDb3VudCA9IFN5c3RlbS5MaW5xLkVudW1lcmFibGUuQ291bnQ8Q29tcG9uZW50TWV0YWRhdGFJdGVtSGVhZGVyPihjb21wb25lbnRIZWFkZXJzKTtcclxuICAgICAgICAgICAgdmFyIHRvdGFsVGVzdENvdW50ID0gMDtcclxuICAgICAgICAgICAgdmFyIHRlc3RDb21wb25lbnRDb3VudCA9IDA7XHJcblxyXG4gICAgICAgICAgICB2YXIgY29tcG9uZW50VGVzdHMgPSBuZXcgTGlzdDxDb21wb25lbnRUZXN0Rml4dHVyZT4oKTtcclxuXHJcbiAgICAgICAgICAgIGZvcmVhY2ggKHZhciBjb21wb25lbnRIZWFkZXIgaW4gY29tcG9uZW50SGVhZGVycylcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIGNvbXBvbmVudFRlc3RNb2R1bGUgPSBuZXcgQ29tcG9uZW50VGVzdEZpeHR1cmUoKTtcclxuICAgICAgICAgICAgICAgIHZhciB0eXBlID0gYXdhaXQgR2V0VHlwZShjb21wb25lbnRIZWFkZXIpO1xyXG4gICAgICAgICAgICAgICAgaWYgKHR5cGUgPT0gbnVsbClcclxuICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICBjb250aW51ZTtcclxuICAgICAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgICAgICB2YXIgdGVzdEZpeHR1cmUgPSBuZXcgVGVzdEZpeHR1cmUodHlwZSwgY29tcG9uZW50SGVhZGVyLkRpc3BsYXlOYW1lKTtcclxuICAgICAgICAgICAgICAgIHZhciB0ZXN0Q291bnQgPSBTeXN0ZW0uTGlucS5FbnVtZXJhYmxlLkNvdW50PElUZXN0TWV0aG9kPih0ZXN0Rml4dHVyZS5UZXN0cyk7XHJcbiAgICAgICAgICAgICAgICBpZiAodGVzdENvdW50ID09IDApXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgY29udGludWU7XHJcbiAgICAgICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICAgICAgdGVzdENvbXBvbmVudENvdW50Kys7XHJcbiAgICAgICAgICAgICAgICB0b3RhbFRlc3RDb3VudCArPSB0ZXN0Q291bnQ7XHJcbiAgICAgICAgICAgICAgICBjb21wb25lbnRUZXN0cy5BZGQobmV3IENvbXBvbmVudFRlc3RGaXh0dXJlXHJcbiAgICAgICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICAgICAgSGVhZGVyID0gY29tcG9uZW50SGVhZGVyLFxyXG4gICAgICAgICAgICAgICAgICAgIFRlc3RGaXh0dXJlID0gdGVzdEZpeHR1cmVcclxuICAgICAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICB2YXIgY29tcG9uZW50VGVzdE1vZHVsZVRyZWUgPSBuZXcgQ29tcG9uZW50VGVzdEZpeHR1cmVUcmVlXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIENvbXBvbmVudENvdW50ID0gY29tcG9uZW50Q291bnQsXHJcbiAgICAgICAgICAgICAgICBUZXN0Q29tcG9uZW50Q291bnQgPSB0ZXN0Q29tcG9uZW50Q291bnQsXHJcbiAgICAgICAgICAgICAgICBUb3RhbFRlc3RzQ291bnQgPSB0b3RhbFRlc3RDb3VudCxcclxuICAgICAgICAgICAgICAgIFRlc3RNb2R1bGVzID0gY29tcG9uZW50VGVzdHNcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIExvYWRlZFRlc3RzID0gY29tcG9uZW50VGVzdHM7XHJcblxyXG4gICAgICAgICAgICByZXR1cm4gY29tcG9uZW50VGVzdE1vZHVsZVRyZWU7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPGluaGVyaXRkb2MvPlxyXG4gICAgICAgIHB1YmxpYyBUYXNrIFJ1bkNvbXBvbmVudFRlc3RzKElUZXN0Tm90aWZpZXIgdGVzdE5vdGlmaWVyKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgaWYgKExvYWRlZFRlc3RzID09IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHRocm93IG5ldyBJbnZhbGlkT3BlcmF0aW9uRXhjZXB0aW9uKFNSLlQoXCLQotC10YHRgtGLINC60L7QvNC/0L7QvdC10L3RgtC+0LIg0L3QtSDQsdGL0LvQuCDQt9Cw0LPRgNGD0LbQtdC90YtcIikpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBmb3JlYWNoICh2YXIgY29tcG9uZW50VGVzdCBpbiBMb2FkZWRUZXN0cylcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdGVzdFJ1bm5lci5SdW4oY29tcG9uZW50VGVzdC5UZXN0Rml4dHVyZSwgdGVzdE5vdGlmaWVyLCAoRnVuYzxUYXNrPiluZXcgRnVuYzxUYXNrPihhc3luYyAoKSA9PlxyXG4gICAgICAgICAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgYXdhaXQgY3VycmVudFBhZ2VTZXJ2aWNlLlNldEN1cnJlbnRQYWdlVWlkQXN5bmMoXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBjb21wb25lbnRUZXN0LkhlYWRlci5Nb2R1bGVVaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBjb21wb25lbnRUZXN0LkhlYWRlci5VaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBjb21wb25lbnRUZXN0LkhlYWRlci5NZXRhZGF0YVR5cGVVaWQsXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICBJbnRlcmZhY2VCdWlsZGVyVmlld01vZGUuRW11bGF0aW9uXHJcbiAgICAgICAgICAgICAgICAgICAgICAgICk7XHJcblxyXG4gICAgICAgICAgICAgICAgICAgICAgICB2YXIgdHlwZSA9IGF3YWl0IEdldFR5cGUoY29tcG9uZW50VGVzdC5IZWFkZXIpO1xyXG4gICAgICAgICAgICAgICAgICAgICAgICBjb21wb25lbnRUZXN0LlRlc3RGaXh0dXJlLkluc3RhbmNlID0gdGVzdEZhY3RvcnkuQ3JlYXRlVGVzdCh0eXBlKTtcclxuICAgICAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICAgICApKTtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgcmV0dXJuIFRhc2suQ29tcGxldGVkVGFzaztcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC/0YPRgdGC0LjRgtGMINGC0LXRgdGC0Ysg0LLQviDQstGB0LXRhSDRgdCx0L7RgNC60LDRhVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIHZvaWQgUnVuVGVzdHMoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHRlc3RBc3NlbWJsaWVzID0gdGVzdEJ1aWxkZXIuQnVpbGQoQXBwRG9tYWluLkN1cnJlbnREb21haW4uR2V0QXNzZW1ibGllcygpKTtcclxuICAgICAgICAgICAgdGVzdFJ1bm5lci5SdW4odGVzdEFzc2VtYmxpZXMpO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBhc3luYyBUYXNrPFR5cGU+IEdldFR5cGUoQ29tcG9uZW50TWV0YWRhdGFJdGVtSGVhZGVyIGNvbXBvbmVudEhlYWRlcilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBtb2RlbCA9IGF3YWl0IGZpbmRDb21wb25lbnRTZXJ2aWNlLkZpbmRDb21wb25lbnQoY29tcG9uZW50SGVhZGVyLlVpZCwgSW50ZXJmYWNlQnVpbGRlclZpZXdNb2RlLkVtdWxhdGlvbik7XHJcblxyXG4gICAgICAgICAgICBpZiAobW9kZWwgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBjb21wb25lbnRNZXRhZGF0YSA9IENvbXBvbmVudE1ldGFkYXRhSXRlbU1hbmFnZXIuTG9hZE9yTnVsbChtb2RlbC5IZWFkZXIuSXRlbVVpZCk7XHJcbiAgICAgICAgICAgIGlmIChjb21wb25lbnRNZXRhZGF0YSA9PSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICByZXR1cm4gbnVsbDtcclxuICAgICAgICAgICAgfVxyXG5cclxuICAgICAgICAgICAgdmFyIGFzc2VtYmx5TmFtZSA9IGNvbXBvbmVudE1ldGFkYXRhLkNsaWVudFNjcmlwdE1vZHVsZS5Bc3NlbWJseU5hbWU7XHJcbiAgICAgICAgICAgIHZhciBtb2R1bGVPYmplY3QgPSBzY3JpcHRMb2FkZXJTZXJ2aWNlLkxvYWRNb2R1bGUoYXNzZW1ibHlOYW1lKTtcclxuXHJcbiAgICAgICAgICAgIGlmIChtb2R1bGVPYmplY3QgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciBAbmFtZXNwYWNlID0gY29tcG9uZW50TWV0YWRhdGEuTWV0YWRhdGEuR2V0VHlwZUZyb21Nb2R1bGUobW9kdWxlT2JqZWN0KTtcclxuICAgICAgICAgICAgaWYgKEBuYW1lc3BhY2UgPT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgcmV0dXJuIG51bGw7XHJcbiAgICAgICAgICAgIH1cclxuXHJcbiAgICAgICAgICAgIHZhciB0eXBlID0gU2NyaXB0LldyaXRlPFR5cGU+KFwiezB9W3sxfV1cIiwgQG5hbWVzcGFjZSwgQ29tcG9uZW50VGVzdHNLZXkpO1xyXG4gICAgICAgICAgICByZXR1cm4gdHlwZTtcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn0iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5UaHJlYWRpbmcuVGFza3M7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuTW9ja2luZ1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KDQtdCw0LvQuNC30LDRhtC40Y8g0LzQvtC60LAg0LTQu9GPINC/0L7Qu9GM0LfQvtCy0LDRgtC10LvRjNGB0LrQvtC5INGE0YPQvdC60YbQuNC4INCx0LXQtyDQv9Cw0YDQsNC80LXRgtGA0L7QsiDQuCDQstC+0LfQstGA0LDRidCw0LXQvNC+0LPQviDRgNC10LfRg9C70YzRgtCw0YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIGludGVybmFsIGNsYXNzIE1vY2tGdW5jdGlvbiA6IE1vY2tcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IEFjdGlvbiBmbjtcclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyBDdG9yXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJuYW1lXCI+0JjQvNGPINGE0YPQvdC60YbQuNC4PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJmblwiPtCg0LXQsNC70LjQt9Cw0YbQuNGPPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgTW9ja0Z1bmN0aW9uKHN0cmluZyBuYW1lLCBBY3Rpb24gZm4pIDogYmFzZShuYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5mbiA9IGZuO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktGL0L/QvtC70L3QuNGC0Ywg0YTRg9C90LrRhtC40Y5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBUYXNrIENhbGwoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgSW5jcmVtZW50Q2FsbENvdW50ZXIoKTtcclxuICAgICAgICAgICAgZm4oKTtcclxuICAgICAgICAgICAgcmV0dXJuIFRhc2suQ29tcGxldGVkVGFzaztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLk1vY2tpbmdcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCg0LXQsNC70LjQt9Cw0YbQuNGPINC80L7QutCwINC00LvRjyDQv9C+0LvRjNC30L7QstCw0YLQtdC70YzRgdC60L7QuSDRhNGD0L3QutGG0LjQuCDQsdC10Lcg0L/QsNGA0LDQvNC10YLRgNC+0LIsINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LXQuSDRgNC10LfRg9C70YzRgtCw0YJcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVFJlc3VsdFwiPtCi0LjQvyDQstC+0LfQstGA0LDRidCw0LXQvNC+0LPQviDRgNC10LfRg9C70YzRgtCw0YLQsDwvdHlwZXBhcmFtPlxyXG4gICAgaW50ZXJuYWwgY2xhc3MgTW9ja0Z1bmN0aW9uV2l0aE91dHB1dDxUUmVzdWx0PiA6IE1vY2tcclxuICAgIHtcclxuICAgICAgICBwcml2YXRlIHJlYWRvbmx5IEZ1bmM8VFJlc3VsdD4gZm47XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gQ3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCY0LzRjyDRhNGD0L3QutGG0LjQuDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZm5cIj7QoNC10LDQu9C40LfQsNGG0LjRjzwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIE1vY2tGdW5jdGlvbldpdGhPdXRwdXQoc3RyaW5nIG5hbWUsIEZ1bmM8VFJlc3VsdD4gZm4pIDogYmFzZShuYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5mbiA9IGZuO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktGL0L/QvtC70L3QuNGC0Ywg0YTRg9C90LrRhtC40Y5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QoNC10LfRg9C70YzRgtCw0YIg0LLRi9C/0L7Qu9C90LXQvdC40Y8g0YTRg9C90LrRhtC40Lg8L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIFRhc2s8VFJlc3VsdD4gQ2FsbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBJbmNyZW1lbnRDYWxsQ291bnRlcigpO1xyXG4gICAgICAgICAgICByZXR1cm4gVGFzay5Gcm9tUmVzdWx0PFRSZXN1bHQ+KGZuKCkpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG4iLCJ1c2luZyBTeXN0ZW07XHJcbnVzaW5nIFN5c3RlbS5UaHJlYWRpbmcuVGFza3M7XHJcblxyXG5uYW1lc3BhY2UgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuTW9ja2luZ1xyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0KDQtdCw0LvQuNC30LDRhtC40Y8g0LzQvtC60LAg0LTQu9GPINC/0L7Qu9GM0LfQvtCy0LDRgtC10LvRjNGB0LrQvtC5INGE0YPQvdC60YbQuNC4LCDQv9GA0LjQvdC40LzQsNGO0YnQtdC5INCw0YDQs9GD0LzQtdC90YIg0Lgg0L3QtSDQstC+0LfQstGA0LDRidCw0Y7RidC10Lkg0YDQtdC30YPQu9GM0YLQsNGCXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRcIj7QotC40L8g0LDRgNCz0YPQvNC10L3RgtCwPC90eXBlcGFyYW0+XHJcbiAgICBpbnRlcm5hbCBjbGFzcyBNb2NrRnVuY3Rpb25XaXRoUGFyYW08VD4gOiBNb2NrXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBBY3Rpb248VD4gZm47XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8gQ3RvclxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCY0LzRjyDRhNGD0L3QutGG0LjQuDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZm5cIj7QoNC10LDQu9C40LfQsNGG0LjRjzwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIE1vY2tGdW5jdGlvbldpdGhQYXJhbShzdHJpbmcgbmFtZSwgQWN0aW9uPFQ+IGZuKSA6IGJhc2UobmFtZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHRoaXMuZm4gPSBmbjtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JLRi9C/0L7Qu9C90LjRgtGMINGE0YPQvdC60YbQuNGOXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJhcmdcIj7QkNGA0LPRg9C80LXQvdGCPC9wYXJhbT5cclxuICAgICAgICBwdWJsaWMgVGFzayBDYWxsKFQgYXJnKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgSW5jcmVtZW50Q2FsbENvdW50ZXIoKTtcclxuICAgICAgICAgICAgZm4oYXJnKTtcclxuICAgICAgICAgICAgcmV0dXJuIFRhc2suQ29tcGxldGVkVGFzaztcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLk1vY2tpbmdcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCg0LXQsNC70LjQt9Cw0YbQuNGPINC80L7QutCwINC00LvRjyDQv9C+0LvRjNC30L7QstCw0YLQtdC70YzRgdC60L7QuSDRhNGD0L3QutGG0LjQuCwg0L/RgNC40L3QuNC80LDRjtGJ0LXQuSDQsNGA0LPRg9C80LXQvdGCINC4INCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LXQuSDRgNC10LfRg9C70YzRgtCw0YJcclxuICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVFwiPtCi0LjQvyDQsNGA0LPRg9C80LXQvdGC0LA8L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUUmVzdWx0XCI+0KLQuNC/INCy0L7Qt9Cy0YDQsNGJ0LDQtdC80L7Qs9C+INGA0LXQt9GD0LvRjNGC0LDRgtCwPC90eXBlcGFyYW0+XHJcbiAgICBpbnRlcm5hbCBjbGFzcyBNb2NrRnVuY3Rpb25XaXRoUGFyYW1BbmRPdXRwdXQ8VCwgVFJlc3VsdD4gOiBNb2NrXHJcbiAgICB7XHJcbiAgICAgICAgcHJpdmF0ZSByZWFkb25seSBGdW5jPFQsIFRSZXN1bHQ+IGZuO1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vIEN0b3JcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QmNC80Y8g0YTRg9C90LrRhtC40Lg8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImZuXCI+0KDQtdCw0LvQuNC30LDRhtC40Y88L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBNb2NrRnVuY3Rpb25XaXRoUGFyYW1BbmRPdXRwdXQoc3RyaW5nIG5hbWUsIEZ1bmM8VCwgVFJlc3VsdD4gZm4pIDogYmFzZShuYW1lKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdGhpcy5mbiA9IGZuO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQktGL0L/QvtC70L3QuNGC0Ywg0YTRg9C90LrRhtC40Y5cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInBhcmFtXCI+0JDRgNCz0YPQvNC10L3RgjwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCg0LXQt9GD0LvRjNGC0LDRgiDQstGL0L/QvtC70L3QtdC90LjRjyDRhNGD0L3QutGG0LjQuDwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgVGFzazxUUmVzdWx0PiBDYWxsKFQgcGFyYW0pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBJbmNyZW1lbnRDYWxsQ291bnRlcigpO1xyXG4gICAgICAgICAgICByZXR1cm4gVGFzay5Gcm9tUmVzdWx0PFRSZXN1bHQ+KGZuKHBhcmFtKSk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLlRocmVhZGluZy5UYXNrcztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkNvcmUuQ29udHJvbGxlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5IZWxwZXJzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuTW9kZWwuVmlld01vZGVsO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5CREQ7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLlNlcnZpY2VzO1xyXG5cclxubmFtZXNwYWNlIEVsZVdpc2UuRUxNQS5UZXN0RnJhbWV3b3JrLkFQSVxyXG57XHJcbiAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAvLy8g0JHQsNC30L7QstGL0Lkg0LrQu9Cw0YHRgSDRgtC10YHRgtCwINC00LvRjyA8Yz5CYXNlUmVhY3RDb21wb25lbnQ8L2M+XHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250ZXh0XCI+0KLQuNC/INC60L7QvdGC0LXQutGB0YLQsDwvdHlwZXBhcmFtPlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250cm9sbGVyXCI+0KLQuNC/INC60L7QvdGC0YDQvtC70LvQtdGA0LA8L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUSW5wdXRzXCI+0KLQuNC/INC40L3Qv9GD0YLQvtCyPC90eXBlcGFyYW0+XHJcbiAgICBwdWJsaWMgYWJzdHJhY3QgY2xhc3MgQmFzZVJlYWN0Q29tcG9uZW50VGVzdDxUSW5wdXRzLCBUQ29udGV4dCwgVENvbnRyb2xsZXI+IDogVGVzdDxJQmFzZVJlYWN0Q29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlciwgVElucHV0cz4+LCBJQ29tcG9uZW50VGVzdFxyXG4gICAgICAgIHdoZXJlIFRDb250ZXh0IDogSUNvbnRleHRcclxuICAgICAgICB3aGVyZSBUQ29udHJvbGxlciA6IElDb250cm9sbGVyXHJcbiAgICAgICAgd2hlcmUgVElucHV0cyA6IElJbnB1dHNcclxuICAgIHtcclxuICAgICAgICAjcmVnaW9uIFByaXZhdGUgbWVtYmVyc1xyXG5cclxuICAgICAgICBwcml2YXRlIElWaWV3TW9kZWwgdmlld01vZGVsO1xyXG4gICAgICAgIHByaXZhdGUgSUJhc2VSZWFjdENvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXIsIFRJbnB1dHM+IG1vZGVsO1xyXG5cclxuICAgICAgICAjZW5kcmVnaW9uXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KLQuNC/INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgYWJzdHJhY3QgVHlwZSBDb21wb25lbnRUeXBlIHsgZ2V0OyB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0JfQsNC/0YPRgdGC0LjRgtGMINGC0LXRgdGC0L7QstGL0Lkg0YHRhtC10L3QsNGA0LjQuVxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibmFtZVwiPtCd0LDQt9Cy0LDQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cInN0ZXBzXCI+0KjQsNCz0Lgg0YLQtdGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgcHVibGljIG92ZXJyaWRlIHNlYWxlZCB2b2lkIFJ1blNjZW5hcmlvKHN0cmluZyBuYW1lLCBwYXJhbXMgSVN0ZXBbXSBzdGVwcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChzdGVwcy5MZW5ndGggPiAwKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBzdGVwcy5VbnNoaWZ0KFNldHVwKCkpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBiYXNlLlJ1blNjZW5hcmlvKG5hbWUsIHN0ZXBzKTtcclxuICAgICAgICB9XHJcbi8vLyA8c3VtbWFyeT5cclxuLy8vINCk0YPQvdC60YbQuNGPINGB0L7Qt9C00LDQvdC40Y8g0YLQtdGB0YLQvtCy0L7QuSDQvNC+0LTQtdC70Lgg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuLy8vIDwvc3VtbWFyeT5cclxucHJvdGVjdGVkIG92ZXJyaWRlIEZ1bmM8SUJhc2VSZWFjdENvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXIsIFRJbnB1dHM+PiBNb2RlbFxyXG57XHJcbiAgICBnZXRcclxuICAgIHtcclxuICAgICAgICByZXR1cm4gQ3JlYXRlVGVzdE1vZGVsO1xyXG4gICAgfVxyXG59XHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQodC10YDQstC40YEg0LTQu9GPINGB0L7Qt9C00LDQvdC40Y8g0LzQvtC00LXQu9C4INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBJVGVzdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlIElDb21wb25lbnRUZXN0LlRlc3RDb21wb25lbnRDcmVhdG9yU2VydmljZSB7IGdldDsgc2V0OyB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgSUJhc2VSZWFjdENvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXIsIFRJbnB1dHM+IENyZWF0ZVRlc3RNb2RlbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgY29tcG9uZW50Q3JlYXRvciA9ICh0aGlzIGFzIElDb21wb25lbnRUZXN0KS5UZXN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2U7XHJcbiAgICAgICAgICAgIHZpZXdNb2RlbCA9IChJVmlld01vZGVsKWNvbXBvbmVudENyZWF0b3IuQ3JlYXRlQmFzZVJlYWN0Q29tcG9uZW50KENvbXBvbmVudFR5cGUsIHR5cGVvZihUSW5wdXRzKSwgdHlwZW9mKFRDb250ZXh0KSwgdHlwZW9mKFRDb250cm9sbGVyKSk7XHJcbiAgICAgICAgICAgIG1vZGVsID0gbmV3IEJhc2VSZWFjdENvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXIsIFRJbnB1dHM+KHZpZXdNb2RlbC5Db250ZXh0LCB2aWV3TW9kZWwuQ29udHJvbGxlciwgdmlld01vZGVsLklucHV0TW9kZWwuSW5wdXRzKTtcclxuICAgICAgICAgICAgcmV0dXJuIG1vZGVsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBJU3RlcCBTZXR1cCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBY3Rpb24gc2V0dXAgPSAoKSA9PiBUcmlnZ2VyTGlmZUN5Y2xlTWV0aG9kcygpO1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFN0ZXAoc2V0dXAsIENvbXBvbmVudFR5cGUuTmFtZSwgU3RlcFR5cGUuR0lWRU4pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSAgYXN5bmMgdm9pZCBUcmlnZ2VyTGlmZUN5Y2xlTWV0aG9kcygpXHJcbiAgICAgICAge1xyXG5JT25Jbml0IG9uSW5pdENvbnRyb2xsZXI7ICAgICAgICAgICAgaWYgKChvbkluaXRDb250cm9sbGVyID0gbW9kZWwuQ29udHJvbGxlciBhcyBJT25Jbml0KSAhPSBudWxsKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBWaWV3TW9kZWxIZWxwZXIuQ2FsbENvbnRyb2xsZXJNZXRob2QobW9kZWwuQ29udHJvbGxlciwgZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTFcIix0eXBlb2YoSU9uSW5pdCkuR2V0TWV0aG9kKFwiT25Jbml0XCIpKSE9bnVsbD9nbG9iYWw6OkJyaWRnZS5TY3JpcHQuRnJvbVRlbXA8U3lzdGVtLlJlZmxlY3Rpb24uTWV0aG9kSW5mbz4oXCJrZXkxXCIpLlNjcmlwdE5hbWU6KHN0cmluZyludWxsLCBudWxsKTtcclxuICAgICAgICAgICAgfVxyXG5JT25Mb2FkIG9uTG9hZENvbnRyb2xsZXI7XHJcbiAgICAgICAgICAgIGlmICgob25Mb2FkQ29udHJvbGxlciA9IG1vZGVsLkNvbnRyb2xsZXIgYXMgSU9uTG9hZCkgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgVmlld01vZGVsSGVscGVyLkNhbGxDb250cm9sbGVyTWV0aG9kKG1vZGVsLkNvbnRyb2xsZXIsIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkyXCIsdHlwZW9mKElPbkxvYWQpLkdldE1ldGhvZChcIk9uTG9hZFwiKSkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPFN5c3RlbS5SZWZsZWN0aW9uLk1ldGhvZEluZm8+KFwia2V5MlwiKS5TY3JpcHROYW1lOihzdHJpbmcpbnVsbCwgbnVsbCk7XHJcbiAgICAgICAgICAgIH1cclxuSU9uTG9hZEFzeW5jIG9uTG9hZEFzeW5jQ29udHJvbGxlcjtcclxuICAgICAgICAgICAgaWYgKChvbkxvYWRBc3luY0NvbnRyb2xsZXIgPSBtb2RlbC5Db250cm9sbGVyIGFzIElPbkxvYWRBc3luYykgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHRhc2sgPSAoVGFzaylWaWV3TW9kZWxIZWxwZXIuQ2FsbENvbnRyb2xsZXJNZXRob2QobW9kZWwuQ29udHJvbGxlciwgZ2xvYmFsOjpCcmlkZ2UuU2NyaXB0LlRvVGVtcChcImtleTNcIix0eXBlb2YoSU9uTG9hZEFzeW5jKS5HZXRNZXRob2QoXCJPbkxvYWRBc3luY1wiKSkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPFN5c3RlbS5SZWZsZWN0aW9uLk1ldGhvZEluZm8+KFwia2V5M1wiKS5TY3JpcHROYW1lOihzdHJpbmcpbnVsbCwgbnVsbCk7XHJcbiAgICAgICAgICAgICAgICBhd2FpdCB0YXNrLldhaXRUYXNrKCk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICB9XHJcbn1cclxuIiwidXNpbmcgU3lzdGVtO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db250cm9sbGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLkhlbHBlcnM7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3TW9kZWw7XHJcbnVzaW5nIEVsZVdpc2UuRUxNQS5Nb2RlbC5WaWV3cztcclxudXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5TZXJ2aWNlcztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5BUElcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60LvQsNGB0YEg0YLQtdGB0YLQsCDQtNC70Y8gPGM+QmFzZVZpZXdJdGVtQ29tcG9uZW50PC9jPlxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUVmlld0l0ZW1cIj7QotC40L8gPHNlZSBjcmVmPVwiVmlld0l0ZW1cIi8+PC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lPVwiVElucHV0c1wiPtCi0LjQvyDQuNC90L/Rg9GC0L7QsiDQutC+0LzQv9C+0L3QtdC90YLQsDwvdHlwZXBhcmFtPlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250ZXh0XCI+0KLQuNC/INC60L7QvdGC0LXQutGB0YLQsCDQutC+0LzQv9C+0L3QtdC90YLQsDwvdHlwZXBhcmFtPlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250cm9sbGVyXCI+0KLQuNC/INC60L7QvdGC0YDQvtC70LvQtdGA0LAg0LrQvtC80L/QvtC90LXQvdGC0LA8L3R5cGVwYXJhbT5cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBCYXNlVmlld0l0ZW1Db21wb25lbnRUZXN0PFRWaWV3SXRlbSwgVElucHV0cywgVENvbnRleHQsIFRDb250cm9sbGVyPiA6IFRlc3Q8SUJhc2VWaWV3SXRlbUNvbXBvbmVudFRlc3RNb2RlbDxUVmlld0l0ZW0sIFRJbnB1dHMsIFRDb250ZXh0LCBUQ29udHJvbGxlcj4+LCBJQ29tcG9uZW50VGVzdFxyXG4gICAgICAgIHdoZXJlIFRWaWV3SXRlbSA6IElWaWV3SXRlbVxyXG4gICAgICAgIHdoZXJlIFRJbnB1dHMgOiBJSW5wdXRzXHJcbiAgICAgICAgd2hlcmUgVENvbnRleHQgOiBJQ29udGV4dFxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICAjcmVnaW9uIFByaXZhdGUgbWVtYmVyc1xyXG5cclxuICAgICAgICBwcml2YXRlIElWaWV3SXRlbVZpZXdNb2RlbCB2aWV3TW9kZWw7XHJcbiAgICAgICAgcHJpdmF0ZSBJQmFzZVZpZXdJdGVtQ29tcG9uZW50VGVzdE1vZGVsPFRWaWV3SXRlbSwgVElucHV0cywgVENvbnRleHQsIFRDb250cm9sbGVyPiBtb2RlbDtcclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCi0LjQvyDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgcHVibGljIGFic3RyYWN0IFR5cGUgQ29tcG9uZW50VHlwZSB7IGdldDsgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCX0LDQv9GD0YHRgtC40YLRjCDRgtC10YHRgtC+0LLRi9C5INGB0YbQtdC90LDRgNC40LlcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm5hbWVcIj7QndCw0LfQstCw0L3QuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJzdGVwc1wiPtCo0LDQs9C4INGC0LXRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIHB1YmxpYyBvdmVycmlkZSB2b2lkIFJ1blNjZW5hcmlvKHN0cmluZyBuYW1lLCBwYXJhbXMgSVN0ZXBbXSBzdGVwcylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIGlmIChzdGVwcy5MZW5ndGggPiAwKVxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICBzdGVwcy5VbnNoaWZ0KFNldHVwKCkpO1xyXG4gICAgICAgICAgICB9XHJcblxyXG4gICAgICAgICAgICBiYXNlLlJ1blNjZW5hcmlvKG5hbWUsIHN0ZXBzKTtcclxuICAgICAgICB9XHJcbi8vLyA8c3VtbWFyeT5cclxuLy8vINCk0YPQvdC60YbQuNGPINGB0L7Qt9C00LDQvdC40Y8g0YLQtdGB0YLQvtCy0L7QuSDQvNC+0LTQtdC70Lgg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuLy8vIDwvc3VtbWFyeT5cclxucHJvdGVjdGVkIG92ZXJyaWRlIEZ1bmM8SUJhc2VWaWV3SXRlbUNvbXBvbmVudFRlc3RNb2RlbDxUVmlld0l0ZW0sIFRJbnB1dHMsIFRDb250ZXh0LCBUQ29udHJvbGxlcj4+IE1vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiAoKSA9PiBDcmVhdGVUZXN0TW9kZWwoKTtcclxuICAgIH1cclxufVxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KHQtdGA0LLQuNGBINC00LvRjyDRgdC+0LfQtNCw0L3QuNGPINC80L7QtNC10LvQuCDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgSVRlc3RDb21wb25lbnRDcmVhdG9yU2VydmljZSBJQ29tcG9uZW50VGVzdC5UZXN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UgeyBnZXQ7IHNldDsgfVxyXG5cclxuICAgICAgICBwcml2YXRlIElCYXNlVmlld0l0ZW1Db21wb25lbnRUZXN0TW9kZWw8VFZpZXdJdGVtLCBUSW5wdXRzLCBUQ29udGV4dCwgVENvbnRyb2xsZXI+IENyZWF0ZVRlc3RNb2RlbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgY29tcG9uZW50Q3JlYXRvciA9ICh0aGlzIGFzIElDb21wb25lbnRUZXN0KS5UZXN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2U7XHJcbiAgICAgICAgICAgIHZpZXdNb2RlbCA9IChJVmlld0l0ZW1WaWV3TW9kZWwpY29tcG9uZW50Q3JlYXRvci5DcmVhdGVCYXNlVmlld0l0ZW1Db21wb25lbnQoQ29tcG9uZW50VHlwZSwgdHlwZW9mKFRWaWV3SXRlbSksIHR5cGVvZihUQ29udGV4dCksIHR5cGVvZihUQ29udHJvbGxlcikpO1xyXG5cclxuICAgICAgICAgICAgbW9kZWwgPSBuZXcgQmFzZVZpZXdJdGVtQ29tcG9uZW50VGVzdE1vZGVsPFRWaWV3SXRlbSwgVElucHV0cywgVENvbnRleHQsIFRDb250cm9sbGVyPihcclxuICAgICAgICAgICAgICAgIHZpZXdNb2RlbC5WaWV3SXRlbSxcclxuICAgICAgICAgICAgICAgIHZpZXdNb2RlbC5JbnB1dE1vZGVsLklucHV0cyxcclxuICAgICAgICAgICAgICAgIHZpZXdNb2RlbC5Db250ZXh0LFxyXG4gICAgICAgICAgICAgICAgdmlld01vZGVsLkNvbnRyb2xsZXJcclxuICAgICAgICAgICAgKTtcclxuXHJcbiAgICAgICAgICAgIHJldHVybiBtb2RlbDtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgSVN0ZXAgU2V0dXAoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBTdGVwKFRyaWdnZXJMaWZlQ3ljbGVNZXRob2RzLCBDb21wb25lbnRUeXBlLk5hbWUsIFN0ZXBUeXBlLkdJVkVOKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgIGFzeW5jIHZvaWQgVHJpZ2dlckxpZmVDeWNsZU1ldGhvZHMoKVxyXG4gICAgICAgIHtcclxuSU9uSW5pdCBvbkluaXRDb250cm9sbGVyOyAgICAgICAgICAgIGlmICgob25Jbml0Q29udHJvbGxlciA9IG1vZGVsLkNvbnRyb2xsZXIgYXMgSU9uSW5pdCkgIT0gbnVsbClcclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgVmlld01vZGVsSGVscGVyLkNhbGxDb250cm9sbGVyTWV0aG9kKG1vZGVsLkNvbnRyb2xsZXIsIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkxXCIsdHlwZW9mKElPbkluaXQpLkdldE1ldGhvZChcIk9uSW5pdFwiKSkhPW51bGw/Z2xvYmFsOjpCcmlkZ2UuU2NyaXB0LkZyb21UZW1wPFN5c3RlbS5SZWZsZWN0aW9uLk1ldGhvZEluZm8+KFwia2V5MVwiKS5TY3JpcHROYW1lOihzdHJpbmcpbnVsbCwgbnVsbCk7XHJcbiAgICAgICAgICAgIH1cclxuSU9uTG9hZCBvbkxvYWRDb250cm9sbGVyO1xyXG4gICAgICAgICAgICBpZiAoKG9uTG9hZENvbnRyb2xsZXIgPSBtb2RlbC5Db250cm9sbGVyIGFzIElPbkxvYWQpICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIFZpZXdNb2RlbEhlbHBlci5DYWxsQ29udHJvbGxlck1ldGhvZChtb2RlbC5Db250cm9sbGVyLCBnbG9iYWw6OkJyaWRnZS5TY3JpcHQuVG9UZW1wKFwia2V5MlwiLHR5cGVvZihJT25Mb2FkKS5HZXRNZXRob2QoXCJPbkxvYWRcIikpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxTeXN0ZW0uUmVmbGVjdGlvbi5NZXRob2RJbmZvPihcImtleTJcIikuU2NyaXB0TmFtZTooc3RyaW5nKW51bGwsIG51bGwpO1xyXG4gICAgICAgICAgICB9XHJcbklPbkxvYWRBc3luYyBvbkxvYWRBc3luY0NvbnRyb2xsZXI7XHJcbiAgICAgICAgICAgIGlmICgob25Mb2FkQXN5bmNDb250cm9sbGVyID0gbW9kZWwuQ29udHJvbGxlciBhcyBJT25Mb2FkQXN5bmMpICE9IG51bGwpXHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciB0YXNrID0gKFRhc2spVmlld01vZGVsSGVscGVyLkNhbGxDb250cm9sbGVyTWV0aG9kKG1vZGVsLkNvbnRyb2xsZXIsIGdsb2JhbDo6QnJpZGdlLlNjcmlwdC5Ub1RlbXAoXCJrZXkzXCIsdHlwZW9mKElPbkxvYWRBc3luYykuR2V0TWV0aG9kKFwiT25Mb2FkQXN5bmNcIikpIT1udWxsP2dsb2JhbDo6QnJpZGdlLlNjcmlwdC5Gcm9tVGVtcDxTeXN0ZW0uUmVmbGVjdGlvbi5NZXRob2RJbmZvPihcImtleTNcIikuU2NyaXB0TmFtZTooc3RyaW5nKW51bGwsIG51bGwpO1xyXG4gICAgICAgICAgICAgICAgYXdhaXQgdGFzay5XYWl0VGFzaygpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiIsInVzaW5nIFN5c3RlbTtcclxudXNpbmcgU3lzdGVtLkxpbnEuRXhwcmVzc2lvbnM7XHJcbnVzaW5nIFN5c3RlbS5SZWZsZWN0aW9uO1xyXG51c2luZyBTeXN0ZW0uVGhyZWFkaW5nLlRhc2tzO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuQ29yZS5Db250cm9sbGVycztcclxudXNpbmcgRWxlV2lzZS5FTE1BLk1vZGVsLlZpZXdNb2RlbDtcclxudXNpbmcgRWxlV2lzZS5FTE1BLlRlc3RGcmFtZXdvcmsuQkREO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5Nb2NraW5nO1xyXG51c2luZyBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5TZXJ2aWNlcztcclxuXHJcbm5hbWVzcGFjZSBFbGVXaXNlLkVMTUEuVGVzdEZyYW1ld29yay5BUElcclxue1xyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60LvQsNGB0YEg0YLQtdGB0YLQsCDQv9C+0LvRjNC30L7QstCw0YLQtdC70YzRgdC60L7Qs9C+INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250ZXh0XCI+0KLQuNC/INC60L7QvdGC0LXQutGB0YLQsCDQutC+0LzQv9C+0L3QtdC90YLQsDwvdHlwZXBhcmFtPlxyXG4gICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRDb250cm9sbGVyXCI+0KLQuNC/INC60L7QvdGC0YDQvtC70LvQtdGA0LAg0LrQvtC80L/QvtC90LXQvdGC0LA8L3R5cGVwYXJhbT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWUgPSBcIlRTZXJ2ZXJcIj7QotC40L8g0YHQtdGA0LLQtdGA0L3QvtCz0L4g0LrQvtC90YLRgNC+0LvQu9C10YDQsDwvdHlwZXBhcmFtPlxyXG4gICAgcHVibGljIGFic3RyYWN0IGNsYXNzIENvbXBvbmVudFRlc3Q8VENvbnRleHQsIFRDb250cm9sbGVyLCBUU2VydmVyPiA6IFRlc3Q8SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PiwgSUNvbXBvbmVudFRlc3RcclxuICAgICAgICB3aGVyZSBUQ29udGV4dCA6IElDb250ZXh0XHJcbiAgICAgICAgd2hlcmUgVENvbnRyb2xsZXIgOiBJQ2xpZW50Q29udHJvbGxlclxyXG4gICAgICAgIHdoZXJlIFRTZXJ2ZXIgOiBJU2VydmVyQ29udHJvbGxlclxyXG4gICAge1xyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0KPQvdC40LrQsNC70YzQvdGL0Lkg0LjQtNC10L3RgtC40YTQuNC60LDRgtC+0YAg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIHB1YmxpYyBhYnN0cmFjdCBzdHJpbmcgQ29tcG9uZW50VWlkIHsgZ2V0OyB9XHJcblxyXG4gICAgICAgICNyZWdpb24gTW9jayBtZXRob2RzXHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/QvtC00LzQtdC90LjRgtGMINC80LXRgtC+0LQg0YHQtdGA0LLQtdGA0L3QvtCz0L4g0LrQvtC90YLRgNC+0LvQu9C10YDQsCDQsiDRgNCw0LzQutCw0YUg0YLQtdC60YPRidC10LPQviDRgdGG0LXQvdCw0YDQuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDQvNC10YLQvtC0INC60L7QvdGC0YDQvtC70LvQtdGA0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1vY2tGblwiPtCk0YPQvdC60YbQuNGPLCDQutC+0YLQvtGA0LDRjyDQsdGD0LTQtdGCINCy0YvQt9Cy0LDQvdCwINCy0LzQtdGB0YLQviDRg9C60LDQt9Cw0L3QvdC+0LPQviDQvNC10YLQvtC00LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodC70LXQtNGD0Y7RidC40Lkg0YjQsNCzINGB0YbQtdC90LDRgNC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIElTdGVwIE1vY2tTZXJ2ZXIoRXhwcmVzc2lvbjxGdW5jPFRTZXJ2ZXIsIEZ1bmM8VGFzaz4+PiBleHByZXNzaW9uLCBBY3Rpb248VENvbnRleHQ+IG1vY2tGbilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIHZhciBtZXRob2RJbmZvID0gR2V0TWV0aG9kSW5mbyhleHByZXNzaW9uKTtcclxuICAgICAgICAgICAgdmFyIG1ldGhvZE5hbWUgPSBtZXRob2RJbmZvLk5hbWU7XHJcblxyXG4gICAgICAgICAgICBBY3Rpb248SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PiBhY3Rpb24gPSAobW9kZWwpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBtb2NrID0gbmV3IE1vY2tGdW5jdGlvbldpdGhQYXJhbTxUQ29udGV4dD4obWV0aG9kTmFtZSwgbW9ja0ZuKTtcclxuICAgICAgICAgICAgICAgIEZ1bmM8VGFzaz4gc2VydmVyTWV0aG9kID0gKCkgPT4gbW9jay5DYWxsKG1vZGVsLkNvbnRleHQpO1xyXG4gICAgICAgICAgICAgICAgbW9kZWwuQ29udHJvbGxlci5TZXJ2ZXJbbWV0aG9kSW5mby5TY3JpcHROYW1lXSA9IHNlcnZlck1ldGhvZDtcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgVGVzdFN0ZXBXaXRoUGFyYW08SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PihhY3Rpb24sIG1ldGhvZE5hbWUsIFN0ZXBUeXBlLk1PQ0spO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LTQvNC10L3QuNGC0Ywg0YTRg9C90LrRhtC40Y4g0LIg0YDQsNC80LrQsNGFINGC0LXQutGD0YnQtdCz0L4g0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwcmVzc2lvblwiPtCk0YPQvdC60YbQuNGPLCDQstC+0LfQstGA0LDRidCw0Y7RidCw0Y8g0YHQstC+0LnRgdGC0LLQviDQutC+0L3RgtC10LrRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1vY2tGblwiPtCk0YPQvdC60YbQuNGPLCDQutC+0YLQvtGA0YPRjiDQsdGD0LTQtdGCINCy0L7Qt9Cy0YDQsNGJ0LDRgtGMINGD0LrQsNC30LDQvdC90L7QtSDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCh0LvQtdC00YPRjtGJ0LjQuSDRiNCw0LMg0YHRhtC10L3QsNGA0LjRjzwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgSVN0ZXAgTW9ja0FjdGlvbihGdW5jPFRDb250ZXh0LCBGdW5jPFRhc2s+PiBleHByZXNzaW9uLCBBY3Rpb24gbW9ja0ZuKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQWN0aW9uPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPj4gYWN0aW9uID0gKG1vZGVsKSA9PlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcGVydHlOYW1lID0gR2V0UHJvcGVydHlOYW1lKG1vZGVsLkNvbnRleHQsIGV4cHJlc3Npb24obW9kZWwuQ29udGV4dCkpO1xyXG4gICAgICAgICAgICAgICAgdmFyIG1vY2sgPSBuZXcgTW9ja0Z1bmN0aW9uKHByb3BlcnR5TmFtZSwgbW9ja0ZuKTtcclxuICAgICAgICAgICAgICAgIEZ1bmM8VGFzaz4gbWV0aG9kID0gKCkgPT4gbW9jay5DYWxsKCk7XHJcbiAgICAgICAgICAgICAgICBNb2NrUHJvcGVydHkobW9kZWwuQ29udGV4dCwgcHJvcGVydHlOYW1lLCBtZXRob2QpO1xyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFRlc3RTdGVwV2l0aFBhcmFtPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPj4oYWN0aW9uLCBcIk1vY2tBY3Rpb25cIiwgU3RlcFR5cGUuTU9DSyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7QtNC80LXQvdC40YLRjCDRhNGD0L3QutGG0LjRjiDQsiDRgNCw0LzQutCw0YUg0YLQtdC60YPRidC10LPQviDRgdGG0LXQvdCw0YDQuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibW9ja0ZuXCI+0KTRg9C90LrRhtC40Y8sINC60L7RgtC+0YDRg9GOINCx0YPQtNC10YIg0LLQvtC30LLRgNCw0YnQsNGC0Ywg0YPQutCw0LfQsNC90L3QvtC1INGB0LLQvtC50YHRgtCy0L4g0LrQvtC90YLQtdC60YHRgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KHQu9C10LTRg9GO0YnQuNC5INGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBNb2NrQWN0aW9uPFQ+KEZ1bmM8VENvbnRleHQsIEZ1bmM8VCwgVGFzaz4+IGV4cHJlc3Npb24sIEFjdGlvbjxUPiBtb2NrRm4pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBY3Rpb248SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PiBhY3Rpb24gPSAobW9kZWwpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBwcm9wZXJ0eU5hbWUgPSBHZXRQcm9wZXJ0eU5hbWUobW9kZWwuQ29udGV4dCwgZXhwcmVzc2lvbihtb2RlbC5Db250ZXh0KSk7XHJcbiAgICAgICAgICAgICAgICB2YXIgbW9jayA9IG5ldyBNb2NrRnVuY3Rpb25XaXRoUGFyYW08VD4ocHJvcGVydHlOYW1lLCBtb2NrRm4pO1xyXG4gICAgICAgICAgICAgICAgRnVuYzxULCBUYXNrPiBtZXRob2QgPSBwYXJhbSA9PiBtb2NrLkNhbGwocGFyYW0pO1xyXG4gICAgICAgICAgICAgICAgTW9ja1Byb3BlcnR5KG1vZGVsLkNvbnRleHQsIHByb3BlcnR5TmFtZSwgbWV0aG9kKTtcclxuICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBUZXN0U3RlcFdpdGhQYXJhbTxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlcj4+KGFjdGlvbiwgXCJNb2NrQWN0aW9uXCIsIFN0ZXBUeXBlLk1PQ0spO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LTQvNC10L3QuNGC0Ywg0YTRg9C90LrRhtC40Y4g0LIg0YDQsNC80LrQsNGFINGC0LXQutGD0YnQtdCz0L4g0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwcmVzc2lvblwiPtCk0YPQvdC60YbQuNGPLCDQstC+0LfQstGA0LDRidCw0Y7RidCw0Y8g0YHQstC+0LnRgdGC0LLQviDQutC+0L3RgtC10LrRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1vY2tGblwiPtCk0YPQvdC60YbQuNGPLCDQutC+0YLQvtGA0YPRjiDQsdGD0LTQtdGCINCy0L7Qt9Cy0YDQsNGJ0LDRgtGMINGD0LrQsNC30LDQvdC90L7QtSDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCh0LvQtdC00YPRjtGJ0LjQuSDRiNCw0LMg0YHRhtC10L3QsNGA0LjRjzwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgSVN0ZXAgTW9ja0FjdGlvbjxUPihGdW5jPFRDb250ZXh0LCBGdW5jPFRhc2s8VD4+PiBleHByZXNzaW9uLCBGdW5jPFQ+IG1vY2tGbilcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEFjdGlvbjxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlcj4+IGFjdGlvbiA9IChtb2RlbCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IEdldFByb3BlcnR5TmFtZShtb2RlbC5Db250ZXh0LCBleHByZXNzaW9uKG1vZGVsLkNvbnRleHQpKTtcclxuICAgICAgICAgICAgICAgIHZhciBtb2NrID0gbmV3IE1vY2tGdW5jdGlvbldpdGhPdXRwdXQ8VD4ocHJvcGVydHlOYW1lLCBtb2NrRm4pO1xyXG4gICAgICAgICAgICAgICAgRnVuYzxUYXNrPFQ+PiBtZXRob2QgPSAoKSA9PiBtb2NrLkNhbGwoKTtcclxuICAgICAgICAgICAgICAgIE1vY2tQcm9wZXJ0eShtb2RlbC5Db250ZXh0LCBwcm9wZXJ0eU5hbWUsIG1ldGhvZCk7XHJcbiAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgVGVzdFN0ZXBXaXRoUGFyYW08SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PihhY3Rpb24sIFwiTW9ja0FjdGlvblwiLCBTdGVwVHlwZS5NT0NLKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/QvtC00LzQtdC90LjRgtGMINGE0YPQvdC60YbQuNGOINCyINGA0LDQvNC60LDRhSDRgtC10LrRg9GJ0LXQs9C+INGB0YbQtdC90LDRgNC40Y9cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImV4cHJlc3Npb25cIj7QpNGD0L3QutGG0LjRjywg0LLQvtC30LLRgNCw0YnQsNGO0YnQsNGPINGB0LLQvtC50YHRgtCy0L4g0LrQvtC90YLQtdC60YHRgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtb2NrRm5cIj7QpNGD0L3QutGG0LjRjywg0LrQvtGC0L7RgNGD0Y4g0LHRg9C00LXRgiDQstC+0LfQstGA0LDRidCw0YLRjCDRg9C60LDQt9Cw0L3QvdC+0LUg0YHQstC+0LnRgdGC0LLQviDQutC+0L3RgtC10LrRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodC70LXQtNGD0Y7RidC40Lkg0YjQsNCzINGB0YbQtdC90LDRgNC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIElTdGVwIE1vY2tBY3Rpb248VCwgVFJlc3VsdD4oRnVuYzxUQ29udGV4dCwgRnVuYzxULCBUYXNrPFRSZXN1bHQ+Pj4gZXhwcmVzc2lvbiwgRnVuYzxULCBUUmVzdWx0PiBtb2NrRm4pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBY3Rpb248SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PiBhY3Rpb24gPSAobW9kZWwpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBwcm9wZXJ0eU5hbWUgPSBHZXRQcm9wZXJ0eU5hbWUobW9kZWwuQ29udGV4dCwgZXhwcmVzc2lvbihtb2RlbC5Db250ZXh0KSk7XHJcbiAgICAgICAgICAgICAgICB2YXIgbW9jayA9IG5ldyBNb2NrRnVuY3Rpb25XaXRoUGFyYW1BbmRPdXRwdXQ8VCwgVFJlc3VsdD4ocHJvcGVydHlOYW1lLCBtb2NrRm4pO1xyXG4gICAgICAgICAgICAgICAgRnVuYzxULCBUYXNrPFRSZXN1bHQ+PiBtZXRob2QgPSBwYXJhbSA9PiBtb2NrLkNhbGwocGFyYW0pO1xyXG4gICAgICAgICAgICAgICAgTW9ja1Byb3BlcnR5KG1vZGVsLkNvbnRleHQsIHByb3BlcnR5TmFtZSwgbWV0aG9kKTtcclxuICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBUZXN0U3RlcFdpdGhQYXJhbTxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlcj4+KGFjdGlvbiwgXCJNb2NrQWN0aW9uXCIsIFN0ZXBUeXBlLk1PQ0spO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgI2VuZHJlZ2lvblxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCj0YHRgtCw0L3QvtCy0LjRgtGMINC30L3QsNGH0LXQvdC40LUg0YHQstC+0LnRgdGC0LLQsCDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDx0eXBlcGFyYW0gbmFtZT1cIlRcIj7QotC40L8g0YHQstC+0LnRgdGC0LLQsDwvdHlwZXBhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImV4cHJlc3Npb25cIj7QpNGD0L3QutGG0LjRjywg0LLQvtC30LLRgNCw0YnQsNGO0YnQsNGPINGB0LLQvtC50YHRgtCy0L4g0LrQvtC90YLQtdC60YHRgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJ2YWx1ZVwiPtCX0L3QsNGH0LXQvdC40LU8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QqNCw0LMg0YHRhtC10L3QsNGA0LjRjzwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgSVN0ZXAgU2V0VmFsdWU8VD4oRnVuYzxUQ29udGV4dCwgVD4gZXhwcmVzc2lvbiwgVCB2YWx1ZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEFjdGlvbjxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlcj4+IGFjdGlvbiA9IChtb2RlbCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IEdldFByb3BlcnR5TmFtZShtb2RlbC5Db250ZXh0LCBleHByZXNzaW9uKG1vZGVsLkNvbnRleHQpKTtcclxuICAgICAgICAgICAgICAgIEZ1bmM8VD4gZ2V0dGVyID0gKCkgPT4gdmFsdWU7XHJcbiAgICAgICAgICAgICAgICBNb2NrUHJvcGVydHkobW9kZWwuQ29udGV4dCwgcHJvcGVydHlOYW1lLCBnZXR0ZXIpO1xyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFRlc3RTdGVwV2l0aFBhcmFtPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPj4oYWN0aW9uLCBcIlNldFZhbHVlXCIsIFN0ZXBUeXBlLldIRU4pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQo9GB0YLQsNC90L7QstC40YLRjCDQt9C90LDRh9C10L3QuNC1INGB0LLQvtC50YHRgtCy0LAg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUXCI+0KLQuNC/INGB0LLQvtC50YHRgtCy0LA8L3R5cGVwYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmFsdWVGdW5jXCI+0KTRg9C90LrRhtC40Y8g0LLRi9GH0LjRgdC70LXQvdC40Y8g0LfQvdCw0YfQtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCo0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBTZXRWYWx1ZTxUPihGdW5jPFRDb250ZXh0LCBUPiBleHByZXNzaW9uLCBGdW5jPFQ+IHZhbHVlRnVuYylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEFjdGlvbjxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlcj4+IGFjdGlvbiA9IChtb2RlbCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IEdldFByb3BlcnR5TmFtZShtb2RlbC5Db250ZXh0LCBleHByZXNzaW9uKG1vZGVsLkNvbnRleHQpKTtcclxuICAgICAgICAgICAgICAgIE1vY2tQcm9wZXJ0eShtb2RlbC5Db250ZXh0LCBwcm9wZXJ0eU5hbWUsIHZhbHVlRnVuYywgdHJ1ZSk7XHJcbiAgICAgICAgICAgIH07XHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgVGVzdFN0ZXBXaXRoUGFyYW08SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udGV4dCwgVENvbnRyb2xsZXI+PihhY3Rpb24sIFwiU2V0VmFsdWVcIiwgU3RlcFR5cGUuV0hFTik7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCh0LXRgNCy0LjRgSDQtNC70Y8g0YHQvtC30LTQsNC90LjRjyDQvNC+0LTQtdC70Lgg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIElUZXN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2UgSUNvbXBvbmVudFRlc3QuVGVzdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlIHsgZ2V0OyBzZXQ7IH1cclxuLy8vIDxzdW1tYXJ5PlxyXG4vLy8g0KTRg9C90LrRhtC40Y8g0YHQvtC30LTQsNC90LjRjyDRgtC10YHRgtC+0LLQvtC5INC80L7QtNC10LvQuCDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4vLy8gPC9zdW1tYXJ5PlxyXG5wcm90ZWN0ZWQgb3ZlcnJpZGUgRnVuYzxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250ZXh0LCBUQ29udHJvbGxlcj4+IE1vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBDcmVhdGVUZXN0TW9kZWw7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICBwcml2YXRlIElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPiBDcmVhdGVUZXN0TW9kZWwoKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIGNvbXBvbmVudENyZWF0b3IgPSAodGhpcyBhcyBJQ29tcG9uZW50VGVzdCkuVGVzdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlO1xyXG4gICAgICAgICAgICB2YXIgdmlld01vZGVsID0gY29tcG9uZW50Q3JlYXRvci5DcmVhdGVNb2RlbDxJQ29tcG9uZW50Vmlld0l0ZW1WaWV3TW9kZWw+KENvbXBvbmVudFVpZCk7XHJcbiAgICAgICAgICAgIHZhciBtb2RlbCA9IG5ldyBDb21wb25lbnRUZXN0TW9kZWw8VENvbnRleHQsIFRDb250cm9sbGVyPih2aWV3TW9kZWwuQ29udGV4dCwgdmlld01vZGVsLkNvbnRyb2xsZXIpO1xyXG4gICAgICAgICAgICByZXR1cm4gbW9kZWw7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIE1ldGhvZEluZm8gR2V0TWV0aG9kSW5mbyhMYW1iZGFFeHByZXNzaW9uIGV4cHJlc3Npb24pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgdW5hcnlFeHByZXNzaW9uID0gKFVuYXJ5RXhwcmVzc2lvbilleHByZXNzaW9uLkJvZHk7XHJcbiAgICAgICAgICAgIHZhciBtZXRob2RDYWxsRXhwcmVzc2lvbiA9IHVuYXJ5RXhwcmVzc2lvbi5PcGVyYW5kIGFzIE1ldGhvZENhbGxFeHByZXNzaW9uO1xyXG4gICAgICAgICAgICB2YXIgbWV0aG9kSW5mb0V4cHJlc3Npb24gPSAoQ29uc3RhbnRFeHByZXNzaW9uKW1ldGhvZENhbGxFeHByZXNzaW9uLk9iamVjdDtcclxuICAgICAgICAgICAgdmFyIG1ldGhvZEluZm8gPSAoTWV0aG9kSW5mbyltZXRob2RJbmZvRXhwcmVzc2lvbi5WYWx1ZTtcclxuICAgICAgICAgICAgcmV0dXJuIG1ldGhvZEluZm87XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICBwcml2YXRlIHN0cmluZyBHZXRQcm9wZXJ0eU5hbWUob2JqZWN0IHRhcmdldCwgb2JqZWN0IHByb3ApXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBzdHJpbmcgbmFtZSA9IG51bGw7XHJcbiAgICAgICAgICAgIC8qQFxyXG4gICAgICAgICAgICB2YXIga2V5cyA9IE9iamVjdC5nZXRPd25Qcm9wZXJ0eU5hbWVzKHRhcmdldClcclxuICAgICAgICAgICAgZm9yICh2YXIgaSA9IDA7IGkgPCBrZXlzLmxlbmd0aDsgaSsrKSB7XHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcGVydHlEZXNjcmlwdG9yID0gT2JqZWN0LmdldE93blByb3BlcnR5RGVzY3JpcHRvcih0YXJnZXQsIGtleXNbaV0pO1xyXG4gICAgICAgICAgICAgICAgaWYgKHR5cGVvZiBwcm9wZXJ0eURlc2NyaXB0b3IuZ2V0ID09PSBcImZ1bmN0aW9uXCIgJiYgcHJvcGVydHlEZXNjcmlwdG9yLmdldCgpID09PSBwcm9wKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgbmFtZSA9IGtleXNbaV07XHJcbiAgICAgICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgKi9cclxuXHJcbiAgICAgICAgICAgIHJldHVybiBuYW1lO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSB2b2lkIE1vY2tQcm9wZXJ0eShvYmplY3QgdGFyZ2V0LCBzdHJpbmcgcHJvcGVydHlOYW1lLCBvYmplY3QgbW9jaywgYm9vbCBjb21wdXRlZCA9IGZhbHNlKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgLypAXHJcbiAgICAgICAgICAgIHZhciBhdHRyaWJ1dGVzID0ge1xyXG4gICAgICAgICAgICAgICAgY29uZmlndXJhYmxlOiB0cnVlLFxyXG4gICAgICAgICAgICAgICAgZ2V0OiBmdW5jdGlvbigpIHtcclxuICAgICAgICAgICAgICAgICAgICByZXR1cm4gY29tcHV0ZWQgPyBtb2NrKCkgOiBtb2NrO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9O1xyXG5cclxuICAgICAgICAgICAgT2JqZWN0LmRlZmluZVByb3BlcnR5KHRhcmdldCwgcHJvcGVydHlOYW1lLCBhdHRyaWJ1dGVzKTtcclxuICAgICAgICAgICAgKi9cclxuICAgICAgICB9XHJcbiAgICB9XHJcblxyXG4gICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgLy8vINCR0LDQt9C+0LLRi9C5INC60LvQsNGB0YEg0LTQu9GPINGC0LXRgdGC0LAg0L/QvtC70YzQt9C+0LLQsNGC0LXQu9GM0YHQutC+0LPQviDQutC+0LzQv9C+0L3QtdC90YLQsFxyXG4gICAgLy8vIDwvc3VtbWFyeT5cclxuICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUQ29udHJvbGxlclwiPtCi0LjQvyDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC90eXBlcGFyYW0+XHJcbiAgICAvLy8gPHR5cGVwYXJhbSBuYW1lID0gXCJUU2VydmVyXCI+0KLQuNC/INGB0LXRgNCy0LXRgNC90L7Qs9C+INC60L7QvdGC0YDQvtC70LvQtdGA0LA8L3R5cGVwYXJhbT5cclxuICAgIHB1YmxpYyBhYnN0cmFjdCBjbGFzcyBDb21wb25lbnRUZXN0PFRDb250cm9sbGVyLCBUU2VydmVyPiA6IFRlc3Q8SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+LCBJQ29tcG9uZW50VGVzdFxyXG4gICAgICAgIHdoZXJlIFRDb250cm9sbGVyIDogSUNsaWVudENvbnRyb2xsZXJcclxuICAgICAgICB3aGVyZSBUU2VydmVyIDogSVNlcnZlckNvbnRyb2xsZXJcclxuICAgIHtcclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCj0L3QuNC60LDQu9GM0L3Ri9C5INC40LTQtdC90YLQuNGE0LjQutCw0YLQvtGAINC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBwdWJsaWMgYWJzdHJhY3Qgc3RyaW5nIENvbXBvbmVudFVpZCB7IGdldDsgfVxyXG5cclxuICAgICAgICAjcmVnaW9uIE1vY2sgbWV0aG9kc1xyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7QtNC80LXQvdC40YLRjCDQvNC10YLQvtC0INGB0LXRgNCy0LXRgNC90L7Qs9C+INC60L7QvdGC0YDQvtC70LvQtdGA0LAg0LIg0YDQsNC80LrQsNGFINGC0LXQutGD0YnQtdCz0L4g0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwcmVzc2lvblwiPtCk0YPQvdC60YbQuNGPLCDQstC+0LfQstGA0LDRidCw0Y7RidCw0Y8g0LzQtdGC0L7QtCDQutC+0L3RgtGA0L7Qu9C70LXRgNCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtb2NrRm5cIj7QpNGD0L3QutGG0LjRjywg0LrQvtGC0L7RgNCw0Y8g0LHRg9C00LXRgiDQstGL0LfQstCw0L3QsCDQstC80LXRgdGC0L4g0YPQutCw0LfQsNC90L3QvtCz0L4g0LzQtdGC0L7QtNCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KHQu9C10LTRg9GO0YnQuNC5INGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBNb2NrU2VydmVyKEV4cHJlc3Npb248RnVuYzxUU2VydmVyLCBGdW5jPFRhc2s+Pj4gZXhwcmVzc2lvbiwgQWN0aW9uPElDb250ZXh0PiBtb2NrRm4pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgbWV0aG9kSW5mbyA9IEdldE1ldGhvZEluZm8oZXhwcmVzc2lvbik7XHJcbiAgICAgICAgICAgIHZhciBtZXRob2ROYW1lID0gbWV0aG9kSW5mby5OYW1lO1xyXG5cclxuICAgICAgICAgICAgQWN0aW9uPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+PiBhY3Rpb24gPSAobW9kZWwpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBtb2NrID0gbmV3IE1vY2tGdW5jdGlvbldpdGhQYXJhbTxJQ29udGV4dD4obWV0aG9kTmFtZSwgbW9ja0ZuKTtcclxuICAgICAgICAgICAgICAgIEZ1bmM8VGFzaz4gc2VydmVyTWV0aG9kID0gKCkgPT4gbW9jay5DYWxsKG1vZGVsLkNvbnRleHQpO1xyXG4gICAgICAgICAgICAgICAgbW9kZWwuQ29udHJvbGxlci5TZXJ2ZXJbbWV0aG9kSW5mby5TY3JpcHROYW1lXSA9IHNlcnZlck1ldGhvZDtcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgVGVzdFN0ZXBXaXRoUGFyYW08SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+KGFjdGlvbiwgbWV0aG9kTmFtZSwgU3RlcFR5cGUuTU9DSyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7QtNC80LXQvdC40YLRjCDRhNGD0L3QutGG0LjRjiDQsiDRgNCw0LzQutCw0YUg0YLQtdC60YPRidC10LPQviDRgdGG0LXQvdCw0YDQuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibW9ja0ZuXCI+0KTRg9C90LrRhtC40Y8sINC60L7RgtC+0YDRg9GOINCx0YPQtNC10YIg0LLQvtC30LLRgNCw0YnQsNGC0Ywg0YPQutCw0LfQsNC90L3QvtC1INGB0LLQvtC50YHRgtCy0L4g0LrQvtC90YLQtdC60YHRgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KHQu9C10LTRg9GO0YnQuNC5INGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBNb2NrQWN0aW9uKEZ1bmM8SUNvbnRleHQsIEZ1bmM8VGFzaz4+IGV4cHJlc3Npb24sIEFjdGlvbiBtb2NrRm4pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBY3Rpb248SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+IGFjdGlvbiA9IChtb2RlbCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IEdldFByb3BlcnR5TmFtZShtb2RlbC5Db250ZXh0LCBleHByZXNzaW9uKG1vZGVsLkNvbnRleHQpKTtcclxuICAgICAgICAgICAgICAgIHZhciBtb2NrID0gbmV3IE1vY2tGdW5jdGlvbihwcm9wZXJ0eU5hbWUsIG1vY2tGbik7XHJcbiAgICAgICAgICAgICAgICBGdW5jPFRhc2s+IG1ldGhvZCA9ICgpID0+IG1vY2suQ2FsbCgpO1xyXG4gICAgICAgICAgICAgICAgTW9ja1Byb3BlcnR5KG1vZGVsLkNvbnRleHQsIHByb3BlcnR5TmFtZSwgbWV0aG9kKTtcclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIHJldHVybiBuZXcgVGVzdFN0ZXBXaXRoUGFyYW08SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+KGFjdGlvbiwgXCJNb2NrQWN0aW9uXCIsIFN0ZXBUeXBlLk1PQ0spO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQn9C+0LTQvNC10L3QuNGC0Ywg0YTRg9C90LrRhtC40Y4g0LIg0YDQsNC80LrQsNGFINGC0LXQutGD0YnQtdCz0L4g0YHRhtC10L3QsNGA0LjRj1xyXG4gICAgICAgIC8vLyA8L3N1bW1hcnk+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwiZXhwcmVzc2lvblwiPtCk0YPQvdC60YbQuNGPLCDQstC+0LfQstGA0LDRidCw0Y7RidCw0Y8g0YHQstC+0LnRgdGC0LLQviDQutC+0L3RgtC10LrRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cIm1vY2tGblwiPtCk0YPQvdC60YbQuNGPLCDQutC+0YLQvtGA0YPRjiDQsdGD0LTQtdGCINCy0L7Qt9Cy0YDQsNGJ0LDRgtGMINGD0LrQsNC30LDQvdC90L7QtSDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCh0LvQtdC00YPRjtGJ0LjQuSDRiNCw0LMg0YHRhtC10L3QsNGA0LjRjzwvcmV0dXJucz5cclxuICAgICAgICBwdWJsaWMgSVN0ZXAgTW9ja0FjdGlvbjxUPihGdW5jPElDb250ZXh0LCBGdW5jPFQsIFRhc2s+PiBleHByZXNzaW9uLCBBY3Rpb248VD4gbW9ja0ZuKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQWN0aW9uPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+PiBhY3Rpb24gPSAobW9kZWwpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBwcm9wZXJ0eU5hbWUgPSBHZXRQcm9wZXJ0eU5hbWUobW9kZWwuQ29udGV4dCwgZXhwcmVzc2lvbihtb2RlbC5Db250ZXh0KSk7XHJcbiAgICAgICAgICAgICAgICB2YXIgbW9jayA9IG5ldyBNb2NrRnVuY3Rpb25XaXRoUGFyYW08VD4ocHJvcGVydHlOYW1lLCBtb2NrRm4pO1xyXG4gICAgICAgICAgICAgICAgRnVuYzxULCBUYXNrPiBtZXRob2QgPSBwYXJhbSA9PiBtb2NrLkNhbGwocGFyYW0pO1xyXG4gICAgICAgICAgICAgICAgTW9ja1Byb3BlcnR5KG1vZGVsLkNvbnRleHQsIHByb3BlcnR5TmFtZSwgbWV0aG9kKTtcclxuICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBUZXN0U3RlcFdpdGhQYXJhbTxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250cm9sbGVyPj4oYWN0aW9uLCBcIk1vY2tBY3Rpb25cIiwgU3RlcFR5cGUuTU9DSyk7XHJcbiAgICAgICAgfVxyXG5cclxuICAgICAgICAvLy8gPHN1bW1hcnk+XHJcbiAgICAgICAgLy8vINCf0L7QtNC80LXQvdC40YLRjCDRhNGD0L3QutGG0LjRjiDQsiDRgNCw0LzQutCw0YUg0YLQtdC60YPRidC10LPQviDRgdGG0LXQvdCw0YDQuNGPXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwibW9ja0ZuXCI+0KTRg9C90LrRhtC40Y8sINC60L7RgtC+0YDRg9GOINCx0YPQtNC10YIg0LLQvtC30LLRgNCw0YnQsNGC0Ywg0YPQutCw0LfQsNC90L3QvtC1INGB0LLQvtC50YHRgtCy0L4g0LrQvtC90YLQtdC60YHRgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KHQu9C10LTRg9GO0YnQuNC5INGI0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBNb2NrQWN0aW9uPFQ+KEZ1bmM8SUNvbnRleHQsIEZ1bmM8VGFzazxUPj4+IGV4cHJlc3Npb24sIEZ1bmM8VD4gbW9ja0ZuKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgQWN0aW9uPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+PiBhY3Rpb24gPSAobW9kZWwpID0+XHJcbiAgICAgICAgICAgIHtcclxuICAgICAgICAgICAgICAgIHZhciBwcm9wZXJ0eU5hbWUgPSBHZXRQcm9wZXJ0eU5hbWUobW9kZWwuQ29udGV4dCwgZXhwcmVzc2lvbihtb2RlbC5Db250ZXh0KSk7XHJcbiAgICAgICAgICAgICAgICB2YXIgbW9jayA9IG5ldyBNb2NrRnVuY3Rpb25XaXRoT3V0cHV0PFQ+KHByb3BlcnR5TmFtZSwgbW9ja0ZuKTtcclxuICAgICAgICAgICAgICAgIEZ1bmM8VGFzazxUPj4gbWV0aG9kID0gKCkgPT4gbW9jay5DYWxsKCk7XHJcbiAgICAgICAgICAgICAgICBNb2NrUHJvcGVydHkobW9kZWwuQ29udGV4dCwgcHJvcGVydHlOYW1lLCBtZXRob2QpO1xyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFRlc3RTdGVwV2l0aFBhcmFtPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+PihhY3Rpb24sIFwiTW9ja0FjdGlvblwiLCBTdGVwVHlwZS5NT0NLKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIC8vLyA8c3VtbWFyeT5cclxuICAgICAgICAvLy8g0J/QvtC00LzQtdC90LjRgtGMINGE0YPQvdC60YbQuNGOINCyINGA0LDQvNC60LDRhSDRgtC10LrRg9GJ0LXQs9C+INGB0YbQtdC90LDRgNC40Y9cclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8cGFyYW0gbmFtZT1cImV4cHJlc3Npb25cIj7QpNGD0L3QutGG0LjRjywg0LLQvtC30LLRgNCw0YnQsNGO0YnQsNGPINGB0LLQvtC50YHRgtCy0L4g0LrQvtC90YLQtdC60YHRgtCwPC9wYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJtb2NrRm5cIj7QpNGD0L3QutGG0LjRjywg0LrQvtGC0L7RgNGD0Y4g0LHRg9C00LXRgiDQstC+0LfQstGA0LDRidCw0YLRjCDRg9C60LDQt9Cw0L3QvdC+0LUg0YHQstC+0LnRgdGC0LLQviDQutC+0L3RgtC10LrRgdGC0LA8L3BhcmFtPlxyXG4gICAgICAgIC8vLyA8cmV0dXJucz7QodC70LXQtNGD0Y7RidC40Lkg0YjQsNCzINGB0YbQtdC90LDRgNC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIElTdGVwIE1vY2tBY3Rpb248VCwgVFJlc3VsdD4oRnVuYzxJQ29udGV4dCwgRnVuYzxULCBUYXNrPFRSZXN1bHQ+Pj4gZXhwcmVzc2lvbiwgRnVuYzxULCBUUmVzdWx0PiBtb2NrRm4pXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBY3Rpb248SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+IGFjdGlvbiA9IChtb2RlbCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IEdldFByb3BlcnR5TmFtZShtb2RlbC5Db250ZXh0LCBleHByZXNzaW9uKG1vZGVsLkNvbnRleHQpKTtcclxuICAgICAgICAgICAgICAgIHZhciBtb2NrID0gbmV3IE1vY2tGdW5jdGlvbldpdGhQYXJhbUFuZE91dHB1dDxULCBUUmVzdWx0Pihwcm9wZXJ0eU5hbWUsIG1vY2tGbik7XHJcbiAgICAgICAgICAgICAgICBGdW5jPFQsIFRhc2s8VFJlc3VsdD4+IG1ldGhvZCA9IHBhcmFtID0+IG1vY2suQ2FsbChwYXJhbSk7XHJcbiAgICAgICAgICAgICAgICBNb2NrUHJvcGVydHkobW9kZWwuQ29udGV4dCwgcHJvcGVydHlOYW1lLCBtZXRob2QpO1xyXG4gICAgICAgICAgICB9O1xyXG4gICAgICAgICAgICByZXR1cm4gbmV3IFRlc3RTdGVwV2l0aFBhcmFtPElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+PihhY3Rpb24sIFwiTW9ja0FjdGlvblwiLCBTdGVwVHlwZS5NT0NLKTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgICNlbmRyZWdpb25cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQo9GB0YLQsNC90L7QstC40YLRjCDQt9C90LDRh9C10L3QuNC1INGB0LLQvtC50YHRgtCy0LAg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUXCI+0KLQuNC/INGB0LLQvtC50YHRgtCy0LA8L3R5cGVwYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmFsdWVcIj7Ql9C90LDRh9C10L3QuNC1PC9wYXJhbT5cclxuICAgICAgICAvLy8gPHJldHVybnM+0KjQsNCzINGB0YbQtdC90LDRgNC40Y88L3JldHVybnM+XHJcbiAgICAgICAgcHVibGljIElTdGVwIFNldFZhbHVlPFQ+KEZ1bmM8SUNvbnRleHQsIFQ+IGV4cHJlc3Npb24sIFQgdmFsdWUpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICBBY3Rpb248SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+IGFjdGlvbiA9IChtb2RlbCkgPT5cclxuICAgICAgICAgICAge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5TmFtZSA9IEdldFByb3BlcnR5TmFtZShtb2RlbC5Db250ZXh0LCBleHByZXNzaW9uKG1vZGVsLkNvbnRleHQpKTtcclxuICAgICAgICAgICAgICAgIE1vY2tQcm9wZXJ0eShtb2RlbC5Db250ZXh0LCBwcm9wZXJ0eU5hbWUsIHZhbHVlKTtcclxuICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBUZXN0U3RlcFdpdGhQYXJhbTxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250cm9sbGVyPj4oYWN0aW9uLCBcIlNldFZhbHVlXCIsIFN0ZXBUeXBlLldIRU4pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQo9GB0YLQsNC90L7QstC40YLRjCDQt9C90LDRh9C10L3QuNC1INGB0LLQvtC50YHRgtCy0LAg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuICAgICAgICAvLy8gPC9zdW1tYXJ5PlxyXG4gICAgICAgIC8vLyA8dHlwZXBhcmFtIG5hbWU9XCJUXCI+0KLQuNC/INGB0LLQvtC50YHRgtCy0LA8L3R5cGVwYXJhbT5cclxuICAgICAgICAvLy8gPHBhcmFtIG5hbWU9XCJleHByZXNzaW9uXCI+0KTRg9C90LrRhtC40Y8sINCy0L7Qt9Cy0YDQsNGJ0LDRjtGJ0LDRjyDRgdCy0L7QudGB0YLQstC+INC60L7QvdGC0LXQutGB0YLQsDwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxwYXJhbSBuYW1lPVwidmFsdWVGdW5jXCI+0KTRg9C90LrRhtC40Y8g0LLRi9GH0LjRgdC70LXQvdC40Y8g0LfQvdCw0YfQtdC90LjRjzwvcGFyYW0+XHJcbiAgICAgICAgLy8vIDxyZXR1cm5zPtCo0LDQsyDRgdGG0LXQvdCw0YDQuNGPPC9yZXR1cm5zPlxyXG4gICAgICAgIHB1YmxpYyBJU3RlcCBTZXRWYWx1ZTxUPihGdW5jPElDb250ZXh0LCBUPiBleHByZXNzaW9uLCBGdW5jPFQ+IHZhbHVlRnVuYylcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIEFjdGlvbjxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250cm9sbGVyPj4gYWN0aW9uID0gKG1vZGVsKSA9PlxyXG4gICAgICAgICAgICB7XHJcbiAgICAgICAgICAgICAgICB2YXIgcHJvcGVydHlOYW1lID0gR2V0UHJvcGVydHlOYW1lKG1vZGVsLkNvbnRleHQsIGV4cHJlc3Npb24obW9kZWwuQ29udGV4dCkpO1xyXG4gICAgICAgICAgICAgICAgTW9ja1Byb3BlcnR5KG1vZGVsLkNvbnRleHQsIHByb3BlcnR5TmFtZSwgdmFsdWVGdW5jLCB0cnVlKTtcclxuICAgICAgICAgICAgfTtcclxuICAgICAgICAgICAgcmV0dXJuIG5ldyBUZXN0U3RlcFdpdGhQYXJhbTxJQ29tcG9uZW50VGVzdE1vZGVsPFRDb250cm9sbGVyPj4oYWN0aW9uLCBcIlNldFZhbHVlXCIsIFN0ZXBUeXBlLldIRU4pO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgLy8vIDxzdW1tYXJ5PlxyXG4gICAgICAgIC8vLyDQodC10YDQstC40YEg0LTQu9GPINGB0L7Qt9C00LDQvdC40Y8g0LzQvtC00LXQu9C4INC60L7QvNC/0L7QvdC10L3RgtCwXHJcbiAgICAgICAgLy8vIDwvc3VtbWFyeT5cclxuICAgICAgICBJVGVzdENvbXBvbmVudENyZWF0b3JTZXJ2aWNlIElDb21wb25lbnRUZXN0LlRlc3RDb21wb25lbnRDcmVhdG9yU2VydmljZSB7IGdldDsgc2V0OyB9XHJcbi8vLyA8c3VtbWFyeT5cclxuLy8vINCk0YPQvdC60YbQuNGPINGB0L7Qt9C00LDQvdC40Y8g0YLQtdGB0YLQvtCy0L7QuSDQvNC+0LTQtdC70Lgg0LrQvtC80L/QvtC90LXQvdGC0LBcclxuLy8vIDwvc3VtbWFyeT5cclxucHJvdGVjdGVkIG92ZXJyaWRlIEZ1bmM8SUNvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4+IE1vZGVsXHJcbntcclxuICAgIGdldFxyXG4gICAge1xyXG4gICAgICAgIHJldHVybiBDcmVhdGVUZXN0TW9kZWw7XHJcbiAgICB9XHJcbn1cclxuICAgICAgICBwcml2YXRlIElDb21wb25lbnRUZXN0TW9kZWw8VENvbnRyb2xsZXI+IENyZWF0ZVRlc3RNb2RlbCgpXHJcbiAgICAgICAge1xyXG4gICAgICAgICAgICB2YXIgY29tcG9uZW50Q3JlYXRvciA9ICh0aGlzIGFzIElDb21wb25lbnRUZXN0KS5UZXN0Q29tcG9uZW50Q3JlYXRvclNlcnZpY2U7XHJcbiAgICAgICAgICAgIHZhciB2aWV3TW9kZWwgPSBjb21wb25lbnRDcmVhdG9yLkNyZWF0ZU1vZGVsPElDb21wb25lbnRWaWV3SXRlbVZpZXdNb2RlbD4oQ29tcG9uZW50VWlkKTtcclxuICAgICAgICAgICAgdmFyIG1vZGVsID0gbmV3IENvbXBvbmVudFRlc3RNb2RlbDxUQ29udHJvbGxlcj4odmlld01vZGVsLkNvbnRleHQsIHZpZXdNb2RlbC5Db250cm9sbGVyKTtcclxuICAgICAgICAgICAgcmV0dXJuIG1vZGVsO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBNZXRob2RJbmZvIEdldE1ldGhvZEluZm8oTGFtYmRhRXhwcmVzc2lvbiBleHByZXNzaW9uKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgdmFyIHVuYXJ5RXhwcmVzc2lvbiA9IChVbmFyeUV4cHJlc3Npb24pZXhwcmVzc2lvbi5Cb2R5O1xyXG4gICAgICAgICAgICB2YXIgbWV0aG9kQ2FsbEV4cHJlc3Npb24gPSB1bmFyeUV4cHJlc3Npb24uT3BlcmFuZCBhcyBNZXRob2RDYWxsRXhwcmVzc2lvbjtcclxuICAgICAgICAgICAgdmFyIG1ldGhvZEluZm9FeHByZXNzaW9uID0gKENvbnN0YW50RXhwcmVzc2lvbiltZXRob2RDYWxsRXhwcmVzc2lvbi5PYmplY3Q7XHJcbiAgICAgICAgICAgIHZhciBtZXRob2RJbmZvID0gKE1ldGhvZEluZm8pbWV0aG9kSW5mb0V4cHJlc3Npb24uVmFsdWU7XHJcbiAgICAgICAgICAgIHJldHVybiBtZXRob2RJbmZvO1xyXG4gICAgICAgIH1cclxuXHJcbiAgICAgICAgcHJpdmF0ZSBzdHJpbmcgR2V0UHJvcGVydHlOYW1lKG9iamVjdCB0YXJnZXQsIG9iamVjdCBwcm9wKVxyXG4gICAgICAgIHtcclxuICAgICAgICAgICAgc3RyaW5nIG5hbWUgPSBudWxsO1xyXG4gICAgICAgICAgICAvKkBcclxuICAgICAgICAgICAgdmFyIGtleXMgPSBPYmplY3QuZ2V0T3duUHJvcGVydHlOYW1lcyh0YXJnZXQpXHJcbiAgICAgICAgICAgIGZvciAodmFyIGkgPSAwOyBpIDwga2V5cy5sZW5ndGg7IGkrKykge1xyXG4gICAgICAgICAgICAgICAgdmFyIHByb3BlcnR5RGVzY3JpcHRvciA9IE9iamVjdC5nZXRPd25Qcm9wZXJ0eURlc2NyaXB0b3IodGFyZ2V0LCBrZXlzW2ldKTtcclxuICAgICAgICAgICAgICAgIGlmICh0eXBlb2YgcHJvcGVydHlEZXNjcmlwdG9yLmdldCA9PT0gXCJmdW5jdGlvblwiICYmIHByb3BlcnR5RGVzY3JpcHRvci5nZXQoKSA9PT0gcHJvcCkge1xyXG4gICAgICAgICAgICAgICAgICAgIG5hbWUgPSBrZXlzW2ldO1xyXG4gICAgICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgICovXHJcblxyXG4gICAgICAgICAgICByZXR1cm4gbmFtZTtcclxuICAgICAgICB9XHJcblxyXG4gICAgICAgIHByaXZhdGUgdm9pZCBNb2NrUHJvcGVydHkob2JqZWN0IHRhcmdldCwgc3RyaW5nIHByb3BlcnR5TmFtZSwgb2JqZWN0IG1vY2ssIGJvb2wgY29tcHV0ZWQgPSBmYWxzZSlcclxuICAgICAgICB7XHJcbiAgICAgICAgICAgIC8qQFxyXG4gICAgICAgICAgICB2YXIgYXR0cmlidXRlcyA9IHtcclxuICAgICAgICAgICAgICAgIGNvbmZpZ3VyYWJsZTogdHJ1ZSxcclxuICAgICAgICAgICAgICAgIGdldDogZnVuY3Rpb24oKSB7XHJcbiAgICAgICAgICAgICAgICAgICAgcmV0dXJuIGNvbXB1dGVkID8gbW9jaygpIDogbW9jaztcclxuICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgfTtcclxuXHJcbiAgICAgICAgICAgIE9iamVjdC5kZWZpbmVQcm9wZXJ0eSh0YXJnZXQsIHByb3BlcnR5TmFtZSwgYXR0cmlidXRlcyk7XHJcbiAgICAgICAgICAgICovXHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcbiJdCn0K
