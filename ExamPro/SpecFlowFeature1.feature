Feature: Trigonometrische Funktionen
	In order to calculate the trigonometric functions
	As a math idiot
	I want to be told the sine, cosine and tangen


Scenario Outline: Calculate sine 
	Given the angle alpha is <phi>
	When the sin function is pressed
	Then the result for sine should be <sin_phi>

Examples: 
| phi      | sin_phi |
| 0.0      | 0.0     |
| 3.141597 | 0.0     |

Scenario Outline: Calculate cosine 
	Given the angle alpha is <phi>
	When the cosin function is pressed
	Then the result for sine should be <cos_phi>

Examples: 
| phi      | cos_phi |
| 0.0      | 1.0     |
| 3.141597 | -1.0     |

Scenario Outline: Calculate tan
	Given the angle alpha is <phi>
	When the tan function is pressed
	Then the result for sine should be <tan_phi>

Examples: 
| phi      | tan_phi |
| 0.0      | 0.0     |
| 3.141597 | 0.0     |

