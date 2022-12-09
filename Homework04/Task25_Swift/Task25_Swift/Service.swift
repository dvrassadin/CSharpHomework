//
//  Service.swift
//  Task25_Swift
//
//  Created by Daniil Rassadin on 9/12/22.
//

import Foundation

/**
 Вовзращает результат возведения числа в натуральную степень или nil если указана ненатуральная степень.
 */
func Exponentiation(number: Int, in pow: Int) -> Int? {
    var result: Int? = nil
    if pow <= 0 {
        return result
    }
    
    if number == 0{
        result = 0
    } else {
        result = number
        for _ in 1..<pow {
            result! *= number
        }
    }
    return result
}
