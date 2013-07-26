var BST = (function() {

	function Tree(rootValue) {
		this.root = new Node(rootValue);
	};

	Tree.prototype.insert = function(value) {
		var currentNode = this.root;

		while (true) {
			if (currentNode.value > value) {
				if (currentNode.left) {
					currentNode = currentNode.left;
					continue;
				} else {
					currentNode.left = new Node(value);
					break;
				}
			} else if (currentNode.value < value) {
				if (currentNode.right) {
					currentNode = currentNode.right;
					continue;
				} else {
					currentNode.right = new Node(value);
					break;
				}
			} else {
				break;
			}
		}
	};

	Tree.prototype.find = function(value) {
		var currentNode = this.root;

		while (true) {
			if (currentNode.value == value) {
				return currentNode;
			} else if (currentNode.value > value) {
				currentNode = currentNode.left;
				continue;
			} else if (currentNode.value < value) {
				currentNode = currentNode.right;
				continue;
			}
		}
	};

	function Node(value) {
		this.value = value;
		this.left = undefined;
		this.right = undefined;
	};

	return {
		Tree: Tree
	}
}());