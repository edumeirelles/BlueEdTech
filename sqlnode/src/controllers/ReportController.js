const { Op } = require('sequelize')
const User = require('../models/User');

module.exports = {
    async show(req, res){
       //return res.json({ report: true }) 

       const users = await User.findAll({
           attributes:['name', 'email'],
           where:{
               email: {
                   [Op.iLike]: '%@yahoo.com.br'
               }
           },
           include: [
               { association: 'addresses', where: { street: 'Rua Visconde de Inhaúma' } },
               { 
                association: 'techs', 
                required: false,
                where: {
                    name: {
                        [Op.iLike]: '%Python%'
                    }
               }
            },
           ]
       })

       return res.json(users);
    }
};