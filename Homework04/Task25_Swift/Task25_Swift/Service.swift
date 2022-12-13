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
    if pow <= 0 {
        return nil
    }
    if number == 0 {
        return 0
    } else {
        var result = number
        for _ in 1..<pow {
            result *= number
        }
        return result
    }
}
