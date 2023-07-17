import React from 'react'

import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'

import { FaHome } from 'react-icons/fa'
import { FaUser } from 'react-icons/fa'
import { FaPills } from 'react-icons/fa'
import { FaLightbulb } from 'react-icons/fa'
import { FaRegListAlt } from 'react-icons/fa'
import styles from './Sidebar.module.css'

export default function Sidebar() {
	const { theme } = useSelector(state => state.theme)

  return (
		<nav className={`${styles.sidebar} ${theme === 'dark' && styles.dark}`}>
			<ul>
				<li>
					<Link to='/admin'>
						<FaHome />
					</Link>
				</li>
				<li>
					<Link to='/admin/users'>
						<FaUser />
					</Link>
				</li>
				<li>
					<Link to='/admin/drugs'>
						<FaPills />
					</Link>
				</li>
				<li>
					<Link to='/admin/documentations'>
						<FaRegListAlt />
					</Link>
				</li>
				<li>
					<Link to='/admin/advices'>
						<FaLightbulb />
					</Link>
				</li>
			</ul>
		</nav>
	)
}
