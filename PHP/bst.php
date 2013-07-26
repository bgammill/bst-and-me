<?php
class Node {
	public $value;
	public $left;
	public $right;

	public function __construct($val) {
		$this->value = $val;
	}
}

class Tree {
	public $root = undefined;

	public function __construct($rootValue) {
		$this->root = new Node($rootValue);
	}

	public function insert($value) {
		$currentNode = $this->root;

		while (true) {
			if ($currentNode->value > $value) {
				if (isset($currentNode->left)) {
					$currentNode = $currentNode->left;
					continue;
				} else {
					$currentNode->left = new Node($value);
					break;
				}
			} else if ($currentNode->value < $value) {
				if (isset($currentNode->right)) {
					$currentNode = $currentNode->right;
					continue;
				} else {
					$currentNode->right = new Node($value);
					break;
				}
			} else {
				break;
			}
		}
	}

	public function find($value) {
		$currentNode = $this->root;

		while (true) {
			if ($currentNode->value == $value) {
				return $currentNode;
			} else if ($currentNode->value > $value) {
				$currentNode = $currentNode->left;
				continue;
			} else if ($currentNode->value < $value) {
				$currentNode = $currentNode->right;
				continue;
			}
		}
	}
}

$tree = new Tree(8);
$tree->insert(4);
$tree->insert(2);
$tree->insert(6);
$tree->insert(11);

echo '<pre>';
var_dump($tree->find(4));
echo '</pre>';
?>