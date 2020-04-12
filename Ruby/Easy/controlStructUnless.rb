def scoring(array) 
    array.each { |user| user.update_score unless user.is_admin? }
end
